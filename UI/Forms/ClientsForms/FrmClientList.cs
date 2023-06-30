using Microsoft.Extensions.DependencyInjection;
using Service.Core.Interfaces;
using Service.Features.Client;
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
        private readonly IMoneySaverRepository _moneySaverRepository;

        public FrmClientList(IMoneySaverRepository moneySaverRepository)
        {
            InitializeComponent();
            _moneySaverRepository = moneySaverRepository;
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            var frmClientNew = new FrmClientNew(_moneySaverRepository, this);
            frmClientNew.ShowDialog();
        }

        private void FrmClientList_Load(object sender, EventArgs e)
        {
            LoadGridData();
        }

        public void LoadGridData()
        {
            var clientToList = new ClientToList(_moneySaverRepository);

            var clients = clientToList.GetClientsList(this.txtINSS.Text);

            BindingSource bindingSource = CreateBindingSource(clients);

            this.gridClientList.AutoGenerateColumns = false;
            this.gridClientList.DataSource = bindingSource;
        }

        private void gridClientList_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            btnDelete.Enabled = true;
            btnView.Enabled = true;
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
    }
}
