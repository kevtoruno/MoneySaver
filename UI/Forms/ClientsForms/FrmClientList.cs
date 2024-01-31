using Microsoft.Extensions.DependencyInjection;
using Service.Core.Interfaces;
using Service.Features.Client;
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

namespace UI.Forms
{
    public partial class FrmClientList : BaseForm
    {
        public FrmClientList()
        {
            InitializeComponent();
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            var frmClientNew = new FrmClientNew(this);
            frmClientNew.ShowDialog();
        }

        private void FrmClientList_Load(object sender, EventArgs e)
        {
            LoadGridData();
        }

        public void LoadGridData()
        {
            var clients = Mediator.Send(new GetClientListQuery { INSS = this.txtINSS.Text });

            BindingSource bindingSource = CreateBindingSource(clients.Result);

            this.gridClientList.AutoGenerateColumns = false;
            this.gridClientList.DataSource = bindingSource;
        }

        private void gridClientList_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            var selectedRow = this.gridClientList.SelectedRows;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void txtINSS_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtINSS_Click(object sender, EventArgs e)
        {
            this.txtINSS.SelectionStart = this.txtINSS.Text.Length;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.gridClientList.Rows.Count <= 0)
                return;

            if (this.gridClientList.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("Debe seleccionar un afiliado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedClientID = (int)this.gridClientList.CurrentRow.Cells[0].Value;

            var frmClientNew = new FrmClientNew(this, selectedClientID);
            frmClientNew.ShowDialog();
        }
    }
}
