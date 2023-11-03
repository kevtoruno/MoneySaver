using OfficeOpenXml;
using Service.Core.Dtos.LoansDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Features.PDFDataExtractor
{
    internal class LoanDataExcelExtractor
    {
        //ExcelPackage.LicenseContext = LicenseContext.;
        private List<LoansForPreviewMassCreationDto> loansForPreviewDto;

        public List<LoansForPreviewMassCreationDto> CreateDtoFromExcelFile(string path)
        {
            loansForPreviewDto = new List<LoansForPreviewMassCreationDto>();

            FileInfo file = new FileInfo(path);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int colCount = worksheet.Dimension.End.Column;  //get Column Count
                int rowCount = worksheet.Dimension.End.Row;

                AddLoanDataToDto(worksheet, rowCount);
            }

            return loansForPreviewDto;
        }

        private void AddLoanDataToDto(ExcelWorksheet worksheet, int rowCount)
        {
            for (int row = 4; row <= rowCount; row++)
            {
                var loanForPreviewToAdd = new LoansForPreviewMassCreationDto();

                var INSSNo = worksheet.Cells[row, 2].Value?.ToString().Trim();

                if (string.IsNullOrEmpty(INSSNo))
                    return;

                var dateFromExcel = worksheet.Cells[row, 4].Value?.ToString().Trim();
                var date = DateTime.FromOADate(Convert.ToDouble(dateFromExcel));
                var CKCode = worksheet.Cells[row, 5].Value?.ToString().Trim();
                var loanAmount = worksheet.Cells[row, 6].Value?.ToString().Trim();
                var totalInstallments = worksheet.Cells[row, 7].Value?.ToString().Trim();

                loanForPreviewToAdd.INSSNo = INSSNo;
                loanForPreviewToAdd.Date = date.AddMonths(1);
                loanForPreviewToAdd.CKCode = CKCode;
                loanForPreviewToAdd.TotalInstallments = Convert.ToInt32(totalInstallments);
                loanForPreviewToAdd.LoanAmount = Convert.ToDecimal(loanAmount);

                loansForPreviewDto.Add(loanForPreviewToAdd);
            }
        }
    }
}
