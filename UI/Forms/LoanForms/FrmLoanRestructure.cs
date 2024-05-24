using Service.Core.Dtos.LoansDto;
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
    public partial class FrmLoanRestructure : BaseForm
    {
        private readonly int _selectedLoanID;
        private readonly FrmLoanDetail _frmLoanDetail;
        public FrmLoanRestructure(int selectedLoanID, FrmLoanDetail frmLoanDetail)
        {
            InitializeComponent();
            _selectedLoanID = selectedLoanID;
            _frmLoanDetail = frmLoanDetail;
        }

        private void FrmLoanRestructure_Load(object sender, EventArgs e)
        {
            LoadCurrentLoanInstallmentsData();
        }

        private void LoadCurrentLoanInstallmentsData()
        {
            var currentInstallments = Mediator.Send(new GetLoanDetailQuery { SelectedLoanID = _selectedLoanID })
                .Result.TransactionHistory;

            currentInstallments = currentInstallments
                .Where(li => li.TransactionType == LoanTransactionType.Installment && li.IsPaid == false)
                .ToList();

            var gridInstallmentsData = CreateBindingSource(currentInstallments);

            this.gridCurrentInstallments.AutoGenerateColumns = false;
            this.gridCurrentInstallments.DataSource = gridInstallmentsData;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnPreviewRestructure_Click(object sender, EventArgs e)
        {
            this.btnCreate.Visible = false;
            var result = Mediator.Send(new PreviewLoanRestructureCommand { LoanID = _selectedLoanID }).Result;

            HandleResult(result);

            if (result.IsSucess == false)
                return;

            var gridInstallmentsData = CreateBindingSource(result.Value);

            this.gridRestructuredLoanPreview.AutoGenerateColumns = false;
            this.gridRestructuredLoanPreview.DataSource = gridInstallmentsData;
            this.btnCreate.Visible = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var mbOption = MessageBox.Show($"¿Está seguro que desea reestructurar el préstamo? ESTA ACCIÓN ES IRREVERSIBLE.",
                "Confirmación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (mbOption == DialogResult.Yes)
            {
                var result = Mediator.Send(new CreateLoanRestructureCommand { LoanID = _selectedLoanID }).Result;

                HandleResult(result);

                if (result.ResourceCreated)
                    _frmLoanDetail.LoadFormData();
            }
        }
    }
}
