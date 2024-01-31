using Service.Core.Dtos;
using Service.Core.Interfaces;
using Service.Core.DataModel;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Data.Persistence;
using Service.Core.Dtos.PeriodsDto;
using Domain.Entities;
using Domain.Entities.SavingAccount;
using Service.Core;
using Domain;

namespace Data.Repositories
{
    public class MoneySaveRepository : IMoneySaverRepository
    {
        private readonly MoneySaverContext _context;
        private readonly IMapper _mapper;

        public MoneySaveRepository(MoneySaverContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public bool DoINSSExists(string INSS, int clientIDIgnore = 0)
        {
            return _context.Clients.Any(a => a.INSS == INSS && a.ClientID != clientIDIgnore);
        }

        public void CreateClient(ClientToCreateDto clientToCreateDto)
        {
            var defaultCompany = _context.Companies.FirstOrDefault();

            var clientToCreate = _mapper.Map<ClientsDataModel>(clientToCreateDto);

            if (defaultCompany != null)
                clientToCreate.CompanyID = defaultCompany.CompanyID;

            _context.Add(clientToCreate);
            _context.SaveChanges();
        }

        public bool DoIdentificationExists(string identification, int clientIDIgnore = 0)
        {
            return _context.Clients.Any(a => a.Identification == identification && a.ClientID != clientIDIgnore);
        }

        public List<ClientToListDto> GetClientsList(string INSS)
        {
            var query = _context.Clients
                .Select(c =>
                new ClientToListDto
                {
                    FullName = $"{c.LastNames} {c.FirstName}",
                    Identification = c.Identification,
                    INSS = c.INSS,
                    ClientID = c.ClientID
                });

            if (INSS.Length > 0)
                query = query.Where(a => a.INSS == INSS);

            return query.OrderBy(c => c.INSS).ToList();
        }

        public bool DoPeriodForTheYearExists(int year)
        {
            return _context.Periods.Any(a => a.Year == year);
        }

        public void CreatePeriod(PeriodToCreateDto periodToCreateDto)
        {
            using var tran = _context.Database.BeginTransaction();

            try
            {
                var periodToCreate = _mapper.Map<PeriodsDataModel>(periodToCreateDto);

                _context.Periods.Add(periodToCreate);
                _context.SaveChanges();

                periodToCreateDto.SubPeriods.ForEach(sp => sp.PeriodID = periodToCreate.PeriodID);
                var subPeriodToCreate = _mapper.Map<List<SubPeriodsDataModel>>(periodToCreateDto.SubPeriods);

                _context.SubPeriods.AddRange(subPeriodToCreate);
                _context.SaveChanges();

                tran.Commit();
            }
            catch (Exception)
            {
                tran.Rollback();
            }
        }

        public List<PeriodsToListDto> GetPeriodsList()
        {
            var periodsList = _context.Periods
                .Select(p => new PeriodsToListDto
                {
                    EndDate = p.EndDate,
                    StartDate = p.StartDate,
                    Year = p.Year,
                    PeriodID = p.PeriodID
                })
                .ToList();

            return periodsList;
        }

        public List<SubPeriodsToListDto> GetSubPeriodsList(int periodID)
        {
            var periodsList = _context.SubPeriods
                .Where(sb => sb.PeriodID == periodID)
                .Select(p => new SubPeriodsToListDto
                {
                    EndDate = p.EndDate,
                    StartDate = p.StartDate,
                    SubPeriodName = $"{p.Month}",
                    Month = p.Month,
                    PeriodID = p.PeriodID,
                    SubPeriodID = p.SubPeriodID
                })
                .ToList();

            return periodsList;
        }

        public string GetFullNameByINSS(string INSS)
        {
            string fullName = "";
            var client = _context.Clients.FirstOrDefault(a => a.INSS == INSS);

            if (client != null)
            {
                fullName = client.LastNames + " " + client.FirstName;
            }

            return fullName;
        }

        public int GetClientIDByINSSNo(string INSSNo)
        {
            int ClientID = 0;

            var client = _context.Clients.FirstOrDefault(a => a.INSS == INSSNo);

            if (client != null)
                ClientID = client.ClientID;

            return ClientID;
        }

        public int CheckIfClientHasSavingAccount(int clientID)
        {
            int hasSavingAccount = 0;

            var savingAccount = _context.SavingAccounts.AsNoTracking()
                .FirstOrDefault(sa => sa.ClientID == clientID);

            if (savingAccount != null)
            {
                if (savingAccount.IsActive)
                    hasSavingAccount = 1;
                else
                    hasSavingAccount = 2;
            }

            return hasSavingAccount;
        }

        public int CreateSavingAccount(SavingAccountDomainCreator savingAccountDomain)
        {
            var savingAccountToCreate = _mapper.Map<SavingAccountsDataModel>(savingAccountDomain);

            _context.SavingAccounts.Add(savingAccountToCreate);
            _context.SaveChanges();

            return savingAccountToCreate.SavingAccountID;
        }

        public List<SavingAccountsDataModel> GetSavingAccountsList(string INSS)
        {
            var query = _context.SavingAccounts.AsNoTracking()
                .Include(sa => sa.Client).OrderBy(sa => sa.Client.INSS).AsQueryable();

            if (INSS.Length > 0)
            {
                INSS = "%" + INSS + "%";
                query = query.Where(q => EF.Functions.Like(q.Client.INSS, INSS));
            }

            var savingAccountsData = query.ToList();

            return savingAccountsData;
        }

        public SavingAccountsDataModel GetSavingAccountDetail(int savingAccountID)
        {
            return _context.SavingAccounts
                .AsNoTracking()
                .Include(sa => sa.Client)
                .First(a => a.SavingAccountID == savingAccountID);
        }

        public SavingAccountDomainAggregate GetSavingAccountDomain(int savingAccountID, bool includeTransactionalHistory = false)
        {
            var query = _context.SavingAccounts
                .AsNoTracking()
                .Include(sa => sa.Client)
                .AsQueryable();

            if (includeTransactionalHistory)
                query = query.Include(q => q.Deposits).Include(q => q.Withdrawals);

            var savingAccountData = query.First(a => a.SavingAccountID == savingAccountID);

            var savingAccountDomain = _mapper.Map<SavingAccountDomainAggregate>(savingAccountData);
            savingAccountDomain.Company = GetDefaultCompany();

            return savingAccountDomain;
        }

        public List<SavingAccountsDataModel> GetSavingAccountsWithDepositsForPeriodData(int periodID)
        {
            var savingAccountData = _context.SavingAccounts
                .Include(sa => sa.Client)
                .Include(sa => sa.Deposits.Where(dep => dep.SubPeriod.PeriodID == periodID))
                .Where(sa => sa.IsActive == true)
                .ToList();

            return savingAccountData;
        }

        public bool CheckIfDepositExistsForSubPeriod(int subPeriodID, int savingAccountID)
        {
            return _context.SavingAccountDeposits
                .Any(sa => sa.SubPeriodID == subPeriodID && sa.SavingAccountID == savingAccountID);
        }

        public List<SavingAccountWidthdrawalsDataModel> GetSavingAccountWidthdrawals(int savingAccountID)
        {
            return _context.SavingAccountWidthdrawals
                .Include(sa => sa.SubPeriod.Period)
                .Where(sa => sa.SavingAccountID == savingAccountID)
                .ToList();
        }

        public List<SavingAccountDepositsDataModel> GetSavingAccountDeposits(int savingAccountID)
        {
            return _context.SavingAccountDeposits
                .Include(sa => sa.SubPeriod.Period)
                .Where(sa => sa.SavingAccountID == savingAccountID)
                .ToList();
        }

        public bool AddDepositToSavingAccount(SavingAccountDomainAggregate saDomain)
        {
            _context.ChangeTracker.Clear();
            using var tran = _context.Database.BeginTransaction();

            try
            {
                var defaultCompany = _context.Companies.FirstOrDefault() ?? throw new Exception();
                UpdateSavingAccountDomain(saDomain);

                defaultCompany.CurrentAmount += saDomain.Deposits
                    .Where(sa => sa.SavingAccountDepositID == 0)
                    .Sum(sa => sa.Amount);

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

        public bool WithdrawInterestsSavingAccount(SavingAccountDomainAggregate saDomain)
        {
            _context.ChangeTracker.Clear();
            using var tran = _context.Database.BeginTransaction();

            try
            {
                UpdateSavingAccountDomain(saDomain);

                var defaultCompany = _mapper.Map<CompaniesDataModel>(saDomain.Company);

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

        public bool CheckIfInterestWithdrawExistsForSubPeriod(int subPeriodID, int savingAccountID)
        {
            return _context.SavingAccountWidthdrawals.Any(saw => saw.SubPeriodID == subPeriodID &&
            saw.SavingAccountID == savingAccountID && saw.WithDrawalType == WithDrawalType.Interests);
        }

        public List<SubPeriodDomain> GetSubPeriodsForDateRange(DateTime startDate, DateTime endDate)
        {
            var subPeriodsForTheYears = _context.SubPeriods.Include(a => a.Period)
                .Where(sp => sp.EndDate.Date >= startDate.Date && sp.StartDate.Date <= endDate.Date)
                .Select(sp => new SubPeriodDomain
                {
                    EndDate = sp.EndDate,
                    Month = sp.Month,
                    StartDate = sp.StartDate,
                    SubPeriodID = sp.SubPeriodID,
                })
                .ToList();

            return subPeriodsForTheYears;
        }

        public CompanyDomain GetDefaultCompany()
        {
            try
            {
                var defaultCompany = _context.Companies.AsNoTracking()
                    .FirstOrDefault() ?? throw new NullReferenceException("No existe una empresa por defecto");

                return _mapper.Map<CompanyDomain>(defaultCompany);
            }
            catch (NullReferenceException)
            {
                throw;
            }
        }

        public ClientToCreateDto GetClient(int ClientID)
        {
            var clientData = _context.Clients.AsNoTracking().FirstOrDefault(c => c.ClientID == ClientID);

            var clienToEdit = _mapper.Map<ClientToCreateDto>(clientData);

            return clienToEdit;
        }

        public bool AddDepositsToSavingAccounts(List<SavingAccountDomainAggregate> saDomainLst,
            CompanyDomain company)
        {
            _context.ChangeTracker.Clear();
            using var tran = _context.Database.BeginTransaction();
            try
            {
                var savingAccountsToUpdate = _mapper.Map<List<SavingAccountsDataModel>>(saDomainLst);

                var x = _context.ChangeTracker.Entries();
                _context.SavingAccounts.UpdateRange(savingAccountsToUpdate);
                _context.SaveChanges();

                if (company != null)
                {
                    var defaultCompany = _mapper.Map<CompaniesDataModel>(company);

                    _context.Companies.Update(defaultCompany);
                    _context.SaveChanges();
                }

                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                throw;
            }

            return true;
        }

        public void EditClient(ClientToCreateDto clientToEditDto)
        {
            _context.ChangeTracker.Clear();
            var clientToEdit = _mapper.Map<ClientsDataModel>(clientToEditDto);

            _context.Update(clientToEdit);
            _context.SaveChanges();
        }

        public SubPeriodsDataModel GetSubPeriodIDFromDate(DateTime date)
        {
            var subPeriod = _context.SubPeriods
                .AsNoTracking()
                .Include(sp => sp.Period)
                .FirstOrDefault(sp => date.Date >= sp.StartDate.Date && date.Date <= sp.EndDate.Date.Date);

            return subPeriod;
        }

        public DateTime GetLatestWithdrawDateForSavingAccountID(int savingAccountID)
        {
            var date = new DateTime(1800, 1, 1);

            var withdrawal = _context.SavingAccountWidthdrawals
                .Where(saw => saw.SavingAccountID == savingAccountID)
                .OrderByDescending(w => w.CreatedDate)
                .FirstOrDefault();

            if (withdrawal != null)
                date = withdrawal.CreatedDate;

            return date;
        }

        public bool FullWithdrawalSavingAccount(SavingAccountDomainAggregate saDomain)
        {
            _context.ChangeTracker.Clear();
            using var tran = _context.Database.BeginTransaction();
            try
            {
                UpdateSavingAccountDomain(saDomain);

                var defaultCompany = _mapper.Map<CompaniesDataModel>(saDomain.Company);

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

        public bool UpdateSavingAccount(SavingAccountDomainAggregate saDomain)
        {
            _context.ChangeTracker.Clear();
            using var tran = _context.Database.BeginTransaction();
            try
            {
                UpdateSavingAccountDomain(saDomain);
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

        private void UpdateSavingAccountDomain(SavingAccountDomainAggregate saDomain)
        {
            var savingAccountToUpdate = _mapper.Map<SavingAccountsDataModel>(saDomain);

            _context.SavingAccounts.Update(savingAccountToUpdate);
        }

        public PeriodsDataModel GetPeriodWithSubPeriods(int periodID)
        {
            var period = _context.Periods
                .Include(p => p.SubPeriods)
                .FirstOrDefault(p => p.PeriodID == periodID) ?? throw new Exception("El periodo no existe");

            return period;
        }

        public Dictionary<int, decimal> GetSubPeriodsTotalIncome(List<int> subPeriodIds)
        {
            Dictionary<int, decimal> totalIncomeBySubPeriod = subPeriodIds
                .ToDictionary(sp => sp, spv => decimal.Zero);

            var groupedDepositsBySubPeriodIDs = _context.SavingAccountDeposits
                .Where(sad => subPeriodIds.Contains(sad.SubPeriodID) && sad.DepositType == DepositType.Saving)
                .Select(sad => new { sad.SubPeriodID, sad.Amount })
                .ToList();

            var groupedLoanPaymentsBySubPeriodId = _context.LoanPaymentHistory
                .Where(lph => subPeriodIds.Contains(lph.SubPeriodID != null ? lph.SubPeriodID.Value : 0))
                .Select(lph => new { SubPeriodID = lph.SubPeriodID != null ? lph.SubPeriodID.Value : 0, lph.Amount })
                .ToList();

            foreach (var totalDepositsIncomeBySubPeriodID in groupedDepositsBySubPeriodIDs.GroupBy(sad => sad.SubPeriodID))
            {
                totalIncomeBySubPeriod[totalDepositsIncomeBySubPeriodID.Key] += totalDepositsIncomeBySubPeriodID.Sum(gsp => gsp.Amount);
            }

            foreach (var totalLoanIncomeBySubPeriodID in groupedLoanPaymentsBySubPeriodId.GroupBy(sad => sad.SubPeriodID))
            {
                totalIncomeBySubPeriod[totalLoanIncomeBySubPeriodID.Key] += totalLoanIncomeBySubPeriodID.Sum(gsp => gsp.Amount);
            }

            return totalIncomeBySubPeriod;
        }

        public Dictionary<int, decimal> GetSubPeriodsWithdrawalsOutcome(List<int> subPeriodIds)
        {
            Dictionary<int, decimal> totalWithdrawalOutcomeBySubPeriod = subPeriodIds
                .ToDictionary(sp => sp, spv => decimal.Zero);

            var groupedWithdrawalsBySubPeriodIDs = _context.SavingAccountWidthdrawals
                .Where(saw => subPeriodIds.Contains(saw.SubPeriodID != null ? saw.SubPeriodID.Value : 0))
                .Select(saw => new { SubPeriodID = saw.SubPeriodID != null ? saw.SubPeriodID.Value : 0, saw.Amount })
                .ToList()
                .GroupBy(sad => sad.SubPeriodID);

            foreach (var totalWithdrawalOutcomeBySubPeriodID in groupedWithdrawalsBySubPeriodIDs)
            {
                totalWithdrawalOutcomeBySubPeriod[totalWithdrawalOutcomeBySubPeriodID.Key] += totalWithdrawalOutcomeBySubPeriodID.Sum(gsp => gsp.Amount);
            }

            return totalWithdrawalOutcomeBySubPeriod;
        }    

        public SubPeriodsDataModel GetSubPeriod(int subPeriodID)
        {
            var subPeriod = _context.SubPeriods
                .Include(sp => sp.Period)
                .FirstOrDefault(sp => sp.SubPeriodID == subPeriodID) ??
                throw new Exception("No existe subPeriodo asociado");

            return subPeriod;
        }

        public decimal GetTotalDepositAmountForTheLastSixMonths(SubPeriodsDataModel subPeriod)
        {
            var startDate = subPeriod.StartDate.AddMonths(-5).Date;

            var totalAmountLoaned = _context.SavingAccountDeposits
                .Include(sa => sa.SavingAccount)
                .Where(sad => sad.CreatedDate >= startDate && sad.CreatedDate <= subPeriod.EndDate 
                    && sad.SavingAccount.IsActive == true && sad.DepositType == DepositType.Saving)
                .Sum(l => l.Amount);

            return totalAmountLoaned;
        }

        public void UpdateSubPeriod(SubPeriodDomain subPeriodDomain)
        {
            try
            {
                var subPeriodData = _mapper.Map<SubPeriodsDataModel>(subPeriodDomain);

                _context.SubPeriods.Update(subPeriodData);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
