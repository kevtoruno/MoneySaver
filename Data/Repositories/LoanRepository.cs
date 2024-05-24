using AutoMapper;
using Data.Persistence;
using Domain;
using Domain.Entities.Loans;
using iText.Commons.Actions.Contexts;
using Microsoft.EntityFrameworkCore;
using Service.Core;
using Service.Core.DataModel;
using Service.Core.DataModel.Loan;
using Service.Core.Dtos.LoansDto;
using Service.Core.Interfaces;
using Service.DatabaseDtos;
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

        public bool CheckIfLoanCKAlreadyExists(string CK)
        {
            return _context.Loans.Any(a => a.CKCode == CK);
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
            catch (DbUpdateException ex)
            {
                tran.Rollback();
                bool invalidCK = ex.InnerException != null ? ex.InnerException.Message.Contains("IX_Loans_CKCode") :false;

                if (invalidCK)
                    throw new Exception("Código CK duplicado");

                throw ex;
            }
            catch (Exception) 
            {
                tran.Rollback();
                throw new Exception("Error al crear el préstamo");
            }

            return true;
        }

        public List<LoansDataModel> GetActiveLoansList()
        {
            var activeLoans = _context.Loans.AsNoTracking()
                .Include(sa => sa.Client)
                .Where(l => l.IsCurrent)
                .ToList();

            return activeLoans;
        }

        public List<LoansToListDto> GetLoansList(string INSSNo)
        {
            var loansToListDto = new List<LoansToListDto>();
            var query = _context.Loans.AsNoTracking()
                .Include(sa => sa.Client).OrderBy(sa => sa.IsCurrent).AsQueryable();

            if (INSSNo.Length > 0)
            {
                INSSNo = "%" + INSSNo + "%";
                query = query.Where(q => EF.Functions.Like(q.Client.INSS, INSSNo));
            }

            var loansFromDB = query.OrderByDescending(l => l.IsCurrent).ToList();

            loansFromDB.ToList().ForEach(l =>
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
                    LoanID = l.LoanID,
                    CKCode = l.CKCode
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

        public LoansDataModel GetLoansData(int loanID)
        {
            var loansData = _context.Loans
                .Include(a => a.LoanInstallments)
                .ThenInclude(a => a.SubPeriod)
                .Include(a => a.LoanPaymentHistories)
                .Include(l => l.Restructures)
                .FirstOrDefault(l => l.LoanID == loanID) ?? throw new Exception("No se encontró un préstamo asociado.");

            return loansData;
        }

        public LoanDomain GetLoanDomain(int loanID)
        {
            var loansData = _context.Loans
                .AsNoTracking()
                .Include(a => a.LoanInstallments)
                .ThenInclude(a => a.SubPeriod)
                .Include(a => a.LoanPaymentHistories)
                .FirstOrDefault(l => l.LoanID == loanID) ?? throw new Exception("No se encontró un préstamo asociado.");

            var loanDomain = _mapper.Map<LoanDomain>(loansData);

            return loanDomain;
        }

        public bool UpdateLoanWithCompany(LoanDomain loanDomain)
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

        public bool UpdateLoanRestructure(LoansDataModel loanToUpdate, LoanRestructureHistoryDataModel LoanRestructureHistory)
        {
            //_context.ChangeTracker.Clear();
            using var tran = _context.Database.BeginTransaction();
            try
            {
                _context.Loans.Update(loanToUpdate);
                _context.LoanRestructureHistory.Update(LoanRestructureHistory);
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

        public List<LoansDataModel> GetLoansWithInstallments()
        {
            var pendingLoans = _context.Loans
                .AsNoTracking()
                .Include(l => l.Client)
                .Include(l => l.LoanInstallments)
                .Where(l => l.IsCurrent == true)
                .ToList();

            return pendingLoans;
        }

        public bool PayLoanInstallments(List<LoanDomain> loansDomain, CompanyDomain defaultCompanyDomain)
        {
            _context.ChangeTracker.Clear();
            using var tran = _context.Database.BeginTransaction();
            try
            {
                var defaultCompany = _mapper.Map<CompaniesDataModel>(defaultCompanyDomain);
                var loansToUpdate = _mapper.Map<List<LoansDataModel>>(loansDomain);

                _context.Loans.UpdateRange(loansToUpdate);
                _context.SaveChanges();

                _context.Companies.Update(defaultCompany);
                _context.SaveChanges();

                tran.Commit();
            }
            catch (Exception)
            {
                tran.Rollback();
                return false;
            }

            return true;
        }

        public LoanAmountValuesForPeriodOfTime GetTotalLoansAmountsForPeriodOfTime(SubPeriodsDataModel subPeriod, 
            int utilityMonths = 6)
        {
            var startDate = subPeriod.StartDate.AddMonths(-5).Date;
            DateTime endDate = utilityMonths == 6 ? subPeriod.EndDate : subPeriod.EndDate.AddMonths(-1);

            var loans = _context.Loans
                .Where(l => l.CreatedDate.Date >= startDate && l.CreatedDate.Date <= endDate)
                .ToList();

            var loanAmountValues = new LoanAmountValuesForPeriodOfTime
            {
                TotalLoansAmount = loans.Sum(a => a.LoanAmount),
                TotalLoansExpensesAmount = loans.Sum(a => a.BaseAmount)
            };

            return loanAmountValues;
        }

        public decimal GetTotalAmountLoanedForLastSixMonths(SubPeriodsDataModel subPeriod, int utilityMonths = 6)
        {
            var startDate = subPeriod.StartDate.AddMonths(-5).Date;
            DateTime endDate = utilityMonths == 6 ? subPeriod.EndDate : subPeriod.EndDate.AddMonths(-1);

            var totalAmountLoaned = _context.Loans
                .Where(l => l.CreatedDate.Date >= startDate && l.CreatedDate.Date <= endDate)
                .Sum(l => l.LoanAmount);

            return totalAmountLoaned;
        }

        public decimal GetTotalAmountRecoveredForLastSixMonths(SubPeriodsDataModel subPeriod, int utilityMonths = 6)
        {
            var startDate = subPeriod.StartDate.AddMonths(-5).Date;
            DateTime endDate = utilityMonths == 6 ? subPeriod.EndDate : subPeriod.EndDate.AddMonths(-1);

            var totalAmountRecovered = _context.LoanPaymentHistory
                .Where(l => l.Date >= startDate && l.Date <= endDate)
                .Sum(l => l.Amount);

            return totalAmountRecovered;
        }

        public List<LoansDataModel> GetLoansByDates(DateTime periodStartDate, DateTime periodEndDate)
        {
            return _context.Loans
                .Where(l => l.StartDate >= periodStartDate && l.StartDate <= periodEndDate)
                .ToList();
        }

        public bool SaveLoan(List<LoanDomainCreator> loanDomain)
        {
            _context.ChangeTracker.Clear();
            using var tran = _context.Database.BeginTransaction();
            try
            {
                var defaultCompany = _mapper.Map<CompaniesDataModel>(loanDomain.FirstOrDefault().Company);
                var LoansToCreate = _mapper.Map<List<LoansDataModel>>(loanDomain);

                _context.Loans.AddRange(LoansToCreate);
                _context.SaveChanges();

                _context.Companies.Update(defaultCompany);
                _context.SaveChanges();

                tran.Commit();
            }
            catch (DbUpdateException ex)
            {
                tran.Rollback();
                bool invalidCK = ex.InnerException != null ? ex.InnerException.Message.Contains("IX_Loans_CKCode") :false;

                if (invalidCK)
                    throw new Exception("Código CK duplicado");

                throw ex;
            }
            catch (Exception) 
            {
                tran.Rollback();
                throw new Exception("Error al crear el préstamo");
            }

            return true;
        }

        public bool DeleteLoan(int loanID)
        {
            using var tran = _context.Database.BeginTransaction();
            try
            {
                var loanToDelete = _context.Loans
                    .Include(l => l.LoanInstallments)
                    .Include(l => l.LoanPaymentHistories)
                    .FirstOrDefault(l => l.LoanID == loanID) ?? throw new NullReferenceException("No se encontró préstamo");

                if (loanToDelete.LoanPaymentHistories.Count() > 0)
                    throw new Exception("No se puede eliminar préstamo con pagos realizados.");
       
                var companyData = _context.Companies.First();
                var company = _mapper.Map<CompanyDomain>(companyData);
                
                company.AddCurrentAmount(loanToDelete.Amount);
                company.DecreaseFloatingAmount(loanToDelete.Amount);

                _context.Remove(loanToDelete);

                var result = _context.SaveChanges();

                tran.Commit();

                return result > 0;
            }
            catch (Exception ex) 
            {
                tran.Rollback();
                throw new Exception(ex.Message);
            }
        }
    }
}
