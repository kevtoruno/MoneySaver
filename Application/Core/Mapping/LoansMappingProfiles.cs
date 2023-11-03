using AutoMapper;
using Domain.Entities.Loans;
using Service.Core.DataModel;
using Service.Core.Dtos.LoansDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Mapping
{
    internal class LoansMappingProfiles : Profile
    {
        public LoansMappingProfiles()
        {
            CreateMap<LoanDomain, LoansDataModel>();
            CreateMap<LoansDataModel, LoanDomain>();

            CreateMap<LoanPaymentHistoryDataModel, LoanPaymentHistoryDomain>();
            CreateMap<LoanPaymentHistoryDomain, LoanPaymentHistoryDataModel>();

            CreateMap<LoanInstallmentsDomain, LoanInstallmentsDataModel>();
            CreateMap<LoanInstallmentsDataModel, LoanInstallmentsDomain>();

            CreateMap<LoanInterestsDataModel, LoanInterestsDomain>();

            CreateMap<LoanDomainCreator, LoanPreviewDto>()
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
                opt => opt.MapFrom(src => src.PaperCost.CordobaFormat()));

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

            CreateMap<LoanInstallmentsDataModel, LoanTransactionsDto>()
                .ForMember(dest => dest.Amount,
                opt => opt.MapFrom(src => src.Amount.CordobaFormat()))
                .ForMember(dest => dest.DueAmountDisplay,
                opt => opt.MapFrom(src => src.DueAmount.CordobaFormat()));
        }
    }
}
