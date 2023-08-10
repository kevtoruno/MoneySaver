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
using System.Xml;

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
                    FullName = $"{c.LastNames} {c.FirstName} {c.SecondName}",
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
                string secondName = client.SecondName != "" ? " " + client.SecondName : "";

                fullName = client.LastNames + " " + client.FirstName + secondName ;
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

        public bool CheckIfClientHasActiveSavingAccount(int clientID) 
        {
            bool hasSavingAccount = _context.SavingAccounts.Any(sa => sa.ClientID == clientID && sa.IsActive);

            return hasSavingAccount;
        }

        public int CreateSavingAccount(SavingAccountDomainCreator savingAccountDomain)
        {
            var savingAccountToCreate = _mapper.Map<SavingAccountsDataModel>(savingAccountDomain);

            _context.SavingAccounts.Add(savingAccountToCreate);
            _context.SaveChanges();

            return savingAccountToCreate.SavingAccountID;
        }

        public List<SavingAccountToListDto> GetSavingAccountsList(string INSS) 
        {
            var query = _context.SavingAccounts.AsNoTracking()
                .Include(sa => sa.Client).OrderBy(sa => sa.Client.INSS).AsQueryable();

            if (INSS.Length > 0)
            {
                INSS = "%" + INSS + "%";
                query = query.Where(q => EF.Functions.Like(q.Client.INSS, INSS));
            }   

            var savingAccountsFromDB = query.ToList();

            var savingAccounts = new List<SavingAccountToListDto>();

            savingAccountsFromDB.ForEach(sa =>
            {
                string secondName = sa.Client.SecondName != "" ? " " + sa.Client.SecondName : "";

                string fullName = sa.Client.LastNames + " " + sa.Client.FirstName + secondName ;

                savingAccounts.Add(new SavingAccountToListDto
                {
                    Amount = sa.Amount.CordobaFormat(),
                    INSS = sa.Client.INSS,
                    AmountForInterests = sa.AmountForInterests.CordobaFormat(),
                    IsActive = sa.IsActive,
                    SavingAccountID = sa.SavingAccountID,
                    ClientID = sa.ClientID,
                    CreatedDate = sa.CreatedDate.ToShortDateString(),
                    ClientFullName = fullName
                });
            });

            return savingAccounts;
        }

        public SavingAccountsDataModel GetSavingAccountDetail(int savingAccountID)
        {
            return _context.SavingAccounts
                .AsNoTracking()
                .Include(sa => sa.Client)
                .First(a => a.SavingAccountID == savingAccountID);
        }

        public SavingAccountDomainAggregate GetSavingAccountDomain(int savingAccountID)
        {
            var savingAccountData = _context.SavingAccounts
                .AsNoTracking()
                .Include(sa => sa.Client)
                .First(a => a.SavingAccountID == savingAccountID);

            var savingAccountDomain = _mapper.Map<SavingAccountDomainAggregate>(savingAccountData);

            return savingAccountDomain;
        }

        public List<SavingAccountsDataModel> GetSavingAccountsWithDepositsForPeriodData(int periodID)
        {
            var savingAccountData = _context.SavingAccounts
                .AsNoTracking()
                .Include(sa => sa.Client)
                .Include(sa => sa.Deposits.Where(dep => dep.SubPeriod.PeriodID == periodID))
                .Where(sa => sa.IsActive == true)
                .ToList();

            return savingAccountData;
        }

        public List<SavingAccountDomainAggregate> GetSavingAccountDomainsWithDepositsForPeriod(List<int> savingAccountIDs, int periodID)
        {
            var savingAccountData = _context.SavingAccounts
                .AsNoTracking()
                .Include(sa => sa.Client)
                .Include(sa => sa.Deposits.Where(dep => dep.SubPeriod.PeriodID == periodID))
                .Where(sa => savingAccountIDs.Contains(sa.SavingAccountID))
                .ToList();

            var savingAccountDomain = _mapper.Map<List<SavingAccountDomainAggregate>>(savingAccountData);

            return savingAccountDomain;
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
                var savingAccountToUpdate = _mapper.Map<SavingAccountsDataModel>(saDomain);

                _context.SavingAccounts.Update(savingAccountToUpdate);

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
                var defaultCompany = _context.Companies.FirstOrDefault() ?? throw new Exception();
                var savingAccountToUpdate = _mapper.Map<SavingAccountsDataModel>(saDomain);

                _context.SavingAccounts.Update(savingAccountToUpdate);

                defaultCompany.CurrentAmount -= savingAccountToUpdate.Withdrawals
                    .Where(a => a.SavingAccountWithdrawalID == 0 && a.WithDrawalType == WithDrawalType.Interests)
                    .Sum(a => a.Amount);

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

        public List<SavingAccountDepositsDataModel> GetSavingAccountsDepositsBySubPeriodID(int subPeriodID)
        {
            return _context.SavingAccountDeposits
                .Include(sa => sa.SavingAccount.Client)
                .Where(sa => sa.SubPeriodID == subPeriodID)
                .ToList();
        }

        public bool AddDepositsToSavingAccounts(List<SavingAccountDomainAggregate> saDomainLst)
        {
            _context.ChangeTracker.Clear();
            using var tran = _context.Database.BeginTransaction();
            try
            {
                var defaultCompany = _context.Companies.FirstOrDefault() ?? throw new Exception();
                var savingAccountToUpdate = _mapper.Map<List<SavingAccountsDataModel>>(saDomainLst);

                decimal totalDepositAmount = savingAccountToUpdate
                    .SelectMany(sa => sa.Deposits.Where(dep => dep.SavingAccountDepositID == 0))
                    .Sum(a => a.Amount);

                _context.SavingAccounts.UpdateRange(savingAccountToUpdate);
                _context.SaveChanges();
     
                defaultCompany.CurrentAmount += totalDepositAmount;

                _context.Companies.Update(defaultCompany);
                _context.SaveChanges();

                tran.Commit();
                //tran.Commit();
            }
            catch (Exception) 
            {
                tran.Rollback();
                return false;
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
                .FirstOrDefault(sp => date.Date >= sp.StartDate.Date  && date.Date <= sp.EndDate.Date.Date);

            return subPeriod;
        }

        public DateTime GetLatestWithdrawDateForSavingAccountID(int savingAccountID)
        {
            var date = new DateTime(1800, 1, 1);

            var withdrawal = _context.SavingAccountWidthdrawals
                .Where(saw => saw.SavingAccountID == savingAccountID && saw.WithDrawalType == WithDrawalType.Interests)
                .OrderByDescending(w => w.CreatedDate)
                .FirstOrDefault();

            if (withdrawal != null)
                date = withdrawal.CreatedDate;

            return date;
        }
    }
}
