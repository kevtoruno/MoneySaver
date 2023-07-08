using Service.Core.Dtos;
using Service.Core;
using Service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Core.Validators;
using Domain.Entities;
using Service.Core.DataModel;
using Domain.Entities.Loans;

namespace Service.Features.Loans
{
    public class LoansCreator
    {
        private readonly IMoneySaverRepository _moneySaverRepo;

        public LoansCreator(IMoneySaverRepository moneySaverRepo)
        {
            _moneySaverRepo = moneySaverRepo;
        }

        public Result<bool> CreateLoan(LoanToCreateDto loanToCreateDto)
        {
            var loansToCreateValidator = new LoanToCreateValidator();
            var dtoValidationErros = loansToCreateValidator.Validate(loanToCreateDto).Errors;

            if (dtoValidationErros.Count > 0)
                return Result<bool>.Failure(dtoValidationErros.First().ErrorMessage);

            int clientID = _moneySaverRepo.GetClientIDByINSSNo(loanToCreateDto.INSSNo);

            if (clientID == 0)
                return Result<bool>.Failure("No existe un trabajador asociado al número de INSS");

            string validationFromDatabase = ValidationsToDatabase(loanToCreateDto, clientID);

            if (validationFromDatabase != "")
                return Result<bool>.Failure(validationFromDatabase);

            var periodsForLoanDomain = GetSubPeriodsForLoan(loanToCreateDto);

            if (periodsForLoanDomain.Count != loanToCreateDto.TotalTerms)
                return Result<bool>.Failure("No existen los subperiodos para cubrir los plazos del préstamo");

            var loanInterestsDefault = _moneySaverRepo.GetDefaultLoanInterest();

            if (loanInterestsDefault == null)
                return Result<bool>.Failure("No existe un interes definido para los préstamos");

            var endDate = CalcEndDateForLoan(loanToCreateDto.StartDate, loanToCreateDto.TotalTerms);

            var loanDomain = new LoanDomain(clientID, loanToCreateDto.Description, loanToCreateDto.TotalTerms,
                loanToCreateDto.LoanAmount, loanToCreateDto.StartDate, endDate);

            loanDomain.CreateLoan(periodsForLoanDomain, loanInterestsDefault.InterestRate);

            return Result<bool>.Created(true, "Préstamo creado exitosamente.");
        }

        private string ValidationsToDatabase(LoanToCreateDto loanToCreateDto, int clientID)
        {
            string errorMsg = "";
            bool doClientAlreadyHasAnotherPendingLoan = false; //CheckIfClientHasAnotherLoan

            if (doClientAlreadyHasAnotherPendingLoan)
                errorMsg = "Este trabajador tiene actualmente un préstamo pendiente";

            bool isThereAPeriodForStartDate = true; //CheckIfPeriodExistsForMonthAndYear

            if (isThereAPeriodForStartDate == false)
                errorMsg = "No existe un período configurado para la fecha de inicio";

            return errorMsg;
        }

        private List<SubPeriodDomain> GetSubPeriodsForLoan(LoanToCreateDto loanToCreateDto) 
        {
            var endDate = CalcEndDateForLoan(loanToCreateDto.StartDate, loanToCreateDto.TotalTerms);

            var subPeriodsForLoan = _moneySaverRepo.GetSubPeriodsForDateRange(loanToCreateDto.StartDate, endDate);

            return subPeriodsForLoan;
        }

        private DateTime CalcEndDateForLoan(DateTime startDate, int loanTerms)
        {
            DateTime endDate = startDate.AddMonths(loanTerms-1).Date;

            int daysInEndDateMonth = DateTime.DaysInMonth(endDate.Year, endDate.Month);

            if (startDate.Day > daysInEndDateMonth)
            {
                endDate = new DateTime(endDate.Year, endDate.Month, daysInEndDateMonth);
            }

            return endDate;
        }
    }
}
