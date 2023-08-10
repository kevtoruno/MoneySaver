using Service.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Service.Features.SavingAccounts
{
    public class MonthlyDepositsDtoGenerator
    {
        public List<MonthlyDepositsFromPDFDto> MonthlyDeposits { get; private set; }

        private const int EMPLOYEES_DATA_START = 9;
        public MonthlyDepositsDtoGenerator()
        {
            MonthlyDeposits = new List<MonthlyDepositsFromPDFDto>();
        }

        public void ProcessTextPage(string textPage)
        {
            try
            {
                var splitted = textPage.Split('\n');

                foreach (var depositData in splitted.Skip(EMPLOYEES_DATA_START).SkipLast(1))
                {
                    bool isDepositDataValid = CheckIfDepositDataIsValid(depositData);

                    if (isDepositDataValid == false)
                        return;

                    AddSavingAccountDeposit(depositData);
                }
            }
            catch (Exception)
            {
                throw new FormatException("Hubo un error al procesar el PDF");
            }
        }

        private bool CheckIfDepositDataIsValid(string depositData)
        {
            bool isValid;
            try
            {
                isValid = Char.IsNumber(depositData[0]);

                GetINSSNoFromDepositData(depositData);
                GetAmountFromDepositData(depositData);

                return isValid;
            }
            catch (Exception)
            {
                isValid = false;
                return isValid;
            }
        }

        private void AddSavingAccountDeposit(string depositData)
        {
            var savingAccountDto = new MonthlyDepositsFromPDFDto();

            savingAccountDto.INSSNo = GetINSSNoFromDepositData(depositData);
            savingAccountDto.Amount = GetAmountFromDepositData(depositData);

            MonthlyDeposits.Add(savingAccountDto);
        }

        private string GetINSSNoFromDepositData(string depositData)
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

        private decimal GetAmountFromDepositData(string depositData)
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
