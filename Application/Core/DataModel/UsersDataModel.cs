using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.DataModel
{
    public class UsersDataModel
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; private set; }
        public byte[] PasswordSalt { get; private set; }
        public DateTime Created { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
    }
}
