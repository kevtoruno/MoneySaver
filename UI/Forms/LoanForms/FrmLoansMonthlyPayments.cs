using Service.Core;
using Service.Core.Dtos.LoansDto;
using Service.Core.Dtos.SavingAccountsDto;
using Service.Handlers;
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
using UI.Forms.SavingAccountForms;

namespace UI.Forms.LoanForms
{
    public partial class FrmLoansMonthlyPayments : BaseForm
    {
        private readonly FrmLoansList _frmLoansList;
        private string filePath = string.Empty;
        public FrmLoansMonthlyPayments(FrmLoansList frmLoansList)
        {
            InitializeComponent();
            _frmLoansList = frmLoansList;
        }

        private void FrmLoansMonthlyPayments_Load(object sender, EventArgs e)
        {

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFileUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName; //get name of file

                string fileName = openFileDialog.SafeFileName;

                if (fileName.Length > 32)
                    fileName = fileName.Substring(0, 31) + "...";

                this.lblFileName.Text = fileName;
                this.lblFileName.Visible = true;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (filePath == string.Empty)
            {
                MessageBox.Show("Debe subir el PDF con las deducciones del mes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var previewResult = Mediator.Send(new GenerateMonthlyLoanPaymentsPreviewQuery
            {
                Date = dtDateCreated.Value,
                Path = filePath
            });

            if (previewResult.Result.IsSucess == true)
            {
                btnCreate.Visible = true;
                SetPreviewDataInScreen(previewResult.Result.Value);
            }
            else
                HandleResult(previewResult.Result);
        }

        private void SetPreviewDataInScreen(List<MonthlyLoanPaymentsForPreviewDto> monthlyLoanPaymentsForPreview)
        {
            lblClientsCount.Visible = true;
            string totalClients = $"{monthlyLoanPaymentsForPreview.Count()} afiliados encontrados";
            string validClients = $" ({monthlyLoanPaymentsForPreview.Where(a => a.IsValid).Count()} validos a procesar)";
            string notValidClients = $" ({monthlyLoanPaymentsForPreview.Where(a => a.IsValid == false).Count()} invalidos)";
            lblClientsCount.Text = totalClients + validClients + notValidClients;

            lblTotalPDFAmountData.Visible = true;
            lblTotalPDFAmountData.Text = monthlyLoanPaymentsForPreview.Sum(a => a.PaymentAmount).CordobaFormat();

            lblTotalPendingAmountData.Visible = true;
            lblTotalPendingAmountData.Text = monthlyLoanPaymentsForPreview.Where(a => a.IsValid).Sum(a => a.PendingAmount).CordobaFormat();

            SetGridData(monthlyLoanPaymentsForPreview);
        }

        private void SetGridData(List<MonthlyLoanPaymentsForPreviewDto> monthlyLoanPaymentsForPreview)
        {
            BindingSource bindingSource = CreateBindingSource(monthlyLoanPaymentsForPreview);

            this.gridPreview.AutoGenerateColumns = false;
            this.gridPreview.DataSource = bindingSource;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridPreview_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var currentRow = this.gridPreview.Rows[e.RowIndex];

            var isValid = (bool)currentRow.Cells["IsValid"].Value;

            if (isValid == false)
            {
                currentRow.DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (filePath == string.Empty)
            {
                MessageBox.Show("Debe subir el PDF con las cotizaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = Mediator.Send(new CreateMonthlyLoansPaymentsCommand { Date = dtDateCreated.Value.Date, Path = filePath }).Result;

            if (result.ResourceCreated)
                _frmLoansList.LoadGridData();

            HandleResult(result);
        }
    }
}
