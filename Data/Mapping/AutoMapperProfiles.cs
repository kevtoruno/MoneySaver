using Service.Core.Dtos;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Core.DataModel;

namespace Data.Mapping
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<ClientToCreateDto, ClientsDataModel>();  
            CreateMap<PeriodToCreateDto, PeriodsDataModel>();
            CreateMap<SubPeriodsToCreateDto, SubPeriodsDataModel>();
            CreateMap<SavingAccountToCreate, SavingAccountsDataModel>();
        }
    }
}
