using AutoMapper;
using Service.Core.Interfaces;
using Service.Features.Loans;
using Service.Features.SavingAccounts;
using Service.Handlers.LoansHandlers;
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
        public FrmLoansList()
        {
            InitializeComponent();
        }

        private void btnNewLoan_Click(object sender, EventArgs e)
        {
            var frmNewLoan = new FrmLoanNew(this);
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
            var loansData = Mediator.Send(new GetLoanToListQuery { INSS = this.txtINSS.Text }).Result;

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

            Program.InitialMenu.OpenChildForm(new FrmLoanDetail(selectedLoanID));
        }
    }
}
