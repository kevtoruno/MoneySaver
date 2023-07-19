using AutoMapper;
using Service.Core.Interfaces;
using Service.Features.Loans;
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
using UI.Forms.SavingAccountForms;

namespace UI.Forms.LoanForms
{
    public partial class FrmLoansList : BaseForm
    {
        private readonly IMoneySaverRepository _moneySaverRepository;
        private readonly ILoansRepository _loansRepo;
        private readonly IMapper _mapper;

        public FrmLoansList(IMoneySaverRepository moneySaverRepository, ILoansRepository loansRepo, IMapper mapper)
        {
            InitializeComponent();
            _moneySaverRepository = moneySaverRepository;
            _loansRepo = loansRepo;
            _mapper = mapper;
        }

        private void btnNewLoan_Click(object sender, EventArgs e)
        {
            var frmNewLoan = new FrmLoanNew(_moneySaverRepository, _loansRepo, this);
            frmNewLoan.ShowDialog();
        }

        private void FrmLoansList_Load(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadGridData();
        }

        public void LoadGridData()
        {
            var loansService = new LoansList(_loansRepo, _mapper);

            var loansData = loansService.GetLoansList(this.txtINSS.Text);

            var bindingSource = CreateBindingSource(loansData);

            this.gridLoansList.AutoGenerateColumns = false;
            this.gridLoansList.DataSource = bindingSource;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (this.gridLoansList.Rows.Count <= 0)
                return;

            if (this.gridLoansList.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("Debe seleccionar un préstamo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 

            int selectedLoanID = (int)this.gridLoansList.CurrentRow.Cells[0].Value;

            Program.InitialMenu.OpenChildForm(new FrmLoanDetail(this._loansRepo, _mapper , selectedLoanID));
        }
    }
}
