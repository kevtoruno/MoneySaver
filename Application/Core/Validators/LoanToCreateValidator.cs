using FluentValidation;
using Service.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Validators
{
    internal class LoanToCreateValidator : AbstractValidator<LoanToCreateDto>
    {
        public LoanToCreateValidator()
        {
            RuleFor(c => c.TotalTerms).NotEmpty().WithMessage("Debes ingresar las cuotas")
                .InclusiveBetween(1,10).WithMessage("Las cuotas no pueden ser mayor a 10");

            RuleFor(c => c.INSSNo).NotEmpty().WithMessage("Ingrese número INSS")
                .MinimumLength(3).WithMessage("Número de INSS inválido");

            RuleFor(c => c.Description).NotEmpty().WithMessage("Debe ingresar una descripción del préstamo")
                .MinimumLength(10).WithMessage("La descripción del préstamo debe tener más caracteres.");

            RuleFor(c => c.LoanAmount).GreaterThan(100).WithMessage("No se puede hacer un préstamo menor a C$ 100.00");
        }
    }
}
