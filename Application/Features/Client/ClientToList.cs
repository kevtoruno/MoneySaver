using Service.Core.Dtos;
using Service.Core;
using Service.Core.Interfaces;
using Service.Core.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Features.Client
{
    public class ClientToList
    {
        private readonly IMoneySaverRepository _moneySaverRepo;

        public ClientToList(IMoneySaverRepository moneySaverRepo)
        {
            _moneySaverRepo = moneySaverRepo;
        }

        public List<ClientToListDto> GetClientsList(string firstName, string lastNames) 
        {
            var clientToListDto = _moneySaverRepo.GetClientsList(firstName, lastNames);

            return clientToListDto;
        }
    }
}
