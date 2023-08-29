using AutoMapper;
using Service.Core;
using Service.Core.DataModel;
using Service.Core.Dtos;
using Service.Core.Dtos.LoansDto;
using Service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Service.Features.Loans
{
    public class LoansList
    {
        private readonly ILoansRepository _loansRepo;
        private readonly IMapper _mapper;
        private LoansDataModel loanData = new();
        public LoansList(ILoansRepository loansRepo, IMapper mapper)
        {
            _loansRepo = loansRepo;
            _mapper = mapper;
        }

        public List<LoansToListDto> GetLoansList(string INSS) 
        {
            var loansToListDto = _loansRepo.GetLoansList(INSS);

            return loansToListDto;
        }

        public LoanToDetailDto GetLoanDetail(int loanID)
        {
            loanData = _loansRepo.GetLoanDetail(loanID);

            var loanDetailDto = _mapper.Map<LoanToDetailDto>(loanData);
            loanDetailDto.ClientFullName = loanData.Client.GetClientFullName();

            SetInstallmentsIntoDto(loanDetailDto);
            SetPaymentsIntoDto(loanDetailDto);

            loanDetailDto.TransactionHistory = loanDetailDto
                .TransactionHistory.OrderBy(a => a.Date)
                .ToList();

            return loanDetailDto;
        }

        private void SetInstallmentsIntoDto(LoanToDetailDto loanToDetailDto)
        {
            loanData.LoanInstallments.ToList().ForEach(ins =>
            {
                var subPeriodName = "";

                if (ins.SubPeriod != null) 
                {
                    var date = new DateTime(ins.SubPeriod.StartDate.Year, ins.SubPeriod.Month, 1);

                    subPeriodName = $"{date.ToString("MMMM")} {ins.SubPeriod.StartDate.Year}";
                }

                var installmentDto = _mapper.Map<LoanTransactionsDto>(ins);

                installmentDto.DueAmountDisplay = ins.DueAmount.CordobaFormat();
                installmentDto.SubPeriodName = subPeriodName;
                installmentDto.Date = ins.DueDate;
                installmentDto.TransactionType = LoanTransactionType.Installment;
                
                loanToDetailDto.TransactionHistory.Add(installmentDto);
            });
        }

        private void SetPaymentsIntoDto(LoanToDetailDto loanToDetailDto)
        {
            loanData.LoanPaymentHistories.ToList().ForEach(pay =>
            {
                var subPeriodName = "Pago extraordinario";

                if (pay.SubPeriod != null)
                {
                    var date = new DateTime(pay.SubPeriod.StartDate.Year, pay.SubPeriod.Month, 1);

                    subPeriodName = $"{date.ToString("MMMM")} {pay.SubPeriod.StartDate.Year}";
                }

                var paymentHistoryDto = new LoanTransactionsDto
                {
                    Amount = pay.Amount.CordobaFormat(),
                    DueAmountDisplay = " ",
                    SubPeriodName = subPeriodName,
                    LoanInstallmentID = pay.LoanHistoryID,
                    DatePaid = pay.Date,
                    Date = pay.Date
                };

                if (pay.IsExtraPayment)
                    paymentHistoryDto.TransactionType = LoanTransactionType.ExtraPayment;
                else
                    paymentHistoryDto.TransactionType = LoanTransactionType.InstallmentPayment;

                loanToDetailDto.TransactionHistory.Add(paymentHistoryDto);
            });
        }
    }
}
