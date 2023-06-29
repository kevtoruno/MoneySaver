using FluentValidation;
using Service.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Validators
{
    internal class ClientToCreateValidator : AbstractValidator<ClientToCreateDto>
    {
        public ClientToCreateValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty().WithMessage("El primer nombre no puede estar vacío");
            RuleFor(c => c.LastNames).NotEmpty().WithMessage("Los apelidos no pueden estar vacío");

            RuleFor(c => c.INSS).NotEmpty().WithMessage("Ingrese número INSS")
                .MinimumLength(3).WithMessage("Número de INSS inválido");

            RuleFor(c => c.Age).NotEmpty().WithMessage("Ingrese la edad")
                .GreaterThan(17).WithMessage("Debe ser mayor de edad.");

            RuleFor(c => c.Identification).NotEmpty().WithMessage("Ingrese la cédula")
                .Length(14).WithMessage("Formato de cédula inválido.");   
        }
    }
}
