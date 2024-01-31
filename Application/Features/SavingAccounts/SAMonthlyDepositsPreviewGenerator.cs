using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf;
using Service.Core.DataModel;
using Service.Core.Dtos.SavingAccountsDto;
using Service.Core.Dtos;
using Service.Core;
using Service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Features.SavingAccounts
{
    public class SAMonthlyDepositsPreviewGenerator
    {
        private readonly IMoneySaverRepository _moneySaverRepo;
        private List<MonthlyDepositsForPreviewDto> DepositsForPreviewDtos;
        private List<MonthlyAmountsFromPDFDto> DepositsDataFromPDF;
        public List<SavingAccountsDataModel> SavingAccountsWithDepositsData { get; private set; }
        public int SubPeriodID { get; private set; }
        public int PeriodID { get; set; }
        public SAMonthlyDepositsPreviewGenerator(IMoneySaverRepository moneySaverRepo)
        {
            _moneySaverRepo = moneySaverRepo;
            DepositsForPreviewDtos = new List<MonthlyDepositsForPreviewDto>();
            DepositsDataFromPDF = new List<MonthlyAmountsFromPDFDto>();
            SavingAccountsWithDepositsData = new List<SavingAccountsDataModel>();
        }

        public Result<List<MonthlyDepositsForPreviewDto>> GenerateMonthlyDepositsForPreview(string path, DateTime date)
        {
            try
            {
                var subPeriod = _moneySaverRepo.GetSubPeriodIDFromDate(date);

                SubPeriodID = subPeriod != null ? subPeriod.SubPeriodID : 0; 
                PeriodID = subPeriod != null ? subPeriod.PeriodID : 0; 

                if (SubPeriodID == 0)
                    return Result<List<MonthlyDepositsForPreviewDto>>.Failure("No existe un subperiodo para la fecha seleccionada.");

                var monthlyAmountsFromPDFExtractor = new MonthlyAmountsPDFExtractor();

                DepositsDataFromPDF = monthlyAmountsFromPDFExtractor.GetMonthlyAmountsFromPDFDto(path,date);

                SavingAccountsWithDepositsData = _moneySaverRepo.GetSavingAccountsWithDepositsForPeriodData(PeriodID);

                SetDepositsForPreviewDtos(date);

                return Result<List<MonthlyDepositsForPreviewDto>>.Success(DepositsForPreviewDtos.OrderBy(a => a.IsValid).ThenBy(a => a.ErrorMessage).ThenBy(a => a.INSSNo).ToList());
            }
            catch (ServiceValidationException ex)
            {
                return Result<List<MonthlyDepositsForPreviewDto>>.Failure(ex.Message);
            }   

            catch (Exception ex)
            {
                Helper.SendErrorToText(ex);
                return Result<List<MonthlyDepositsForPreviewDto>>.Failure(ex.Message);
            }  
        }

        private void SetDepositsForPreviewDtos(DateTime depositDate)
        {
            var saDepositsDataForSubPeriod = SavingAccountsWithDepositsData
                .SelectMany(a => a.Deposits)
                .Where(d => d.SubPeriodID == SubPeriodID)
                .ToList();

            foreach (var saData in SavingAccountsWithDepositsData)
            {
                var monthlyDepositPreview = new MonthlyDepositsForPreviewDto
                {
                    SavingAccountID = saData.SavingAccountID,
                    INSSNo = saData.Client.INSS,
                    ClientFullName = saData.Client.GetClientFullName(),
                    IsValid = false,
                    Amount = 0,
                    Date = depositDate
                };

                SetAmountToDepositForPreviewIfValid(monthlyDepositPreview, saDepositsDataForSubPeriod);
                SetErrorMessageIfMonthlyDepositNotValid(monthlyDepositPreview, saDepositsDataForSubPeriod);

                DepositsForPreviewDtos.Add(monthlyDepositPreview);
            }

            AddDepositForPreviewNotFoundInDatabase();
        }

        private void SetAmountToDepositForPreviewIfValid(MonthlyDepositsForPreviewDto monthlyDepositPreview, 
            List<SavingAccountDepositsDataModel> saDepositsDataForSubPeriod)
        {
            var monthlyDepositDataForDto = DepositsDataFromPDF
                .FirstOrDefault(a => a.INSSNo == monthlyDepositPreview.INSSNo);

            bool doDepositExistsForTheSubPeriod = saDepositsDataForSubPeriod
                .Any(a => a.SavingAccountID == monthlyDepositPreview.SavingAccountID);

            if (monthlyDepositDataForDto != null && doDepositExistsForTheSubPeriod == false)
            {
                monthlyDepositPreview.IsValid = true;
                monthlyDepositPreview.Amount = monthlyDepositDataForDto.Amount;
            }
        }
        
        private void SetErrorMessageIfMonthlyDepositNotValid(MonthlyDepositsForPreviewDto monthlyDepositPreview, 
            List<SavingAccountDepositsDataModel> saDepositsDataForSubPeriod)
        {
            if (monthlyDepositPreview.IsValid == false)
            {
                bool doDepositExistsForTheSubPeriod = saDepositsDataForSubPeriod
                .Any(a => a.SavingAccountID == monthlyDepositPreview.SavingAccountID);

                if (doDepositExistsForTheSubPeriod == true)
                    monthlyDepositPreview.ErrorMessage = "Ya existe una cotización para este mes.";

                var doDepositExistsInPDF = DepositsDataFromPDF
                .Any(a => a.INSSNo == monthlyDepositPreview.INSSNo);

                if (doDepositExistsInPDF == false)
                    monthlyDepositPreview.ErrorMessage = "No existe cotización en el archivo PDF.";
            }
        }

        private void AddDepositForPreviewNotFoundInDatabase()
        {
            var monthlyDepositsNotFoundInDB = DepositsDataFromPDF
                .Where(md => SavingAccountsWithDepositsData.Select(sa => sa.Client.INSS).Contains(md.INSSNo) == false )
                .ToList();

            monthlyDepositsNotFoundInDB.ForEach(md =>
            {
                var monthlyDepositPreview = new MonthlyDepositsForPreviewDto
                {
                    SavingAccountID = 0,
                    INSSNo = md.INSSNo,
                    ClientFullName = "NO EXISTE",
                    IsValid = false,
                    Amount = md.Amount,
                    ErrorMessage = "No existe afiliado en el sistema."
                };

                DepositsForPreviewDtos.Add(monthlyDepositPreview);
            });
        }
    }
}
