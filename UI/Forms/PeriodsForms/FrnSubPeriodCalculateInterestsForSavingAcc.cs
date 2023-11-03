using Service.Core;
using Service.Core.Dtos.PeriodsDto;
using Service.Handlers.PeriodsHandlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.PeriodsForms
{
    public partial class FrmSubPeriodCalculateInterestsForSavingAcc : BaseForm
    {
        private readonly int _subPeriodID;
        private SubPeriodInterestsCalculationDto _subPeriodInterestsCalculationDto;
        private FrmPeriodToDetail _frmPeriodToDetail;
        public FrmSubPeriodCalculateInterestsForSavingAcc(int selectedSubPeriodID, FrmPeriodToDetail frmPeriodToDetail)
        {
            InitializeComponent();
            _subPeriodID = selectedSubPeriodID;
            _frmPeriodToDetail = frmPeriodToDetail;
        }

        private void FrmSubPeriodCalculateInterestsForSavingAcc_Load(object sender, EventArgs e)
        {
            LoadInterestFactorCalculationData();
            SetLabelsData();
            this.btnBackToPeriod.Text = "Período " + _subPeriodInterestsCalculationDto.PeriodYear;

            if (_subPeriodInterestsCalculationDto.SavingAccInterestProcessed == true)
            {
                btnPreview.Visible = false;
                txtUtilityMonths.Enabled = false;
            }
        }

        private void LoadInterestFactorCalculationData()
        {
            _subPeriodInterestsCalculationDto = Mediator.Send(new GetCurrentInterestFactorForSubPeriodQuery { SubPeriodID = _subPeriodID }).Result.Value;
        }

        private void SetLabelsData()
        {
            this.lblTotalAmountLoanedData.Text = _subPeriodInterestsCalculationDto.TotalAmountLoaned.CordobaFormat();
            this.lblTotalAmountRecoveredData.Text = _subPeriodInterestsCalculationDto.TotalAmountRecovered.CordobaFormat();
            this.lblTotalDepositsAmountData.Text = _subPeriodInterestsCalculationDto.TotalDepositAmount.CordobaFormat();
            this.lblInterestFactorData.Text = _subPeriodInterestsCalculationDto.SavingAccInterestRateDisplay.ToString() + " %";
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            var result = Mediator.Send(new PreviewInterestAmountForSubperiodQuery
            {
                SubPeriodID = _subPeriodID,
                UtilityMonths = Convert.ToInt32(this.txtUtilityMonths.Value),
                DepositDate = dtDepositDate.Value       
            }).Result;

            if (result.IsSucess)
            {
                _subPeriodInterestsCalculationDto = result.Value;
                SetLabelsData();
                SetGridDataFromDtoResult();
                this.btnCreate.Visible = true;
            }
            else
            {
                HandleResult(result);
            }
        }

        private void SetGridDataFromDtoResult()
        {
            BindingSource bindingSource = CreateBindingSource(_subPeriodInterestsCalculationDto.InterestAmountCalculatedForSavingAccounts);

            this.gridInterestFactorPreview.AutoGenerateColumns = false;
            this.gridInterestFactorPreview.DataSource = bindingSource;
        }

        private void btnBackToPeriod_Click(object sender, EventArgs e)
        {
            Program.InitialMenu.OpenChildForm(new FrmPeriodToDetail(_subPeriodInterestsCalculationDto.PeriodID));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var result = Mediator.Send(new CalculateInterestFactorAmountCommand
            {
                SubPeriodID = _subPeriodID,
                UtilityMonths = Convert.ToInt32(this.txtUtilityMonths.Value),
                DepositDate = dtDepositDate.Value.Date    
            }).Result;

            HandleResult(result);

            if (result.IsSucess)
            {
                Program.InitialMenu.OpenChildForm(_frmPeriodToDetail);
            }
        }
    }
}
