using Service.Core;
using Service.Core.Dtos.SavingAccountsDto;
using Service.Handlers;
using System.Data;

namespace UI.Forms.SavingAccountForms
{
    public partial class FrmSavingAccountsMontlyDeposit : BaseForm
    {
        private readonly FrmSavingAccountList _frmSavingAccountList;
        private string filePath = string.Empty;

        public FrmSavingAccountsMontlyDeposit(FrmSavingAccountList frmSavingAccountList)
        {
            InitializeComponent();
            _frmSavingAccountList = frmSavingAccountList;
        }

        private void btnFileUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = openFileDialog.FileName; //get name of file

                string fileName = openFileDialog.SafeFileName;

                if (fileName.Length > 32)
                    fileName = fileName.Substring(0, 31) + "...";

                this.lblFileName.Text = fileName;
                this.lblFileName.Visible = true;
            }
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

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (filePath == string.Empty)
            {
                MessageBox.Show("Debe subir el PDF con las cotizaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var previewResult = Mediator.Send(new GenerateMonthlyDepositsPreviewQuery
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

        private void SetPreviewDataInScreen(List<MonthlyDepositsForPreviewDto> monthlyDepositsForPreview)
        {
            lblClientsCount.Visible = true;
            lblClientsCount.Text = $"{monthlyDepositsForPreview.Where(a => a.IsValid).Count()} afiliados";

            lblTotalAmountData.Visible = true;
            lblTotalAmountData.Text = monthlyDepositsForPreview.Where(a => a.IsValid).Sum(a => a.Amount).CordobaFormat();

            SetGridData(monthlyDepositsForPreview);
        }

        private void SetGridData(List<MonthlyDepositsForPreviewDto> monthlyDepositsForPreview)
        {
            BindingSource bindingSource = CreateBindingSource(monthlyDepositsForPreview);

            this.gridPreview.AutoGenerateColumns = false;
            this.gridPreview.DataSource = bindingSource;
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

            var result = Mediator.Send(new CreateMonthlyDepositsCommand { Date = dtDateCreated.Value.Date, Path = filePath });

            if (result.Result.ResourceCreated)
                _frmSavingAccountList.LoadGridData();

            HandleResult(result.Result);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
