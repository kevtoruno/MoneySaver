using Service.Core.Dtos;
using Service.Handlers.LoansHandlers;
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
    public partial class FrmLoanPayInstallment : BaseForm
    {
        private readonly int _selectedInstallmentID;
        private readonly FrmLoanDetail _frmLoanDetail;
        private readonly string _installmentAmount;
        private readonly int _selectedLoanID;

        public FrmLoanPayInstallment(int selectedLoanID, int installmentID, FrmLoanDetail frmLoanDetail, string installmentAmount)
        {
            InitializeComponent();
            _selectedInstallmentID = installmentID;
            _frmLoanDetail = frmLoanDetail;
            _installmentAmount = installmentAmount;
            _selectedLoanID = selectedLoanID;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLoanPayInstallment_Load(object sender, EventArgs e)
        {
            this.lblInstallmentAmountData.Text = _installmentAmount;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var payInstallmentDto = new LoanPayInstallmentDto
            {
                LoanID = _selectedLoanID,
                LoanInstallmentID = _selectedInstallmentID,
                PayDate = this.dtDateCreated.Value
            };

            var result = Mediator.Send(new PayInstallmentCommand { LoanPayInstallmentDto = payInstallmentDto }).Result;

            if (result.ResourceCreated)
                _frmLoanDetail.LoadFormData();

            HandleResult(result);
        }
    }
}
