using FluentValidation;
using Service.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Validators
{
    internal class SavingAccountToCreateValidator : AbstractValidator<SavingAccountToCreateDto>
    {
        public SavingAccountToCreateValidator()
        {
            RuleFor(c => c.BeneficiaryAddress).NotEmpty().WithMessage("Debe ingresar la dirección de domicilio del beneficiario")
                .MinimumLength(10).WithMessage("La dirección de domicilio debe tener más caracteres.");

            RuleFor(c => c.BeneficiaryRelationship).NotEmpty().WithMessage("Ingrese el parentesco")
            .MinimumLength(3).WithMessage("Ingrese más caracteres para el parentesco");

            RuleFor(c => c.BeneficiaryPhoneNumber).NotEmpty().WithMessage("Ingrese el numero de telefono del beneficiario")
            .MinimumLength(8).WithMessage("El número de telefono debe de tener al menos 8 digitos");

            RuleFor(c => c.BeneficiaryLastNames).NotEmpty().WithMessage("Ingrese los apellidos del beneficiario.")
                .MinimumLength(3).WithMessage("Apellidos debe tener más caracteres.");

            RuleFor(c => c.BeneficiaryNames).NotEmpty().WithMessage("Ingrese los nombres del beneficiario.")
                .MinimumLength(3).WithMessage("Nombres deben tener más caracteres.");
        }
    }
}
