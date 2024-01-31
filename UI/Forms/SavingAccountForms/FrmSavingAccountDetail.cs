using Microsoft.Extensions.DependencyInjection;
using Service.Core.Dtos;
using Service.Core.Interfaces;
using Service.Features.SavingAccounts;
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

namespace UI.Forms.SavingAccountForms
{
    public partial class FrmSavingAccountDetail : BaseForm
    {
        private readonly int _selectedSavingAccountID;
        private SavingAccountToDetailDto SavingAccountToDetailDto;
        public FrmSavingAccountDetail(int selectedSavingAccountID)
        {
            InitializeComponent();
            _selectedSavingAccountID = selectedSavingAccountID;
            SavingAccountToDetailDto = new SavingAccountToDetailDto();
        }

        private void FrmSavingAccountDetail_Load(object sender, EventArgs e)
        {
            LoadFormData();
        }

        public void LoadFormData()
        {
            var data = Mediator.Send(new GetSavingAccountDetailQuery { SavingAccountID = _selectedSavingAccountID });

            SavingAccountToDetailDto = data.Result;

            SetLabelsData();
            SetGridsData();
            SetButtonsState();
        }

        private void SetLabelsData()
        {
            this.lblClientFullNameData.Text = SavingAccountToDetailDto.ClientFullName;
            this.lblINSSData.Text = SavingAccountToDetailDto.INSS;
            this.lblIdentificationData.Text = SavingAccountToDetailDto.Identification;
            this.lblCreatedDateData.Text = SavingAccountToDetailDto.CreatedDate;
            this.lblBeneficiaryData.Text = SavingAccountToDetailDto.Beneficiary;

            if (SavingAccountToDetailDto.IsActive)
                this.lblStatusData.Text = "Activo";
            else
                this.lblStatusData.Text = "Cerrado";

            lblAmountForInterestsData.Text = "C$ " + SavingAccountToDetailDto.AmountForInterests;
            lblCurrentAmountData.Text = "C$ " + SavingAccountToDetailDto.Amount;
            lblTotalWidthdrawnData.Text = "C$ " + SavingAccountToDetailDto.TotalWithdrawn;
            lblTotalAmountData.Text = "C$ " + SavingAccountToDetailDto.TotalAmount;
        }

        private void SetButtonsState()
        {
            if (SavingAccountToDetailDto.IsActive == false)
            {
                this.btnRevertInterestsWithdrawal.Visible = false;
                this.btnDeposit.Visible = false;
                this.btnWithdrawInsterest.Visible = false;
                this.btnFinishSavingAccount.Text = "Re activar fondo.";
                this.btnFinishSavingAccount.BackColor = Color.FromArgb(51, 178, 73);
            }
            else
            {
                this.btnDeposit.Visible = true;
                this.btnWithdrawInsterest.Visible = true;
                this.btnFinishSavingAccount.Text = "Retiro total.";
                this.btnFinishSavingAccount.BackColor = Color.Crimson;
            }
        }

        private void SetGridsData()
        {
            var gridWithdrawalsData = CreateBindingSource(SavingAccountToDetailDto.SavingAccountsHistoryToList);

            this.gridWidthdrawalsList.AutoGenerateColumns = false;
            this.gridWidthdrawalsList.DataSource = gridWithdrawalsData;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            var frmSavingAccountDeposit = new FrmSavingAccountAddDeposit(SavingAccountToDetailDto.SavingAccountID, this);

            frmSavingAccountDeposit.ShowDialog();
        }

        private void gridWidthdrawalsList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var currentColumn = this.gridWidthdrawalsList.Columns[e.ColumnIndex];
            if (currentColumn.Name == "AmountDisplay")
            {
                var historyType = this.gridWidthdrawalsList.Rows[e.RowIndex].Cells["HistoryType"].Value;

                Color cellColor = Color.Red;

                if ((int)historyType == 0 || (int)historyType == 3)
                {
                    cellColor = Color.ForestGreen;
                }

                e.CellStyle.BackColor = cellColor;
                e.CellStyle.SelectionBackColor = cellColor;
            }
        }

        private void btnWithdrawInsterest_Click(object sender, EventArgs e)
        {
            var frmSavingAccountWithdrawInterests = new FrmSavingAccountWithdrawInterests(SavingAccountToDetailDto.SavingAccountID, this);

            frmSavingAccountWithdrawInterests.ShowDialog();
        }

        private void btnFinishSavingAccount_Click(object sender, EventArgs e)
        {
            if (SavingAccountToDetailDto.IsActive)
            {
                var frmSavingAccountTotalWithdraw = new FrmSavingAccountTotalWithdraw(SavingAccountToDetailDto.SavingAccountID, this);

                frmSavingAccountTotalWithdraw.ShowDialog();
            }
            else
            {
                AskToReActivateSavingAccount();
            }
        }

        private void AskToReActivateSavingAccount()
        {
            var mbOption = MessageBox.Show($"¿Está seguro que desea volver a activar el fondo de ahorro?.", "Confirmación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (mbOption == DialogResult.Yes)
            {
                ReActivateSavingAccount();
            }
        }

        private void ReActivateSavingAccount()
        {
            var result = Mediator.Send(new ReactivateSavingAccountCommand { SavingAccountID = _selectedSavingAccountID }).Result;

            if (result.ResourceCreated)
                LoadFormData();

            HandleResult(result, closeIfResourceCreated: false);
        }

        private void btnEditBeneficiary_Click(object sender, EventArgs e)
        {
            var frmEditBeneficiary = new FrmSavingAccountEditBeneficiary(this, _selectedSavingAccountID);

            frmEditBeneficiary.ShowDialog();
        }

        private void btnExportData_Click(object sender, EventArgs e)
        {
            var reportFrm = new FrmSavingAccountReport(SavingAccountToDetailDto);

            reportFrm.ShowDialog();
        }

        private void btnRevertInterestsWithdrawal_Click(object sender, EventArgs e)
        {
            var mbOption = MessageBox.Show($"¿Está seguro que desea deshacer el retiro de intereses?.", "Confirmación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (mbOption == DialogResult.Yes)
            {
                RollbackInterestWithdrawal();
            }
        }

        private void RollbackInterestWithdrawal()
        {
            int selectedSavingAccountWithdrawalID = (int)this.gridWidthdrawalsList.CurrentRow.Cells[0].Value;
            var result = Mediator.Send(new RollbackInterestWithdrawalCommand
            {
                SavingAccountID = _selectedSavingAccountID,
                SavingAccountWithdrawalID = selectedSavingAccountWithdrawalID
            }).Result;

            if (result.ResourceCreated)
                LoadFormData();

            HandleResult(result, closeIfResourceCreated: false);
        }

        private void gridWidthdrawalsList_SelectionChanged(object sender, EventArgs e)
        {
            var historyType = (int)this.gridWidthdrawalsList.CurrentRow.Cells["HistoryType"].Value;

            if (historyType == 1)
                this.btnRevertInterestsWithdrawal.Visible = true;
            else
                this.btnRevertInterestsWithdrawal.Visible = false;
        }
    }
}
