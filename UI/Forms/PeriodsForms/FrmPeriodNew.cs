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
    public partial class FrmPeriodNew : DraggableBaseForm
    {
        private readonly IMoneySaverRepository _moneySaverRepository;
        private readonly FrmPeriodsList _frmPeriodsList;
        private PeriodToCreateDto periodToCreateDto = new PeriodToCreateDto();
        private PeriodsCreator _periodCreator;
        public FrmPeriodNew(IMoneySaverRepository moneySaverRepository, FrmPeriodsList frmPeriodsList)
        {
            InitializeComponent();
            _moneySaverRepository = moneySaverRepository;
            _frmPeriodsList = frmPeriodsList;
            this.txtYear.Text = DateTime.Now.Year.ToString();
            _periodCreator = new PeriodsCreator(_moneySaverRepository);
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

            var startDate = new DateTime(year, 1, 1);
            var endDate = new DateTime(year, 12, 31);

            dtPeriodStartDate.Value = startDate;
            dtPeriodEndDate.Value = endDate;

            periodToCreateDto.EndDate = endDate;
            periodToCreateDto.StartDate = startDate;
            periodToCreateDto.EndDate = endDate;
            periodToCreateDto.Year = year;
        }
    }
}
