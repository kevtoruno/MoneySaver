using Microsoft.Extensions.DependencyInjection;
using Service.Core.Dtos;
using Service.Core.Interfaces;
using Service.Features.SavingAccounts;
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
        private readonly IMoneySaverRepository _moneySaverRepository;
        private readonly int _selectedSavingAccountID;
        private SavingAccountToDetailDto SavingAccountToDetailDto;
        public FrmSavingAccountDetail(IMoneySaverRepository moneySaverRepository, int selectedSavingAccountID)
        {
            InitializeComponent();
            _moneySaverRepository = moneySaverRepository;
            _selectedSavingAccountID = selectedSavingAccountID;
        }

        private void FrmSavingAccountDetail_Load(object sender, EventArgs e)
        {
            LoadFormData();
        }

        public void LoadFormData()
        {
            var savingAccountToList = new SavingAccountList(_moneySaverRepository);

            SavingAccountToDetailDto = savingAccountToList.GetSavingAccountDetail(_selectedSavingAccountID);

            SetLabelsData();
            SetGridsData();
        }

        private void SetLabelsData()
        {
            this.lblClientFullNameData.Text = SavingAccountToDetailDto.ClientFullName;
            this.lblINSSData.Text = SavingAccountToDetailDto.INSS;
            this.lblIdentificationData.Text = SavingAccountToDetailDto.Identification;
            this.lblCreatedDateData.Text = SavingAccountToDetailDto.CreatedDate;

            if (SavingAccountToDetailDto.IsActive)
                this.lblStatusData.Text = "Activo";
            else
                this.lblStatusData.Text = "Cerrado";

            lblAmountForInterestsData.Text = "C$ " + SavingAccountToDetailDto.AmountForInterests;
            lblCurrentAmountData.Text = "C$ " + SavingAccountToDetailDto.Amount;
            lblTotalWidthdrawnData.Text = "C$ " + SavingAccountToDetailDto.TotalWithdrawn;
            lblTotalAmountData.Text = "C$ " + SavingAccountToDetailDto.TotalAmount;
        }

        private void SetGridsData()
        {
            var gridWithdrawalsData = CreateBindingSource(SavingAccountToDetailDto.SavingAccountsHistoryToList);

            this.gridWidthdrawalsList.AutoGenerateColumns = false;
            this.gridWidthdrawalsList.DataSource = gridWithdrawalsData;
        }



        private void btnDeposit_Click(object sender, EventArgs e)
        {
            /*var frmSAAccountDeposit = Program.ServiceProvider.GetRequiredService<FrmSavingAccountAddDeposit>();
            frmSAAccountDeposit._savingAccountID = SavingAccountToDetailDto.SavingAccountID;
            frmSAAccountDeposit._frmSavingAccountDetail = this;

            frmSAAccountDeposit.ShowDialog();*/

            var frmSavingAccountDeposit = new FrmSavingAccountAddDeposit(this._moneySaverRepository, SavingAccountToDetailDto.SavingAccountID, this);

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
    }
}
