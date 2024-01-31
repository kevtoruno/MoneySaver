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
        private MonthlyLoanPaymentsForPreviewViewModel ViewModel;
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

        public Result<MonthlyLoanPaymentsForPreviewViewModel> GenerateMonthlyPaymentsForPreview(string path, DateTime date, DateTime subPeriodDate)
        {
            try
            {
                var subPeriod = _moneySaverRepo.GetSubPeriodIDFromDate(subPeriodDate);

                SubPeriodID = subPeriod != null ? subPeriod.SubPeriodID : 0; 

                if (SubPeriodID == 0)
                    return Result<MonthlyLoanPaymentsForPreviewViewModel>.Failure("No existe un subperiodo para la fecha seleccionada.");

                var monthlyAmountsFromPDFExtractor = new MonthlyAmountsPDFExtractor();

                PaymentDataFromPDF = monthlyAmountsFromPDFExtractor.GetMonthlyAmountsFromPDFDto(path,date);   

                loansData = _loansRepository.GetLoansWithInstallments();

                PendingInstallmentsForSubPeriod = loansData.SelectMany(l => l.LoanInstallments
                .Where(li => li.IsPaid == false && li.SubPeriodID == SubPeriodID))
                .ToList();

                SetInstallmentsForPreview();
                AddNonExistingPDFPaymentsNotFoundInDatabase(date);

                PaymentsForPreviewDtos = PaymentsForPreviewDtos
                    .OrderBy(a => a.IsValid)
                    .ThenBy(a => a.ErrorMessage)
                    .ThenBy(a => a.INSSNo)
                    .ToList();

                SetViewModel();

                return Result<MonthlyLoanPaymentsForPreviewViewModel>.Success(ViewModel);
            }
            catch (FormatException ex)
            {
                Helper.SendErrorToText(ex);
                return Result<MonthlyLoanPaymentsForPreviewViewModel>.Failure(ex.Message);
            }   

            catch (Exception ex)
            {
                Helper.SendErrorToText(ex);
                return Result<MonthlyLoanPaymentsForPreviewViewModel>.Failure(ex.Message);
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

                bool alreadyExistingInvalidPayment = PaymentsForPreviewDtos.Any(p => p.IsValid == false
                && (int) p.PendingAmount == (int) paymentPreview.PendingAmount && 
                (int) p.PaymentAmount == (int) paymentPreview.PaymentAmount);

                if (alreadyExistingInvalidPayment == false)
                {
                    PaymentsForPreviewDtos.Add(paymentPreview);
                }

            }
        }

        private void SetValidPaymentPreviewIfExistsOnPDFData(MonthlyLoanPaymentsForPreviewDto paymentPreview)
        {
            var paymentsDataFromPDF = PaymentDataFromPDF.Where(p => p.INSSNo == paymentPreview.INSSNo).ToList();

            if (paymentsDataFromPDF.Count == 0)
            {
                paymentPreview.IsValid = false;
                paymentPreview.ErrorMessage = "No existe un pago en el PDF para este préstamo";
            }
            else
            {
                foreach (var paymentDataFromPDF in paymentsDataFromPDF)
                {
                    int nonDPendingAmount = (int)paymentPreview.PendingAmount;
                    int nonDPaymentAmount = (int)paymentDataFromPDF.Amount;

                    paymentPreview.PaymentAmount = paymentDataFromPDF.Amount;

                    if (nonDPendingAmount == nonDPaymentAmount)
                    {
                        paymentPreview.IsValid = true;

                        if (paymentsDataFromPDF.Count > 1)
                            paymentPreview.ErrorMessage = $"Existen {paymentsDataFromPDF.Count} pagos diferentes en el PDF";
                    }
                    else
                        AddPaymentAmountDifferentThanPendingAmount(paymentPreview, nonDPaymentAmount);
                }
            }
        }

        private void AddPaymentAmountDifferentThanPendingAmount(MonthlyLoanPaymentsForPreviewDto paymentPreview,
            int nonDPaymentAmount)
        {
            int nonDPendingAmount = (int) paymentPreview.PendingAmount;
            string errorMessage = "";

            if (nonDPendingAmount > nonDPaymentAmount)
                errorMessage = "El pago es menor a lo que está pendiente";
            else if (nonDPaymentAmount > nonDPendingAmount)
                errorMessage = "El pago es mayor a lo que está pendiente";

            var notFoundPaymentPreview = new MonthlyLoanPaymentsForPreviewDto
            {
                PendingAmount = paymentPreview.PendingAmount,
                ClientFullName = paymentPreview.ClientFullName,
                IsValid = false,
                Date = paymentPreview.Date,
                ErrorMessage = errorMessage,
                INSSNo = paymentPreview.INSSNo,
                PaymentAmount = nonDPaymentAmount,
                LoanInstallmentID = 0
            };

            PaymentsForPreviewDtos.Add(notFoundPaymentPreview);
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
                    ErrorMessage = "No existe una cuota pendiente.",
                    INSSNo = pli.INSSNo,
                    PaymentAmount = pli.Amount,
                    LoanInstallmentID = 0
                };

                PaymentsForPreviewDtos.Add(notFoundPaymentPreview);
            });
        }

        private void SetViewModel()
        {
            ViewModel = new MonthlyLoanPaymentsForPreviewViewModel();

            ViewModel.MonthlyPaymentsForPreview = PaymentsForPreviewDtos;
            ViewModel.TotalClientsFromPDF = PaymentDataFromPDF.Count;
            ViewModel.TotalPaymentAmountFromPDF = PaymentDataFromPDF.Sum(p => p.Amount).CordobaFormat();
            ViewModel.ValidPaymentsForProcessing = PaymentsForPreviewDtos.Where(p => p.IsValid).Count();

            ViewModel.TotalPendingAmountForSubperiod = PendingInstallmentsForSubPeriod.Sum(a => a.Amount).CordobaFormat();

            //Pagos existentes en el PDF pero no validos.
            ViewModel.NotValidPaymentsForProcessing = PaymentsForPreviewDtos 
                .Where(p => p.IsValid == false && p.ErrorMessage != "No existe un pago en el PDF para este préstamo")
                .Count();
        }
    }
}
