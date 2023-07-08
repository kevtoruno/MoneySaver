using Service.Core.Dtos;
using Service.Core.Interfaces;
using Service.Features.Loans;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.LoanForms
{
    public partial class FrmLoanNew : BaseForm
    {
        private readonly IMoneySaverRepository _moneySaverRepository;
        private readonly FrmLoansList _frmLoansList;

        public FrmLoanNew(IMoneySaverRepository moneySaverRepository, FrmLoansList frmLoansList)
        {
            InitializeComponent();
            _moneySaverRepository = moneySaverRepository;
            _frmLoansList = frmLoansList;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var loanToCreateDto = new LoanToCreateDto();

            loanToCreateDto.StartDate = dtStartDate.Value;
            loanToCreateDto.TotalTerms = (int) txtInstallments.Value;
            loanToCreateDto.INSSNo = txtINSS.Text;
            loanToCreateDto.Description = txtDescription.Text;
            loanToCreateDto.LoanAmount = txtLoanAmount.Value;
            
            var loanCreator = new LoansCreator(_moneySaverRepository);
            var result = loanCreator.CreateLoan(loanToCreateDto);

            HandleResult(result, "Préstamo");
        }
    }
}
