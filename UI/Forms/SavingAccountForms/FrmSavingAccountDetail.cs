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

        private void LoadFormData()
        {
            var savingAccountToList = new SavingAccountList(_moneySaverRepository);

            var savingAccountDetail = savingAccountToList.GetSavingAccountDetail(_selectedSavingAccountID);

            SetLabelsData(savingAccountDetail);
        }

        private void SetLabelsData(SavingAccountToDetailDto savingAccountDetail)
        {
            this.lblClientFullNameData.Text = savingAccountDetail.ClientFullName;
            this.lblINSSData.Text = savingAccountDetail.INSS;
            this.lblIdentificationData.Text = savingAccountDetail.Identification;
            this.lblCreatedDateData.Text = savingAccountDetail.CreatedDate;

            if (savingAccountDetail.IsActive)
                this.lblStatusData.Text = "Activo";
            else
                this.lblStatusData.Text = "Cerrado";

            lblAmountForInterestsData.Text = "C$ " + savingAccountDetail.AmountForInterests;
            lblCurrentAmountData.Text = "C$ " + savingAccountDetail.Amount;
            lblTotalWidthdrawnData.Text = "C$ " + savingAccountDetail.TotalWithdrawn;
            lblTotalAmountData.Text = "C$ " + savingAccountDetail.TotalAmount;
        }

        private void SetGridsData(SavingAccountToDetailDto savingAccountDetail) 
        {
            var gridWithdrawalsData = CreateBindingSource(savingAccountDetail.WidthdrawalsToList);

            this.gridWidthdrawalsList.AutoGenerateColumns = false;
            this.gridWidthdrawalsList.DataSource = gridWithdrawalsData;

            var gridDepositsData = CreateBindingSource(savingAccountDetail.DepositsToList);

            this.gridDepositsList.AutoGenerateColumns = false;
            this.gridDepositsList.DataSource = gridDepositsData;
        }
    }
}
