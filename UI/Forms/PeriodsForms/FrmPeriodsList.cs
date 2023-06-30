using Domain.Entities;
using Service.Core.Interfaces;
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
using UI.Forms.ClientsForms;

namespace UI.Forms.PeriodsForms
{
    public partial class FrmPeriodsList : BaseForm
    {
        private readonly IMoneySaverRepository _moneySaverRepository;

        public FrmPeriodsList(IMoneySaverRepository moneySaverRepository)
        {
            InitializeComponent();
            _moneySaverRepository = moneySaverRepository;
        }

        private void btnNewPeriod_Click(object sender, EventArgs e)
        {
            var frmClientNew = new FrmPeriodNew(_moneySaverRepository, this);
            frmClientNew.ShowDialog();
        }

        public void LoadGridData()
        {
            var periodToList = new PeriodsToList(_moneySaverRepository);

            var periodsList = periodToList.GetPeriodsList();

            BindingSource bindingSource = CreateBindingSource(periodsList);

            this.gridPeriodsList.AutoGenerateColumns = false;
            this.gridPeriodsList.DataSource = bindingSource;
        }

        private void FrmPeriodsList_Load(object sender, EventArgs e)
        {
             LoadGridData();
        }
    }
}
