using Service.Core;
using Service.Core.Dtos.LoansDto;
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

namespace UI.Forms.LoanForms
{
    public partial class FrmLoansMassCreator : BaseForm
    {
        private readonly FrmLoansList _frmLoansList;
        private string filePath = string.Empty;
        public FrmLoansMassCreator(FrmLoansList frmLoansList)
        {
            InitializeComponent();
            _frmLoansList = frmLoansList;
        }

        private void FrmLoansMassCreator_Load(object sender, EventArgs e)
        {

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (filePath == string.Empty)
            {
                MessageBox.Show("Debe subir el PDF", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Mediator.Send(new PreviewLoansForMassCreationQuery { Path = filePath });

            var previewResult = Mediator.Send(new PreviewLoansForMassCreationQuery { Path = filePath });

            if (previewResult.Result.IsSucess == true)
            {
                btnCreate.Visible = true;
                SetPreviewDataInScreen(previewResult.Result.Value);
            }
            else
                HandleResult(previewResult.Result);
        }

        private void SetPreviewDataInScreen(List<LoansForPreviewMassCreationDto> loansForPreviewMass)
        {
            lblTotalPDFAmountData.Visible = true;
            lblLoansCountData.Visible = true;

            lblTotalPDFAmountData.Text = loansForPreviewMass.Where(a => a.IsValid).Sum(a => a.LoanAmount).CordobaFormat();
            lblLoansCountData.Text = loansForPreviewMass.Where(a => a.IsValid).Count().ToString();

            SetGridData(loansForPreviewMass);
        }

        private void SetGridData(List<LoansForPreviewMassCreationDto> loansForPreviewMass)
        {
            BindingSource bindingSource = CreateBindingSource(loansForPreviewMass);

            this.gridPreview.AutoGenerateColumns = false;
            this.gridPreview.DataSource = bindingSource;
        }

        private void btnFileUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Excel files (*.xls)|*.xlsx";

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

            var result = Mediator.Send(new MassCreateLoansCommand { Path = filePath }).Result;

            if (result.ResourceCreated)
                _frmLoansList.LoadGridData();

            HandleResult(result);
        }
    }
}
