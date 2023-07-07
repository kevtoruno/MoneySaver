using Service.Core.Dtos;
using Service.Core.Dtos.PeriodsDto;
using Service.Core.Interfaces;
using Service.Features.Client;
using Service.Features.Periods;
using Service.Features.SavingAccounts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.SavingAccountForms
{
    public partial class FrmSavingAccountAddDeposit : BaseForm
    {
        private readonly IMoneySaverRepository _moneySaverRepository;
        public int _savingAccountID;
        public FrmSavingAccountDetail _frmSavingAccountDetail;

        public FrmSavingAccountAddDeposit(IMoneySaverRepository moneySaverRepository)
        {
            InitializeComponent();
            _moneySaverRepository = moneySaverRepository;
        }

        public FrmSavingAccountAddDeposit(IMoneySaverRepository moneySaverRepository, int savingAccountID, FrmSavingAccountDetail frmSavingAccountDetail)
        {
            InitializeComponent();
            _moneySaverRepository = moneySaverRepository;
            _savingAccountID = savingAccountID;
            _frmSavingAccountDetail = frmSavingAccountDetail;
        }

        private void FrmSavingAccountAddDeposit_Load(object sender, EventArgs e)
        {
            LoadPeriodsComboBox();
        }

        private void LoadPeriodsComboBox()
        {
            var periodsList = new PeriodsToList(_moneySaverRepository);

            var periodsDto = periodsList.GetPeriodsList();

            ValidateFormOnOpen(periodsDto);

            BindingSource bindingSource = CreateBindingSource(periodsDto);

            this.cbPeriods.ValueMember = "PeriodID";
            this.cbPeriods.DisplayMember = "PeriodName";
            this.cbPeriods.DataSource = bindingSource;
        }

        private void ValidateFormOnOpen(List<PeriodsToListDto> periodsDto)
        {
            DateTime today = DateTime.Now;

            if (periodsDto.Count == 0)
                MessageBox.Show("Error", "No existen períodos configurados");
            else if (periodsDto.Any(p => p.Year == today.Year) == false)
                MessageBox.Show("Error", "No existe un período para el año " + today.Year);
            else //No errors.
                return;

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

        private void cbPeriods_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSubPeriodsData();
        }

        private void LoadSubPeriodsData()
        {
            int periodID = this.cbPeriods.SelectedValue.ToString() != "" ? Convert.ToInt32(this.cbPeriods.SelectedValue) : 0;
            var periodsList = new PeriodsToList(_moneySaverRepository);
            var subPeriodsDto = periodsList.GetSubPeriodsList(periodID);

            BindingSource bindingSource = CreateBindingSource(subPeriodsDto);

            this.cbSubPeriods.ValueMember = "SubPeriodID";
            this.cbSubPeriods.DisplayMember = "SubPeriodName";
            this.cbSubPeriods.DataSource = bindingSource;
        }

        private void cbSubPeriods_SelectedIndexChanged(object sender, EventArgs e)
        {
            setComboBoxCreatedDateMinAndMax();
            var selectedSubperiod = (SubPeriodsToListDto)this.cbSubPeriods.SelectedItem;

            bool visibility = false;
            if (selectedSubperiod.Month == 6 || selectedSubperiod.Month == 12)
                visibility = true;

            this.lblInterestsAmount.Visible = visibility;
            this.txtInterestsAmount.Visible = visibility;
        }

        private void setComboBoxCreatedDateMinAndMax()
        {
            var selectedPeriod = (PeriodsToListDto)this.cbPeriods.SelectedItem;
            var selectedSubperiod = (SubPeriodsToListDto)this.cbSubPeriods.SelectedItem;

            int lastDayOfMonth = DateTime.DaysInMonth(selectedPeriod.Year, selectedSubperiod.Month);

            var minDate = new DateTime(selectedPeriod.Year, selectedSubperiod.Month, 1);
            var maxDate = new DateTime(selectedPeriod.Year, selectedSubperiod.Month, lastDayOfMonth);

            this.dtDateCreated.MaxDate = new DateTime(9998, 1, 1); //resetting maxdate to avoid crash
            this.dtDateCreated.MinDate = new DateTime(1760, 1, 1); //resetting min to avoid crash

            this.dtDateCreated.MaxDate = maxDate;
            this.dtDateCreated.MinDate = minDate;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int subbPeriodID = this.cbSubPeriods.SelectedValue.ToString() != "" ? Convert.ToInt32(this.cbSubPeriods.SelectedValue) : 0;

            var savingAccountDepositsToAdd = new SavingAccountDepositsAdd(_moneySaverRepository);

            var saDepositToCreate = new SADepositToCreateDto
            {
                SavingAccountID = _savingAccountID,
                SubPeriodID = subbPeriodID,
                Amount = Convert.ToDecimal(this.txtAmount.Value),
                InterestsAmount = Convert.ToDecimal(this.txtInterestsAmount.Value),
                CreatedDate = this.dtDateCreated.Value
            };

            var result = savingAccountDepositsToAdd.AddDepositToSavingAccount(saDepositToCreate);

            if (result.ResourceCreated)
                _frmSavingAccountDetail.LoadFormData();

            HandleResult(result, "Ahorro");
        }
    }
}
