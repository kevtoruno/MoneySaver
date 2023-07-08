using Service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.LoanForms
{
    public partial class FrmLoansList : BaseForm
    {
        private readonly IMoneySaverRepository _moneySaverRepository;

        public FrmLoansList(IMoneySaverRepository moneySaverRepository)
        {
            InitializeComponent();
            _moneySaverRepository = moneySaverRepository;
        }

        private void btnNewLoan_Click(object sender, EventArgs e)
        {
            var frmNewLoan = new FrmLoanNew(_moneySaverRepository, this);
            frmNewLoan.ShowDialog();
        }
    }
}
