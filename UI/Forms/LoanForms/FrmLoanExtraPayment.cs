using Service.Core.Dtos.LoansDto;
using Service.Handlers;
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
    public partial class FrmLoanExtraPayment : BaseForm
    {
        private readonly int _selectedLoanID;
        private readonly FrmLoanDetail _frmLoanDetail;

        public FrmLoanExtraPayment(int selectedLoanID, FrmLoanDetail frmLoanDetail)
        {
            InitializeComponent();
            _selectedLoanID = selectedLoanID;
            _frmLoanDetail = frmLoanDetail;
        }

        private void FrmLoanExtraPayment_Load(object sender, EventArgs e)
        {

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
            var loanExtraPaymentDto = new LoanExtraPaymentDto
            {
                LoanID = _selectedLoanID,
                Amount = this.txtAmount.Value,
                PayDate = this.dtDateCreated.Value,
            };

            var result = Mediator.Send(new ExtraPaymentCommand { LoanExtraPaymentDto = loanExtraPaymentDto }).Result;

            if (result.ResourceCreated)
                _frmLoanDetail.LoadFormData();

            HandleResult(result);
        }
    }
}
