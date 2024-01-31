using AutoMapper;
using Service.Core;
using Service.Core.Interfaces;
using Service.Features.SavingAccounts;
using Service.Handlers;
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
using UI.Forms.SavingAccountForms;

namespace UI.Forms
{
    public partial class FrmSavingAccountList : BaseForm
    {
        public FrmSavingAccountList()
        {
            InitializeComponent();
        }

        private void btnNewSavingAccount_Click(object sender, EventArgs e)
        {
            var frmClientNew = new FrmSavingAccountNew(this);
            frmClientNew.ShowDialog();
        }

        public void LoadGridData(int saDetailViewID = 0)
        {
            if (saDetailViewID > 0)
            {
                Program.InitialMenu.OpenChildForm(new FrmSavingAccountDetail(saDetailViewID));
            }
            else
            {
                var savingAccountData = Mediator.Send(new GetSavingAccountListQuery { INSSNo = Program.SavingAccountsSearchFilter });

                var bindingSource = CreateBindingSource(savingAccountData.Result);

                this.gridSavingAccountsList.AutoGenerateColumns = false;
                this.gridSavingAccountsList.DataSource = bindingSource;
            }
        }

        private void FrmSavingAccountList_Load(object sender, EventArgs e)
        {
            this.txtINSS.Text = Program.SavingAccountsSearchFilter;

            if (Program.SavingAccountsSearchFilter != "")
            {
                LoadGridData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Program.SavingAccountsSearchFilter = this.txtINSS.Text;
            LoadGridData();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (this.gridSavingAccountsList.Rows.Count <= 0)
                return;

            if (this.gridSavingAccountsList.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("Debe seleccionar una cuenta bancaria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedSavingAccountID = (int)this.gridSavingAccountsList.CurrentRow.Cells[0].Value;

            Program.InitialMenu.OpenChildForm(new FrmSavingAccountDetail(selectedSavingAccountID));
        }

        private void btnUploadMonthlyDeposits_Click(object sender, EventArgs e)
        {
            var frmMonthlyDeposit = new FrmSavingAccountsMontlyDeposit(this);
            frmMonthlyDeposit.ShowDialog();
        }

        private void txtINSS_Click(object sender, EventArgs e)
        {
            this.txtINSS.SelectionStart = this.txtINSS.Text.Length;
        }
    }
}
