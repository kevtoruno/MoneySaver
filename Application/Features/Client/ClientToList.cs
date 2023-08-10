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

        public ClientToCreateDto GetClientForEdit(int clientID)
        {
            return _moneySaverRepo.GetClient(clientID);
        }

        public List<ClientToListDto> GetClientsList(string INSS) 
        {
            var clientToListDto = _moneySaverRepo.GetClientsList(INSS);

            return clientToListDto;
        }
    }
}
