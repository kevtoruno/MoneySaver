using AutoMapper;
using Service.Core.Interfaces;
using Service.Features.Loans;
using Service.Features.SavingAccounts;
using Service.Handlers;
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
            this.txtINSS.Text = Program.LoanSearchFilter;

            if (Program.LoanSearchFilter != "")
            {
                LoadGridData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Program.LoanSearchFilter = this.txtINSS.Text;
            LoadGridData();
        }

        public void LoadGridData()
        {
            var loansData = Mediator.Send(new GetLoanToListQuery { INSS = Program.LoanSearchFilter }).Result;

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

        private void btnUploadMonthlyDeposits_Click(object sender, EventArgs e)
        {
            var monthlyPaymentsFrm = new FrmLoansMonthlyPayments(this);

            monthlyPaymentsFrm.ShowDialog();
        }

        private void btnMassLoanCreator_Click(object sender, EventArgs e)
        {
            var loanMassCreatorFrm = new FrmLoansMassCreator(this);

            loanMassCreatorFrm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.gridLoansList.Rows.Count <= 0)
                return;

            if (this.gridLoansList.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("Debe seleccionar un préstamo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedLoanID = (int)this.gridLoansList.CurrentRow.Cells[0].Value;

            var mbOption = MessageBox.Show($"¿Está seguro que desea eliminar el préstamo?.", "Confirmación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (mbOption == DialogResult.Yes)
            {
                DeleteLoan(selectedLoanID);
            }

        }

        private void DeleteLoan(int selectedLoanID)
        {
            var result = Mediator.Send(new DeleteLoanCommand
            {
                LoanID = selectedLoanID
            }).Result;

            if (result.ResourceCreated)
            {
                MessageBox.Show("Préstamo eliminado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGridData();
            }
            else
                MessageBox.Show(result.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
