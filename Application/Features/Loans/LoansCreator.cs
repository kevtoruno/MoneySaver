using AutoMapper;
using Domain;
using Domain.Entities;
using Domain.Entities.Loans;
using Service.Core;
using Service.Core.DataModel;
using Service.Core.Dtos;
using Service.Core.Dtos.LoansDto;
using Service.Core.Interfaces;
using Service.Core.Validators;

namespace Service.Features.Loans
{
    public class LoansCreator
    {
        private readonly ILoansRepository _loansRepo;
        private readonly IMoneySaverRepository _moneySaverRepo;
        private readonly IMapper _mapper;
        private int ClientID = 0;
        private List<SubPeriodDomain> SubPeriodsForLoan = new List<SubPeriodDomain>();
        private LoanInterestsDataModel DefaultLoanInterest;
        private DateTime EndDate;
        private CompanyDomain DefaultCompany;
        public LoansCreator(ILoansRepository loansRepo, IMoneySaverRepository moneySaverRepo, IMapper mapper)
        {
            _loansRepo = loansRepo;
            _moneySaverRepo = moneySaverRepo;
            _mapper = mapper;
        }

        public Result<LoanPreviewDto> PreviewLoan(LoanToCreateDto loanToCreateDto)
        {
            try
            {
                var DBValidationsResult = SetDataFromDBAndValidate(loanToCreateDto);

                if (DBValidationsResult.IsSucess == false)
                    return Result<LoanPreviewDto>.Failure(DBValidationsResult.ErrorMessage);

                var defaultLoanInterestDomain = _mapper.Map<LoanInterestsDomain>(DefaultLoanInterest);

                var loanDomain = new LoanDomainCreator(ClientID, loanToCreateDto.Description, loanToCreateDto.TotalTerms,
                    loanToCreateDto.LoanAmount, defaultLoanInterestDomain, loanToCreateDto.StartDate, EndDate
                    ,loanToCreateDto.GuarantorFullName, loanToCreateDto.GuarantorWorkArea, loanToCreateDto.GuarantorINSSNo,
                    loanToCreateDto.GuarantorBaseIncome, loanToCreateDto.GuarantorAddress, loanToCreateDto.CKCode, DefaultCompany);

                loanDomain.CreateLoan(SubPeriodsForLoan);

                var loanPreviewDto = _mapper.Map<LoanPreviewDto>(loanDomain);

                loanPreviewDto.ClientFullname = _moneySaverRepo.GetFullNameByINSS(loanToCreateDto.INSSNo);

                return Result<LoanPreviewDto>.Success(loanPreviewDto);
            }
            catch (Exception ex)
            {
                return Result<LoanPreviewDto>.Failure(ex.Message);
            }
        }

        public Result<bool> CreateLoan(LoanToCreateDto loanToCreateDto)
        {
            try
            {
                var ValidationsResult = SetDataFromDBAndValidate(loanToCreateDto);

                if (ValidationsResult.IsSucess == false)
                    return ValidationsResult;

                var defaultLoanInterestDomain = _mapper.Map<LoanInterestsDomain>(DefaultLoanInterest);

                var loanDomain = new LoanDomainCreator(ClientID, loanToCreateDto.Description, loanToCreateDto.TotalTerms,
                    loanToCreateDto.LoanAmount, defaultLoanInterestDomain, loanToCreateDto.StartDate, 
                    EndDate, loanToCreateDto.GuarantorFullName, loanToCreateDto.GuarantorWorkArea, 
                    loanToCreateDto.GuarantorINSSNo, loanToCreateDto.GuarantorBaseIncome, 
                    loanToCreateDto.GuarantorAddress, loanToCreateDto.CKCode, DefaultCompany);

                loanDomain.CreateLoan(SubPeriodsForLoan);

                var result = _loansRepo.SaveLoan(loanDomain);

                if (result == false)
                    return Result<bool>.Failure("Hubo un error al crear el préstamo.");

                return Result<bool>.Created(true, "Préstamo creado exitosamente.");
            }
            catch (Exception ex)
            {
                return Result<bool>.Failure(ex.Message);
            }   
        }

        private Result<bool> SetDataFromDBAndValidate(LoanToCreateDto loanToCreateDto)
        {
            try
            {
                var loansToCreateValidator = new LoanToCreateValidator(validateGuarantor: true);
                var dtoValidationErros = loansToCreateValidator.Validate(loanToCreateDto).Errors;

                if (dtoValidationErros.Count > 0)
                    return Result<bool>.Failure(dtoValidationErros.First().ErrorMessage);

                ClientID = _moneySaverRepo.GetClientIDByINSSNo(loanToCreateDto.INSSNo);

                if (ClientID == 0)
                    return Result<bool>.Failure("No existe un trabajador asociado al número de INSS");

                bool doClientHasAnotherLoan = _loansRepo.CheckIfClientHasAnotherLoan(ClientID);

                if (doClientHasAnotherLoan == true)
                    return Result<bool>.Failure("Este trabajador tiene actualmente un préstamo pendiente");

                bool doCKCodeExists = _loansRepo.CheckIfLoanCKAlreadyExists(loanToCreateDto.CKCode);

                if (doCKCodeExists == true)
                    return Result<bool>.Failure("Ya existe un préstamo con este código CK.");

                EndDate = CalculateEndDateForLoan(loanToCreateDto.StartDate, loanToCreateDto.TotalTerms);

                SubPeriodsForLoan = GetSubPeriodsForLoan(loanToCreateDto);

                if (SubPeriodsForLoan.Count != loanToCreateDto.TotalTerms)
                    return Result<bool>.Failure("No existen los subperiodos para cubrir los plazos del préstamo");

                DefaultLoanInterest = _loansRepo.GetDefaultLoanInterest();

                if (DefaultLoanInterest == null)
                    return Result<bool>.Failure("No existe un interes definido para los préstamos");

                DefaultCompany = _moneySaverRepo.GetDefaultCompany();

                if (loanToCreateDto.LoanAmount > DefaultCompany.CurrentAmount)
                    return Result<bool>.Failure("No existen fondos suficientes para realizar el préstamo.");

                return Result<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return Result<bool>.Failure(ex.Message);
            }
        }

        private DateTime CalculateEndDateForLoan(DateTime startDate, int loanTerms)
        {
            DateTime endDate = startDate.AddMonths(loanTerms-1).Date;

            int daysInEndDateMonth = DateTime.DaysInMonth(endDate.Year, endDate.Month);

            if (startDate.Day > daysInEndDateMonth)
            {
                endDate = new DateTime(endDate.Year, endDate.Month, daysInEndDateMonth);
            }

            return endDate;
        }

        private List<SubPeriodDomain> GetSubPeriodsForLoan(LoanToCreateDto loanToCreateDto) 
        {
            var subPeriodsForLoan = _moneySaverRepo.GetSubPeriodsForDateRange(loanToCreateDto.StartDate, EndDate);

            return subPeriodsForLoan;
        }
    }
}
