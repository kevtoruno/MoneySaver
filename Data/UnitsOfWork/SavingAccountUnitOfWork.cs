using AutoMapper;
using Data.Persistence;
using Domain;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Service.Core.DataModel;
using Service.Core.Interfaces.UnitsOfWork;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Core;
using Service.Core.Mapping;

namespace Data.UnitsOfWork
{
    internal class SavingAccountUnitOfWork : ISavingAccountUnitOfWork
    {
        private readonly MoneySaverContext _context;
        private readonly IMapper _mapper;

        private SavingAccountsDataModel SavingAccountsDataModelForUpdate = new SavingAccountsDataModel();
        private SavingAccountMapping savingAccountMapper;
        public SavingAccountUnitOfWork(MoneySaverContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            savingAccountMapper = new SavingAccountMapping(mapper);
        }

        public SavingAccountDomainAggregate GetSavingAccountDomain(int savingAccountID, bool includeTransactionalHistory = false)
        {
            var query = _context.SavingAccounts
                .Include(sa => sa.Client)
                .AsQueryable();

            if (includeTransactionalHistory)
                query = query.Include(q => q.Deposits).Include(q => q.Withdrawals);

            SavingAccountsDataModelForUpdate = query
                .First(a => a.SavingAccountID == savingAccountID);

            var savingAccountDomain = new SavingAccountDomainAggregate();

            _mapper.Map(SavingAccountsDataModelForUpdate, savingAccountDomain);
            savingAccountDomain.Company = GetDefaultCompany();

            return savingAccountDomain;
        }

        public bool UpdateSavingAccount(SavingAccountDomainAggregate saDomain)
        {
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
            //DisplayStates(_context.ChangeTracker.Entries());
            //_mapper.Map(saDomain, SavingAccountsDataModelForUpdate);

            savingAccountMapper.MapDomainToDataModel(saDomain, SavingAccountsDataModelForUpdate);

            _context.SavingAccounts.Update(SavingAccountsDataModelForUpdate);
            //DisplayStates(_context.ChangeTracker.Entries());
        }

        private static void DisplayStates(IEnumerable<EntityEntry> entries)
        {
            foreach (var entry in entries)
            {
                Debug.WriteLine($"Entity: {entry.Entity.GetType().Name}, " +
                    $"State: {entry.State.ToString()} ");
            }
        }

        private CompanyDomain GetDefaultCompany()
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
    }
}
