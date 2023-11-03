using Service.Core;
using Service.Core.Dtos;
using Service.Core.Dtos.LoansDto;
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
using UI.Forms.SavingAccountForms;

namespace UI.Forms.PeriodsForms
{
    public partial class FrmPeriodToDetail : BaseForm
    {
        private readonly int _periodID;
        private PeriodsToDetailDto PeriodToDetailDto;

        public FrmPeriodToDetail(int periodID)
        {
            InitializeComponent();
            _periodID = periodID;
            LoadFormData();
        }

        private void LoadFormData()
        {
            var data = Mediator.Send(new GetPeriodToDetailQuery { PeriodID = _periodID });

            PeriodToDetailDto = data.Result.Value;
        }

        private void FrmPeriodToDetail_Load(object sender, EventArgs e)
        {
            SetLabelsData();
            SetGridsData();
        }

        private void SetLabelsData()
        {
            this.lblPeriodStartDate.Text = PeriodToDetailDto.StartDate;
            this.lblPeriodEndDate.Text = PeriodToDetailDto.EndDate;
            this.lblPeriodsTitle.Text = PeriodToDetailDto.PeriodName;
            this.lblTotalOutcome.Text = PeriodToDetailDto.SubPeriods.Sum(sp => sp.TotalOutcome).CordobaFormat();
            this.lblTotalIncome.Text = PeriodToDetailDto.SubPeriods.Sum(sp => sp.TotalIncome).CordobaFormat();
        }

        private void SetGridsData()
        {
            var gridWithdrawalsData = CreateBindingSource(PeriodToDetailDto.SubPeriods);

            this.gridSubPeriodsList.AutoGenerateColumns = false;
            this.gridSubPeriodsList.DataSource = gridWithdrawalsData;
        }

        private void gridSubPeriodsList_SelectionChanged(object sender, EventArgs e)
        {
            var month = (int)this.gridSubPeriodsList.CurrentRow.Cells["Month"].Value;

            if (month == 6 || month == 12)
            {
                this.btnCalculateInterestFactor.Visible = true;
            }
            else
                this.btnCalculateInterestFactor.Visible = false;
        }

        private void btnCalculateInterestFactor_Click(object sender, EventArgs e)
        {
            int selectedSubPeriodID = (int)this.gridSubPeriodsList.CurrentRow.Cells["SubPeriodID"].Value;

            Program.InitialMenu.OpenChildForm(new FrmSubPeriodCalculateInterestsForSavingAcc(selectedSubPeriodID, this));
        }
    }
}
