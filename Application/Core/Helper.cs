using Service.Core.DataModel;
using Service.Core.Dtos.LoansDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core
{
    public static class Helper
    {
        public static string CordobaFormat(this decimal amount)
        {
            return "C$ "+ String.Format("{0:#,##0.00}", amount);
        }

        public static string RemoveAllWhiteSpaces(this string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }
    }
}
