using Service.Core;
using Service.Core.Interfaces;
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
using UI.Forms.ClientsForms;
using UI.Forms.SavingAccountForms;

namespace UI.Forms
{
    public partial class FrmSavingAccountList : BaseForm
    {
        private readonly IMoneySaverRepository _moneySaverRepository;

        public FrmSavingAccountList(IMoneySaverRepository moneySaverRepository)
        {
            InitializeComponent();
            _moneySaverRepository = moneySaverRepository;
        }

        private void btnNewSavingAccount_Click(object sender, EventArgs e)
        {
            var frmClientNew = new FrmSavingAccountNew(_moneySaverRepository, this);
            frmClientNew.ShowDialog();
        }

        public void LoadGridData()
        {
            var savingAccountsListService = new SavingAccountList(_moneySaverRepository);

            var savingAccountData = savingAccountsListService.GetSavingAccountsList(this.txtINSS.Text);

            var bindingSource = CreateBindingSource(savingAccountData);

            this.gridSavingAccountsList.AutoGenerateColumns = false;
            this.gridSavingAccountsList.DataSource = bindingSource;
        }

        private void FrmSavingAccountList_Load(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
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

            Program.InitialMenu.OpenChildForm(new FrmSavingAccountDetail(this._moneySaverRepository, selectedSavingAccountID));
        }
    }
}
