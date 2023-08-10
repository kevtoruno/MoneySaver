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
            CreateMap<LoanDomain, LoansDataModel>();
            CreateMap<LoanInstallmentsDomain, LoanInstallmentsDataModel>();
            CreateMap<CompaniesDataModel, CompanyDomain>();
            CreateMap<CompanyDomain, CompaniesDataModel>();

            CreateMap<LoanInterestsDataModel, LoanInterestsDomain>();

            CreateMap<LoanDomain, LoanPreviewDto>()
                .ForMember(dest => dest.StartDate,
                opt => opt.MapFrom(src => src.StartDate.ToShortDateString()))
                .ForMember(dest => dest.EndDate,
                opt => opt.MapFrom(src => src.EndDate.ToShortDateString()))
                .ForMember(dest => dest.Interests,
                opt => opt.MapFrom(src => src.Interests.CordobaFormat()))
                .ForMember(dest => dest.Amount,
                opt => opt.MapFrom(src => src.Amount.CordobaFormat()))
                .ForMember(dest => dest.TermAmount,
                opt => opt.MapFrom(src => src.TermAmount.CordobaFormat()))
                .ForMember(dest => dest.PaperCostAmount,
                opt => opt.MapFrom(src => src.PaperCostAmount.CordobaFormat()));

            CreateMap<LoanInstallmentsDomain, LoanInstallmentsPreviewDto>()
                .ForMember(dest => dest.DueDate,
                opt => opt.MapFrom(src => src.DueDate.ToShortDateString()))
                .ForMember(dest => dest.Amount,
                opt => opt.MapFrom(src => src.Amount.CordobaFormat()));

            CreateMap<LoansDataModel, LoanToDetailDto>()
                .ForMember(dest => dest.DueAmount,
                opt => opt.MapFrom(src => src.DueAmount.CordobaFormat()))
                .ForMember(dest => dest.LoanAmount,
                opt => opt.MapFrom(src => src.LoanAmount.CordobaFormat()))
                .ForMember(dest => dest.Amount,
                opt => opt.MapFrom(src => src.Amount.CordobaFormat()))
                .ForMember(dest => dest.Interests,
                opt => opt.MapFrom(src => src.Interests.CordobaFormat()))
                .ForMember(dest => dest.TermAmount,
                opt => opt.MapFrom(src => src.TermAmount.CordobaFormat()))
                .ForMember(dest => dest.TotalTerms,
                opt => opt.MapFrom(src => src.TotalTerms + " " + (src.TotalTerms > 1 ? "meses" : "mes")))
                .ForMember(dest => dest.INSS,
                opt => opt.MapFrom(src => src.Client.INSS));

            CreateMap<LoanInstallmentsDataModel, LoanInstallmentsDto>()
                .ForMember(dest => dest.Amount,
                opt => opt.MapFrom(src => src.Amount.CordobaFormat()))
                .ForMember(dest => dest.DueAmountDisplay,
                opt => opt.MapFrom(src => src.DueAmount.CordobaFormat()));
        }
    }
}
