using Domain;
using Domain.Entities.Loans;
using Service.Core.DataModel;
using Service.Core.Dtos.LoansDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Interfaces
{
    public interface ILoansRepository
    {
        LoanInterestsDataModel GetDefaultLoanInterest();
        bool CheckIfClientHasAnotherLoan(int clientID);
        bool SaveLoan(LoanDomainCreator loanDomain);
        List<LoansToListDto> GetLoansList(string INSSNo);
        LoansDataModel GetLoanDetail(int loanID);
        List<LoanInstallmentsDataModel> GetLoanInstallments(int loanID);
        LoanDomain GetLoanDomain(int loanID);
        bool UpdateLoan(LoanDomain loanDomain);
        bool CheckIfLoanCKAlreadyExists(string CK);
        List<LoansDataModel> GetLoansWithInstallments();
        bool PayLoanInstallments(List<LoanDomain> loansDomain, CompanyDomain defaultCompanyDomain);
        decimal GetTotalAmountLoanedForLastSixMonths(SubPeriodsDataModel subPeriod, int utilityMonths = 6);
        decimal GetTotalAmountRecoveredForLastSixMonths(SubPeriodsDataModel subPeriod, int utilityMonths = 6);
        List<LoansDataModel> GetLoansByDates(DateTime periodStartDate, DateTime periodEndDate);
        bool SaveLoan(List<LoanDomainCreator> loanDomain);
    }
}
