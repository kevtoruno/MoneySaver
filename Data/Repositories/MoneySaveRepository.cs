using Service.Core.Dtos;
using Service.Core.Interfaces;
using AutoMapper;
using Data.DataModel;
using Data.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using Azure.Core;

namespace Data.Repositories
{
    public class MoneySaveRepository : IMoneySaverRepository
    {
        private readonly MoneySaverContext _context;
        private readonly IMapper _mapper;

        public MoneySaveRepository(MoneySaverContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public bool DoINSSExists(string INSS)
        {
            return _context.Clients.Any(a => a.INSS == INSS);
        }

        public void CreateClient(ClientToCreateDto clientToCreateDto)
        {
            var clientToCreate = _mapper.Map<ClientsDataModel>(clientToCreateDto);

            _context.Add(clientToCreate);
            _context.SaveChanges();
        }

        public bool DoIdentificationExists(string identification)
        {
            return _context.Clients.Any(a => a.Identification == identification);
        }

        public List<ClientToListDto> GetClientsList(string firstName, string LastName)
        {
            return _context.Clients.Select(c => 
                new ClientToListDto 
                {
                    FullName = $"{c.LastNames} {c.FirstName} {c.SecondName}",
                    Age = c.Age,
                    Identification = c.Identification,
                    INSS = c.INSS,
                    ClientID = c.ClientID
                })
                .ToList();
        }

        public bool DoPeriodForTheYearExists(int year)
        {
            return _context.Periods.Any(a => a.Year == year);
        }
    }
}
