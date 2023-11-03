using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf;
using Service.Core.Dtos;
using Service.Core.Dtos.SavingAccountsDto;
using Service.Features.SavingAccounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Core;

namespace Service.Features
{
    internal class MonthlyAmountsPDFExtractor
    {
        //By default employee data starts at line 9, but it can change to 10 if date its on a different line.
        private int EMPLOYEES_DATA_PDF_START_LINE = 9; 
        public List<MonthlyAmountsFromPDFDto> MonthlyAmountsDto { get; private set; }

        public MonthlyAmountsPDFExtractor()
        {
            MonthlyAmountsDto = new List<MonthlyAmountsFromPDFDto>();
        }

        public List<MonthlyAmountsFromPDFDto> GetMonthlyAmountsFromPDFDto(string path, DateTime date)
        {
            try
            {
                var pdfDocument = new PdfDocument(new PdfReader(path));

                if (pdfDocument.GetNumberOfPages() <= 0)
                    throw new ServiceValidationException("Archivo PDF invalido");

                bool isPDFDateValid = CheckIfPDFDateIsValid(pdfDocument, date);

                if (isPDFDateValid == false)
                    throw new ServiceValidationException("La fecha seleccionada no coincide con la fecha del archivo PDF");

                for (int i = 1; i <= pdfDocument.GetNumberOfPages(); i++)
                {
                    var page = pdfDocument.GetPage(i);

                    string textPage = PdfTextExtractor.GetTextFromPage(page);

                    ProcessTextPage(textPage);
                }

                return MonthlyAmountsDto;
            }
            catch (ServiceValidationException ex)
            {
                throw ex;
            }
            catch (Exception)
            {
                throw new Exception("La estructura del archivo PDF no es valida.");
            }
        }

        private bool CheckIfPDFDateIsValid(PdfDocument pdfDocument,  DateTime date)
        {
            try
            {
                bool isDateValid = false;

                string firstPage = PdfTextExtractor.GetTextFromPage(pdfDocument.GetPage(1));

                var splittedLinesFromPage = firstPage.Split('\n');

                var dateFromPDF = GetDateFromFirstPage(splittedLinesFromPage);

                if (date.Month == dateFromPDF.Month && date.Year == dateFromPDF.Year)
                    isDateValid = true;

                return isDateValid;
            }
            catch (Exception)
            {
                throw; /*If there was a parsing error during this validation... 
                              *let's just ignore the validation itself. In the end this validation is more of a bonus.*/
            }   
        }

        private DateTime GetDateFromFirstPage(string[] splittedLinesFromPage) 
        {
            string dateLineString = splittedLinesFromPage[3];
            string dateDataString = "";

            if (dateLineString.Length > 7)
                dateDataString = splittedLinesFromPage[3].Remove(0,7);

            DateTime date;

            //This mean that line 3 is not a date, and most likely it is line 4.
            if (DateTime.TryParse(dateDataString, out date) == false) 
            {
                date = DateTime.Parse(splittedLinesFromPage[4].Remove(0,7));
                EMPLOYEES_DATA_PDF_START_LINE = 10; //Which also means that employee data will start at line 10.
            }

            return date;
        }

        public void ProcessTextPage(string textPage)
        {
            try
            {
                var splitted = textPage.Split('\n');

                foreach (var monthlyAmountDataString in splitted.Skip(EMPLOYEES_DATA_PDF_START_LINE).SkipLast(1))
                {
                    bool isDepositDataValid = CheckIfMonthlyAmountDataStringIsValid(monthlyAmountDataString);

                    if (isDepositDataValid == false)
                        break;

                    AddMonthlyAmount(monthlyAmountDataString);
                }
            }
            catch (Exception)
            {
                throw new ServiceValidationException("Hubo un error al procesar el archivo PDF.");
            }
        }

        private bool CheckIfMonthlyAmountDataStringIsValid(string monthlyAmountDataString)
        {
            bool isValid;
            try
            {
                isValid = Char.IsNumber(monthlyAmountDataString[0]);

                GetINSSNoFromMonthlyAmountData(monthlyAmountDataString);
                GetAmountFromMonthlyAmountData(monthlyAmountDataString);

                return isValid;
            }
            catch (Exception)
            {
                isValid = false;
                return isValid;
            }
        }

        private void AddMonthlyAmount(string depositData)
        {
            var savingAccountDto = new MonthlyAmountsFromPDFDto();

            savingAccountDto.INSSNo = GetINSSNoFromMonthlyAmountData(depositData);
            savingAccountDto.Amount = GetAmountFromMonthlyAmountData(depositData);

            MonthlyAmountsDto.Add(savingAccountDto);
        }

        private string GetINSSNoFromMonthlyAmountData(string depositData)
        {
            StringBuilder INSSNo = new StringBuilder();

            foreach (var charVal in depositData)
            {
                if (charVal == ' ')
                    break;

                INSSNo.Append(charVal);
            }

            return INSSNo.ToString();
        }

        private decimal GetAmountFromMonthlyAmountData(string depositData)
        {
            StringBuilder reversedStringAmount = new StringBuilder();

            foreach (var charVal in depositData.Reverse())
            {
                if (charVal == ' ')
                    break;

                reversedStringAmount.Append(charVal);
            }

            var charArrayAmount = reversedStringAmount.ToString().ToCharArray();
            Array.Reverse(charArrayAmount);
          
            string stringAmount = new(charArrayAmount);

            return Convert.ToDecimal(stringAmount);
        }

    }
}
