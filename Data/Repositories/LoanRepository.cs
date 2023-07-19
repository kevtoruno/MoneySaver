using AutoMapper;
using Data.Persistence;
using Domain.Entities.Loans;
using Microsoft.EntityFrameworkCore;
using Service.Core;
using Service.Core.DataModel;
using Service.Core.Dtos.LoansDto;
using Service.Core.Interfaces;

namespace Data.Repositories
{
    public class LoanRepository : ILoansRepository
    {
        private readonly MoneySaverContext _context;
        private readonly IMapper _mapper;

        public LoanRepository(MoneySaverContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public bool CheckIfClientHasAnotherLoan(int clientID)
        {
            return _context.Loans.Any(a => a.ClientID == clientID && a.IsCurrent == true 
            && a.DueAmount > 0);
        }

        public LoanInterestsDataModel GetDefaultLoanInterest()
        {
            return _context.LoanInterests.First(a => a.IsDefault);
        }

        public bool SaveLoan(LoanDomain loanDomain)
        {
            _context.ChangeTracker.Clear();
            using var tran = _context.Database.BeginTransaction();

            try
            {
                var defaultCompany = _mapper.Map<CompaniesDataModel>(loanDomain.Company);
                var LoanToCreate = _mapper.Map<LoansDataModel>(loanDomain);

                _context.Loans.Add(LoanToCreate);
                _context.SaveChanges();

                var loansInstallmentsToCreate = _mapper.Map<List<LoanInstallmentsDataModel>>(loanDomain.LoanInstallments);

                loansInstallmentsToCreate.ForEach(li => li.LoanID = LoanToCreate.LoanID);

                _context.LoanInstallments.AddRange(loansInstallmentsToCreate);

                _context.Companies.Update(defaultCompany);
                _context.SaveChanges();

                tran.Commit();
            }
            catch (Exception) 
            {
                tran.Rollback();
                throw;
            }

            return true;
        }

        public List<LoansToListDto> GetLoansList(string INSSNo)
        {
            var loansToListDto = new List<LoansToListDto>();
            var query = _context.Loans.AsNoTracking()
                .Include(sa => sa.Client).OrderBy(sa => sa.IsCurrent).AsQueryable();

            if (INSSNo.Length > 0)
                query = query.Where(q => q.Client.INSS == INSSNo);

            var loansFromDB = query.ToList();

            loansFromDB.ForEach(l =>
            {
                string secondName = l.Client.SecondName != "" ? " " + l.Client.SecondName : "";

                string fullName = l.Client.LastNames + " " + l.Client.FirstName + secondName;

                loansToListDto.Add(new LoansToListDto
                {
                    DueAmount = l.DueAmount.CordobaFormat(),
                    LoanAmount = l.LoanAmount.CordobaFormat(),
                    ClientFullName = fullName,
                    Description = l.Description,
                    EndDate = l.EndDate,
                    INSSNo = l.Client.INSS,
                    IsCurrent = l.IsCurrent,
                    LoanID = l.LoanID
                });
            });

            return loansToListDto;
        }

        public LoansDataModel GetLoanDetail(int loanID)
        {
            return _context.Loans
                .Include(l => l.Client)
                .First(l => l.LoanID == loanID);
        }

        public List<LoanInstallmentsDataModel> GetLoanInstallments(int loanID)
        {
            return _context.LoanInstallments
                .Include(a => a.SubPeriod.Period)
                .Where(l => l.LoanID == loanID)
                .ToList();
        }
    }
}
