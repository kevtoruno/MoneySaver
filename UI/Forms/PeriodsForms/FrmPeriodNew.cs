using Service.Core;
using Service.Core.Dtos;
using Service.Core.Interfaces;
using Service.Features.Client;
using Service.Features.Periods;
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
    public partial class FrmPeriodNew : BaseForm
    {
        private readonly FrmPeriodsList _frmPeriodsList;
        private PeriodToCreateDto periodToCreateDto;
        public FrmPeriodNew(FrmPeriodsList frmPeriodsList)
        {
            InitializeComponent();
            _frmPeriodsList = frmPeriodsList;
            this.txtYear.Text = DateTime.Now.Year.ToString();
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

            var periodToCreateResult = Mediator.Send(new PreviewPeriodToCreateQuery { Year = year }).Result;

            if (periodToCreateResult.IsSucess == false)
            {
                HandleResult(periodToCreateResult);
                return;
            }

            periodToCreateDto = periodToCreateResult.Value;
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
            var result = Mediator.Send(
                new CreatePeriodCommand
                {
                    Year = Convert.ToInt32(this.txtYear.Text),
                    CompanyID = Program.CompanyID
                }).Result;

            if (result.ResourceCreated)
            {
                _frmPeriodsList.LoadGridData();
                this.btnCreate.Visible = false;
            }

            HandleResult(result);
        }

        private void gridPreview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
