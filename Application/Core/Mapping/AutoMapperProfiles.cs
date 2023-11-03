using Service.Core.Dtos;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Core.DataModel;
using Domain.Entities;
using Domain.Entities.Loans;
using Service.Core.Dtos.LoansDto;
using Service.Core;
using Domain.Entities.SavingAccount;
using Domain;

namespace Service.Mapping
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<ClientToCreateDto, ClientsDataModel>();  
            CreateMap<ClientsDataModel, ClientToCreateDto>();  
            CreateMap<PeriodToCreateDto, PeriodsDataModel>();
            CreateMap<SubPeriodsToCreateDto, SubPeriodsDataModel>();
            CreateMap<SavingAccountToCreateDto, SavingAccountsDataModel>();
            CreateMap<SavingAccountDomainAggregate,  SavingAccountsDataModel>();
            CreateMap<SavingAccountDomainCreator,  SavingAccountsDataModel>();
            CreateMap<SavingAccountDepositDomain,  SavingAccountDepositsDataModel>();
            CreateMap<SavingAccountDepositsDataModel, SavingAccountDepositDomain>();
            CreateMap<SavingAccountWithdrawsDomain, SavingAccountWidthdrawalsDataModel>();
            CreateMap<SavingAccountWidthdrawalsDataModel, SavingAccountWithdrawsDomain>();
            CreateMap<SavingAccountsDataModel, SavingAccountDomainAggregate>();
            CreateMap<CompaniesDataModel, CompanyDomain>();
            CreateMap<CompanyDomain, CompaniesDataModel>();     

            CreateMap<SubPeriodsDataModel, SubPeriodDomain>();
            CreateMap<SubPeriodDomain, SubPeriodsDataModel>();
        }
    }
}
