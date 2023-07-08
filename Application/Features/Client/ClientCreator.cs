using Service.Core;
using Service.Core.Dtos;
using Service.Core.Interfaces;
using Service.Core.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Features.Client
{
    public class ClientCreator
    {
        private readonly IMoneySaverRepository _moneySaverRepo;

        public ClientCreator(IMoneySaverRepository moneySaverRepo)
        {
            _moneySaverRepo = moneySaverRepo;
        }

        public Result<bool> CreateNewClient(ClientToCreateDto clientToCreateDto) 
        {
            var clientToCreateValidator = new ClientToCreateValidator();
            var dtoValidationErros = clientToCreateValidator.Validate(clientToCreateDto).Errors;

            if (dtoValidationErros.Count > 0)
                return Result<bool>.Failure(dtoValidationErros.First().ErrorMessage);

            string clientExists = ValidateIfClientExists(clientToCreateDto);

            if (clientExists != "")
                return Result<bool>.Failure(clientExists);

            _moneySaverRepo.CreateClient(clientToCreateDto);

            return Result<bool>.Created(true, "Trabajador creado exitosamente.");
        }

        private string ValidateIfClientExists(ClientToCreateDto clientToCreateDto) 
        {
            bool doINSSExists = _moneySaverRepo.DoINSSExists(clientToCreateDto.INSS);

            if (doINSSExists)
                return "Un trabajador con este código de INSS ya existe.";

            bool doIDentificationExists = _moneySaverRepo.DoIdentificationExists(clientToCreateDto.Identification);

            if (doIDentificationExists)
                return "Un trabajador con esta cédula ya existe.";

            return "";
        }
    }
}
