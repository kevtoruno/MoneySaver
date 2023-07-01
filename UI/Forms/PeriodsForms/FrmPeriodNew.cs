using Service.Core;
using Service.Core.Dtos;
using Service.Core.Interfaces;
using Service.Features.Client;
using Service.Features.Periods;
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
    public partial class FrmPeriodNew : BaseForm
    {
        private readonly IMoneySaverRepository _moneySaverRepository;
        private readonly FrmPeriodsList _frmPeriodsList;
        private PeriodToCreateDto periodToCreateDto;
        private PeriodsCreator _periodCreator;
        public FrmPeriodNew(IMoneySaverRepository moneySaverRepository, FrmPeriodsList frmPeriodsList)
        {
            InitializeComponent();
            _moneySaverRepository = moneySaverRepository;
            _frmPeriodsList = frmPeriodsList;
            this.txtYear.Text = DateTime.Now.Year.ToString();
            _periodCreator = new PeriodsCreator(_moneySaverRepository);
            periodToCreateDto = new PeriodToCreateDto();
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
            int year = Convert.ToInt32(this.txtYear.Text);

            var isPeriodValidResult = _periodCreator.CheckIfPeriodExists(year);

            HandleResult(isPeriodValidResult, "");

            if (isPeriodValidResult.Value == false)
                return;

            periodToCreateDto = _periodCreator.GeneratePeriodToCreateDto(year);
            periodToCreateDto.CompanyID = Program.CompanyID;

            dtPeriodStartDate.Value = periodToCreateDto.StartDate;
            dtPeriodEndDate.Value = periodToCreateDto.EndDate;

            SetPreviewGrid();

            this.btnCreate.Visible = true;
        }

        private void SetPreviewGrid()
        {
            var subPeriodsForPeriod = periodToCreateDto.SubPeriods;

            BindingSource bindingSource = CreateBindingSource(subPeriodsForPeriod);

            this.gridPreview.AutoGenerateColumns = false;
            this.gridPreview.DataSource = bindingSource;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var result = _periodCreator.CreatePeriods(periodToCreateDto);

            if (result.ResourceCreated)
                _frmPeriodsList.LoadGridData();

            HandleResult(result, "Período");
        }
    }
}
