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
    public partial class FrmClientList : Form
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

            var clients = clientToList.GetClientsList(this.txtFirstName.Text, this.txtLastNames.Text);

            BindingSource bindingSource = new BindingSource();

            foreach (var client in clients)
            {
                bindingSource.Add(client);
            }

            //InitializeGridClientList();
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
    }
}
