using Service.Core.Dtos;
using Service.Core.Interfaces;
using Service.Core.DataModel;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using Azure.Core;
using Data.Persistence;
using Service.Core.Dtos.PeriodsDto;
using Domain.Entities;

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

        public bool DoINSSExists(string INSS)
        {
            return _context.Clients.Any(a => a.INSS == INSS);
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

        public bool DoIdentificationExists(string identification)
        {
            return _context.Clients.Any(a => a.Identification == identification);
        }

        public List<ClientToListDto> GetClientsList(string INSS)
        {
            var query = _context.Clients
                .Select(c =>
                new ClientToListDto
                {
                    FullName = $"{c.LastNames} {c.FirstName} {c.SecondName}",
                    Age = c.Age,
                    Identification = c.Identification,
                    INSS = c.INSS,
                    ClientID = c.ClientID
                });

            if (INSS.Length > 0)
                query = query.Where(a => a.INSS == INSS);

            return query.ToList();
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

        public void CreateSavingAccount(SavingAccountToCreate savingAccountToCreateDto)
        {
            var savingAccountToCreate = _mapper.Map<SavingAccountsDataModel>(savingAccountToCreateDto);

            _context.SavingAccounts.Add(savingAccountToCreate);
            _context.SaveChanges();
        }

        public List<SavingAccountToListDto> GetSavingAccountsList(string INSS) 
        {
            var query = _context.SavingAccounts.AsNoTracking()
                .Include(sa => sa.Client).OrderBy(sa => sa.IsActive).AsQueryable();

            if (INSS.Length > 0)
                query = query.Where(q => q.Client.INSS == INSS);

            var savingAccountsFromDB = query.ToList();

            var savingAccounts = new List<SavingAccountToListDto>();

            savingAccountsFromDB.ForEach(sa =>
            {
                string secondName = sa.Client.SecondName != "" ? " " + sa.Client.SecondName : "";

                string fullName = sa.Client.LastNames + " " + sa.Client.FirstName + secondName ;

                savingAccounts.Add(new SavingAccountToListDto
                {
                    Amount = String.Format("{0:#,##0.00}", sa.Amount),
                    INSS = sa.Client.INSS,
                    AmountForInterests = String.Format("{0:#,##0.00}", sa.AmountForInterests),
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
            var savingAccountData =  _context.SavingAccounts
                .AsNoTracking()
                .Include(sa => sa.Client)
                .First(a => a.SavingAccountID == savingAccountID);

            var savingAccountDomain = _mapper.Map<SavingAccountDomainAggregate>(savingAccountData);

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
   
                var savingAccountsDepositsDataToCreate = _mapper.Map<List<SavingAccountDepositsDataModel>>(saDomain.Deposits);

                _context.SavingAccountDeposits.AddRange(savingAccountsDepositsDataToCreate);

                defaultCompany.CurrentAmount += savingAccountsDepositsDataToCreate
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

        public bool WithdrawInterestsSavingAccount(SavingAccountDomainAggregate saDomain)
        {
            _context.ChangeTracker.Clear();
            using var tran = _context.Database.BeginTransaction();

            try
            {
                var defaultCompany = _context.Companies.FirstOrDefault() ?? throw new Exception();
                var savingAccountToUpdate = _mapper.Map<SavingAccountsDataModel>(saDomain);

                _context.SavingAccounts.Update(savingAccountToUpdate);
   
                var savingAccountsWithdrawsDataToCreate = _mapper.Map<List<SavingAccountWidthdrawalsDataModel>>(saDomain.Withdraws);

                _context.SavingAccountWidthdrawals.AddRange(savingAccountsWithdrawsDataToCreate);

                defaultCompany.CurrentAmount -= savingAccountsWithdrawsDataToCreate
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
                .Where(sp => sp.EndDate.Date >= startDate.Date && sp.EndDate.Date <= endDate.Date)
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

        public LoanInterestsDataModel GetDefaultLoanInterest()
        {
            return _context.LoanInterests.First(a => a.IsDefault);
        }
    }
}
