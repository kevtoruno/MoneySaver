using AutoMapper;
using Data.Persistence;
using Domain.Entities.Loans;
using Microsoft.EntityFrameworkCore;
using Service.Core;
using Service.Core.DataModel;
using Service.Core.Dtos.LoansDto;
using Service.Core.Interfaces;
using System.Reflection;

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

        public bool SaveLoan(LoanDomainCreator loanDomain)
        {
            _context.ChangeTracker.Clear();
            using var tran = _context.Database.BeginTransaction();

            try
            {
                var defaultCompany = _mapper.Map<CompaniesDataModel>(loanDomain.Company);
                var LoanToCreate = _mapper.Map<LoansDataModel>(loanDomain);

                _context.Loans.Add(LoanToCreate);
                _context.SaveChanges();

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
                string fullName = l.Client.LastNames + " " + l.Client.FirstName;

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
                .Include(l => l.LoanInstallments)
                .ThenInclude(l => l.SubPeriod)
                .Include(l => l.LoanPaymentHistories)
                .ThenInclude(l => l.SubPeriod)
                .First(l => l.LoanID == loanID);
        }

        public List<LoanInstallmentsDataModel> GetLoanInstallments(int loanID)
        {
            return _context.LoanInstallments
                .Include(a => a.SubPeriod.Period)
                .Where(l => l.LoanID == loanID)
                .ToList();
        }

        public LoanDomain GetLoanDomain(int loanID)
        {
            var loansData = _context.Loans
                .AsNoTracking()
                .Include(a => a.LoanInstallments)
                .Include(a => a.LoanPaymentHistories)
                .FirstOrDefault(l => l.LoanID == loanID) ?? throw new Exception("No se encontró un préstamo asociado.");

            var loanDomain = _mapper.Map<LoanDomain>(loansData);

            return loanDomain;
        }

        public bool UpdateLoan(LoanDomain loanDomain)
        {
            _context.ChangeTracker.Clear();
            using var tran = _context.Database.BeginTransaction();
            try
            {
                var loanToUpdate = _mapper.Map<LoansDataModel>(loanDomain);
                var companyToUpdate = _mapper.Map<CompaniesDataModel>(loanDomain.Company);

                _context.Companies.Update(companyToUpdate);
                _context.Loans.Update(loanToUpdate);
                _context.SaveChanges();

                tran.Commit();

                return true;
            }
            catch (Exception)
            {
                tran.Rollback();
                throw new Exception("Error al actualizar préstamo");
            }
        }
    }
}
