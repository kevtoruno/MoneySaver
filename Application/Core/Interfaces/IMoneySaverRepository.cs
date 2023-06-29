using Service.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Interfaces
{
    public interface IMoneySaverRepository
    {
        bool DoINSSExists(string INSS);

        bool DoIdentificationExists(string identification);

        void CreateClient (ClientToCreateDto clientToCreateDto);

        List<ClientToListDto> GetClientsList(string firstName, string LastName);

        bool DoPeriodForTheYearExists(int year);
    }
}
