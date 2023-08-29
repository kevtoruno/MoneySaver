using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Dtos;

public class LoanPayInstallmentDto
{
    public int LoanID { get; set; }
    public int LoanInstallmentID { get; set; }
    public DateTime PayDate { get; set; }
}
