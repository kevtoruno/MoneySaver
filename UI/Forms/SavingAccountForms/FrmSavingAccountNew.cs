using Domain.Entities;
using Service.Core;
using Service.Core.Interfaces;
using Service.Features.Client;
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

namespace UI.Forms.SavingAccountForms
{
    public partial class FrmSavingAccountNew : BaseForm
    {
        private readonly IMoneySaverRepository _moneySaverRepository;
        private readonly FrmSavingAccountList _frmSavingAccountList;

        public FrmSavingAccountNew(IMoneySaverRepository moneySaverRepository, FrmSavingAccountList frmSavingAccountList)
        {
            InitializeComponent();
            _moneySaverRepository = moneySaverRepository;
            _frmSavingAccountList = frmSavingAccountList;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSavingAccountNew_Load(object sender, EventArgs e)
        {
            LoadCBClientsData();
        }

        private void LoadCBClientsData()
        {
            var clientToList = new ClientToList(_moneySaverRepository);
            var clientsList = clientToList.GetClientsList("");

            BindingSource bindingSource = CreateBindingSource(clientsList);

            this.cbClients.ValueMember = "ClientID";
            this.cbClients.DisplayMember = "FullName";
            this.cbClients.DataSource = bindingSource;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int clientID = this.cbClients.SelectedValue.ToString() != "" ? Convert.ToInt32(this.cbClients.SelectedValue) : 0;

            if (clientID == 0)
            {
                MessageBox.Show("Debe seleccionar un trabajador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var mbOption = MessageBox.Show("¿Está seguro que desea crear una nueva cuenta de ahorro para este trabajador?", "Confirmación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (mbOption == DialogResult.Yes)
            {
                var savingAccountCreator = new SavingAccountCreator(_moneySaverRepository);
                var result = savingAccountCreator.CreateSavingAccount(clientID);

                if (result.ResourceCreated)
                    _frmSavingAccountList.LoadGridData();

                HandleResult(result, "Cuenta de ahorro");
            }   
        }
    }
}
