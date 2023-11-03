using Service.Core.Dtos.SavingAccountsDto;
using Service.Core;
using Service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Core.Dtos.LoansDto;
using Service.Core.DataModel;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf;
using Service.Features.SavingAccounts;
using Service.Core.Dtos;
using System.Globalization;

namespace Service.Features.Loans
{
    internal class LoansMonthlyPaymentsPreviewGenerator
    {
        private readonly IMoneySaverRepository _moneySaverRepo;
        private readonly ILoansRepository _loansRepository;
        private List<MonthlyLoanPaymentsForPreviewDto> PaymentsForPreviewDtos;
        private List<MonthlyAmountsFromPDFDto> PaymentDataFromPDF;
        private List<LoansDataModel> loansData;
        private List<LoanInstallmentsDataModel> PendingInstallmentsForSubPeriod;
        public int SubPeriodID { get; private set; }
        public List<LoansDataModel> LoansData { get => loansData; }
        public LoansMonthlyPaymentsPreviewGenerator(IMoneySaverRepository moneySaverRepo,
            ILoansRepository loansRepository)
        {
            _loansRepository = loansRepository;
            _moneySaverRepo = moneySaverRepo;
            loansData = new List<LoansDataModel>();
            PendingInstallmentsForSubPeriod = new List<LoanInstallmentsDataModel>();
            PaymentDataFromPDF = new List<MonthlyAmountsFromPDFDto>();
            PaymentsForPreviewDtos = new List<MonthlyLoanPaymentsForPreviewDto>();
        }

        public Result<List<MonthlyLoanPaymentsForPreviewDto>> GenerateMonthlyPaymentsForPreview(string path, DateTime date)
        {
            try
            {
                var subPeriod = _moneySaverRepo.GetSubPeriodIDFromDate(date);

                SubPeriodID = subPeriod != null ? subPeriod.SubPeriodID : 0; 

                if (SubPeriodID == 0)
                    return Result<List<MonthlyLoanPaymentsForPreviewDto>>.Failure("No existe un subperiodo para la fecha seleccionada.");

                var monthlyAmountsFromPDFExtractor = new MonthlyAmountsPDFExtractor();

                PaymentDataFromPDF = monthlyAmountsFromPDFExtractor.GetMonthlyAmountsFromPDFDto(path,date);   

                loansData = _loansRepository.GetLoansWithInstallments();

                PendingInstallmentsForSubPeriod = loansData.SelectMany(l => l.LoanInstallments
                .Where(li => li.IsPaid == false && li.SubPeriodID == SubPeriodID))
                .ToList();

                SetInstallmentsForPreview();
                AddNonExistingPDFPaymentsNotFoundInDatabase(date);

                return Result<List<MonthlyLoanPaymentsForPreviewDto>>.Success(PaymentsForPreviewDtos.OrderBy(a => a.IsValid).ThenBy(a => a.INSSNo).ToList());
            }
            catch (FormatException ex)
            {
                Helper.SendErrorToText(ex);
                return Result<List<MonthlyLoanPaymentsForPreviewDto>>.Failure(ex.Message);
            }   

            catch (Exception ex)
            {
                Helper.SendErrorToText(ex);
                return Result<List<MonthlyLoanPaymentsForPreviewDto>>.Failure(ex.Message);
            }  
        }

        private void SetInstallmentsForPreview()
        {
            foreach (var pendingInstallment in PendingInstallmentsForSubPeriod)
            {
                var paymentPreview = new MonthlyLoanPaymentsForPreviewDto
                {
                    PendingAmount = pendingInstallment.Amount,
                    ClientFullName = pendingInstallment.Loan.Client.GetClientFullName(),
                    IsValid = false,
                    Date = pendingInstallment.DueDate,
                    ErrorMessage = "",
                    INSSNo = pendingInstallment.Loan.Client.INSS,
                    LoanID = pendingInstallment.LoanID,
                    LoanInstallmentID = pendingInstallment.LoanInstallmentID,
                    PaymentAmount = 0
                };

                SetValidPaymentPreviewIfExistsOnPDFData(paymentPreview);

                PaymentsForPreviewDtos.Add(paymentPreview);
            }
        }

        private void SetValidPaymentPreviewIfExistsOnPDFData(MonthlyLoanPaymentsForPreviewDto paymentPreview)
        {
            var paymentDataFromPDF = PaymentDataFromPDF.FirstOrDefault(p => p.INSSNo == paymentPreview.INSSNo);

            if (paymentDataFromPDF == null)
            {
                paymentPreview.IsValid = false;
                paymentPreview.ErrorMessage = "No existe un pago en el PDF para este préstamo";
            }
            else
            {   
                paymentPreview.IsValid = true;
                paymentPreview.PaymentAmount = paymentDataFromPDF.Amount;

                //Porque PDFAmount +1? Por si cualquier posible error decimal
                //que exista entre lo que viene en el PDF y lo que está en BD.
                if (paymentPreview.PendingAmount > (paymentDataFromPDF.Amount + 1))
                    paymentPreview.ErrorMessage = "Pago parcial";                
            }
        }

        private void AddNonExistingPDFPaymentsNotFoundInDatabase(DateTime date)
        {
            var paymentsNotFoundInDB = PaymentDataFromPDF
                .Where(p => PendingInstallmentsForSubPeriod.Select(pli => pli.Loan.Client.INSS).Contains(p.INSSNo) == false)
                .ToList();

            paymentsNotFoundInDB.ForEach(pli =>
            {
                var notFoundPaymentPreview = new MonthlyLoanPaymentsForPreviewDto
                {
                    PendingAmount = 0,
                    ClientFullName = "",
                    IsValid = false,
                    Date = date,
                    ErrorMessage = "No existe un préstamo asociado.",
                    INSSNo = pli.INSSNo,
                    PaymentAmount = pli.Amount,
                    LoanInstallmentID = 0
                };

                PaymentsForPreviewDtos.Add(notFoundPaymentPreview);
            });
        }
    }
}
