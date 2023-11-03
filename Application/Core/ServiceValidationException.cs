using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core
{
    internal class ServiceValidationException : Exception
    {
        public ServiceValidationException(string errorMessage) : base(errorMessage) { }
    }
}
