using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Dtos
{
    public class ClientToListDto
    {
        public int ClientID { get; set; }
        public string FullName { get; set; }
        public string INSS { get; set; }
        public string Identification { get; set; }
    }
}
