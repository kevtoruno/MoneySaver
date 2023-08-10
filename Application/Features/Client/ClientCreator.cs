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

        public Result<bool> EditClient(ClientToCreateDto clientToEditDto)
        {
            var clientToCreateValidator = new ClientToCreateValidator();
            var dtoValidationErros = clientToCreateValidator.Validate(clientToEditDto).Errors;

            if (dtoValidationErros.Count > 0)
                return Result<bool>.Failure(dtoValidationErros.First().ErrorMessage);

            string clientExists = ValidateIfClientExists(clientToEditDto);

            if (clientExists != "")
                return Result<bool>.Failure(clientExists);

            _moneySaverRepo.EditClient(clientToEditDto);

            return Result<bool>.Created(true, "Afiliado editado exitosamente.");
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

            return Result<bool>.Created(true, "Afiliado creado exitosamente.");
        }

        private string ValidateIfClientExists(ClientToCreateDto clientToCreateDto) 
        {
            bool doINSSExists = _moneySaverRepo.DoINSSExists(clientToCreateDto.INSS, clientToCreateDto.ClientID);

            if (doINSSExists)
                return "Un afiliado con este código de INSS ya existe.";

            bool doIDentificationExists = _moneySaverRepo.DoIdentificationExists(clientToCreateDto.Identification, clientToCreateDto.ClientID);

            if (doIDentificationExists)
                return "Un afiliado con esta cédula ya existe.";

            return "";
        }
    }
}
