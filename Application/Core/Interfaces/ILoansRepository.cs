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
    }
}
