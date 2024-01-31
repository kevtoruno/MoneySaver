using AutoMapper;
using Data.Persistence;
using Domain;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Service.Core.DataModel;
using Service.Core.Interfaces.UnitsOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.UnitsOfWork
{
    internal class SavingAccountUnitOfWork : ISavingAccountUnitOfWork
    {
        private readonly MoneySaverContext _context;
        private readonly IMapper _mapper;

        private SavingAccountsDataModel SavingAccountsDataModelForUpdate = new SavingAccountsDataModel();

        public SavingAccountUnitOfWork(MoneySaverContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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
            _mapper.Map(saDomain, SavingAccountsDataModelForUpdate);

            _context.SavingAccounts.Update(SavingAccountsDataModelForUpdate);
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
