using AutoMapper;
using Domain;
using Domain.Entities.Loans;
using Service.Core;
using Service.Core.DataModel;
using Service.Core.Dtos.LoansDto;
using Service.Core.Dtos.SavingAccountsDto;
using Service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Features.Loans
{
    internal class LoansMonthlyPaymentCreator
    {
        private readonly IMoneySaverRepository _moneySaverRepo;
        private readonly IMapper _mapper;
        private readonly ILoansRepository _loansRepo;
        private int SubPeriodID = 0;
        private string CreatedMessage = "Se han procesado todos los pagos exitosamente";
        private List<MonthlyLoanPaymentsForPreviewDto> PaymentsFromPreview;
        private List<LoanDomain> LoansDomain;
        private CompanyDomain companyDomain;
        public LoansMonthlyPaymentCreator(IMoneySaverRepository moneySaverRepo, ILoansRepository loansRepo, IMapper mapper)
        {
            _moneySaverRepo = moneySaverRepo;
            _mapper = mapper;
            _loansRepo = loansRepo;
        }

        public Result<bool> CreateMonthlyPayments(string path, DateTime date)
        {
            try
            {
                var loansPaymentsPreviewGenerator = new LoansMonthlyPaymentsPreviewGenerator(_moneySaverRepo, _loansRepo);
                var loanPaymentsForPreview = loansPaymentsPreviewGenerator.GenerateMonthlyPaymentsForPreview(path, date);

                if (loanPaymentsForPreview.IsSucess == false)
                    return Result<bool>.Failure(loanPaymentsForPreview.ErrorMessage);

                PaymentsFromPreview = loanPaymentsForPreview.Value;
                SubPeriodID = loansPaymentsPreviewGenerator.SubPeriodID;
                companyDomain = _moneySaverRepo.GetDefaultCompany();

                MapValidLoansDataToLoanDomain(loansPaymentsPreviewGenerator.LoansData);
                PayValidInstallments(date);

                var dbResult = _loansRepo.PayLoanInstallments(LoansDomain, companyDomain);

                if (dbResult == false)
                    return Result<bool>.Failure("Hubo un error al guardar en base de datos.");

                return Result<bool>.Created(true, CreatedMessage);
            }
            catch (Exception ex)
            {
                Helper.SendErrorToText(ex);
                return Result<bool>.Failure(ex.Message);
            }
        }

        private void MapValidLoansDataToLoanDomain(List<LoansDataModel> loansData)
        {
            var validLoansIDs = PaymentsFromPreview
                .Where(p => p.IsValid)
                .Select(p => p.LoanID)
                .ToList();

            if (validLoansIDs.Count == 0)
                throw new ServiceValidationException("Ningún registro a procesar es valido.");

            var validLoansData = loansData
                .Where(l => validLoansIDs.Contains(l.LoanID))
                .ToList();

            LoansDomain = _mapper.Map<List<LoanDomain>>(validLoansData);
        }

        private void PayValidInstallments(DateTime paymentDate)
        {
            LoansDomain.ForEach(ld =>
            {
                var paymentData = PaymentsFromPreview.FirstOrDefault(p => p.LoanID == ld.LoanID);

                if (paymentData != null)
                {
                    ld.Company = companyDomain; 
                    ld.PayInstallment(paymentData.LoanInstallmentID, SubPeriodID, paymentDate);
                }
            });
        }
    }
}
