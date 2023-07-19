using AutoMapper;
using Service.Core.DataModel;
using Service.Core.Dtos;
using Service.Core.Dtos.LoansDto;
using Service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Features.Loans
{
    public class LoansList
    {
        private readonly ILoansRepository _loansRepo;
        private readonly IMapper _mapper;

        public LoansList(ILoansRepository loansRepo, IMapper mapper)
        {
            _loansRepo = loansRepo;
            _mapper = mapper;
        }

        public List<LoansToListDto> GetLoansList(string INSS) 
        {
            var loansToListDto = _loansRepo.GetLoansList(INSS);

            return loansToListDto;
        }

        public LoanToDetailDto GetLoanDetail(int loanID)
        {
            var loanData = _loansRepo.GetLoanDetail(loanID);

            var loanDetailDto = _mapper.Map<LoanToDetailDto>(loanData);
            loanDetailDto.ClientFullName = loanData.Client.GetClientFullName();

            var installmentsData = _loansRepo.GetLoanInstallments(loanID);

            MapInstallmentsDataToDto(installmentsData, loanDetailDto);

            return loanDetailDto;
        }

        private void MapInstallmentsDataToDto(List<LoanInstallmentsDataModel> installmentsData,
            LoanToDetailDto loanToDetailDto)
        {
            installmentsData.ForEach(ins =>
            {
                var subPeriodName = "";

                if (ins.SubPeriod != null) 
                {
                    var date = new DateTime(ins.SubPeriod.Period.Year, ins.SubPeriod.Month, 1);

                    subPeriodName = $"{date.ToString("MMMM")} {ins.SubPeriod.Period.Year}";
                }

                var installmentDto = _mapper.Map<LoanInstallmentsDto>(ins);

                installmentDto.SubPeriodName = subPeriodName;

                loanToDetailDto.Installments.Add(installmentDto);
            });
        }
    }
}
