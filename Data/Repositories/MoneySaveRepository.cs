using Service.Core.Dtos;
using Service.Core.Interfaces;
using AutoMapper;
using Data.DataModel;
using Data.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using Azure.Core;

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
            var clientToCreate = _mapper.Map<ClientsDataModel>(clientToCreateDto);

            _context.Add(clientToCreate);
            _context.SaveChanges();
        }

        public bool DoIdentificationExists(string identification)
        {
            return _context.Clients.Any(a => a.Identification == identification);
        }

        public List<ClientToListDto> GetClientsList(string firstName, string LastName)
        {
            return _context.Clients
                .Where(c => EF.Functions.Like(c.FirstName, "%"+firstName +"%") && EF.Functions.Like(c.LastNames, "%"+LastName +"%"))
                .Select(c => 
                new ClientToListDto 
                {
                    FullName = $"{c.LastNames} {c.FirstName} {c.SecondName}",
                    Age = c.Age,
                    Identification = c.Identification,
                    INSS = c.INSS,
                    ClientID = c.ClientID
                })
                .ToList();
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

        public List<SavingAccountToListDto> GetSavingAccountsList() 
        {
            var savingAccountsFromDB = _context.SavingAccounts.Include(sa => sa.Client).ToList();

            var savingAccounts = new List<SavingAccountToListDto>();

            savingAccountsFromDB.ForEach(sa =>
            {
                string secondName = sa.Client.SecondName != "" ? " " + sa.Client.SecondName : "";

                string fullName = sa.Client.LastNames + " " + sa.Client.FirstName + secondName ;

                savingAccounts.Add(new SavingAccountToListDto
                {
                    Amount = String.Format("{0:#,##0.00}", sa.Amount),
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
    }
}
