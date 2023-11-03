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
        public LoanToCreateValidator(bool validateGuarantor)
        {
            if (validateGuarantor)
            {
                RuleFor(c => c.GuarantorAddress).NotEmpty().WithMessage("Debe ingresar la dirección de domicilio del fiador")
                .MinimumLength(10).WithMessage("La dirección de domicilio debe tener más caracteres.");

                RuleFor(c => c.GuarantorINSSNo).NotEmpty().WithMessage("Ingrese número INSS del fiador")
                .MinimumLength(3).WithMessage("Número de INSS del fiador inválido");

                RuleFor(c => c.GuarantorWorkArea).NotEmpty().WithMessage("Ingrese la area del fiador")
                .MinimumLength(2).WithMessage("El area del fiador debe tener más caracteres.");

                RuleFor(c => c.GuarantorBaseIncome).GreaterThan(100)
                    .WithMessage("El salario del fiador debe ser mayor.");

                RuleFor(c => c.GuarantorFullName).NotEmpty().WithMessage("Ingrese el nombre completo del fiador.")
                    .MinimumLength(5).WithMessage("Nombre completo debe tener más caracteres.");
            }

            RuleFor(c => c.TotalTerms).NotEmpty().WithMessage("Debes ingresar las cuotas")
                .InclusiveBetween(1,10).WithMessage("Las cuotas no pueden ser mayor a 10");

            /*RuleFor(c => c.CKCode).NotEmpty().WithMessage("Debes ingresar el código CK")
                .Length(4, 7).WithMessage("Código CK invalido, debe estar entre 4 y 7 digitos.");*/

            RuleFor(c => c.INSSNo).NotEmpty().WithMessage("Ingrese número INSS")
                .MinimumLength(3).WithMessage("Número de INSS inválido");

            RuleFor(c => c.Description).NotEmpty().WithMessage("Debe ingresar una descripción del préstamo")
                .MinimumLength(10).WithMessage("La descripción del préstamo debe tener más caracteres.");

            RuleFor(c => c.LoanAmount).GreaterThan(100).WithMessage("No se puede hacer un préstamo menor a C$ 100.00");
        }
    }
}
