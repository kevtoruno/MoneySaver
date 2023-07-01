using Service.Core.Dtos;
using Service.Core.Interfaces;
using Service.Features.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.ClientsForms
{
    public partial class FrmClientNew : BaseForm
    {
        private readonly IMoneySaverRepository _moneySaverRepository;
        private readonly FrmClientList _frmClientList;

        public FrmClientNew(IMoneySaverRepository moneySaverRepository, FrmClientList frmClientList)
        {
            InitializeComponent();
            _moneySaverRepository = moneySaverRepository;
            _frmClientList = frmClientList;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmClientNew_Load(object sender, EventArgs e)
        {

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var clientToCreate = new ClientToCreateDto();

            clientToCreate.FirstName = this.txtFirstName.Text;
            clientToCreate.INSS = this.txtINSS.Text;
            clientToCreate.LastNames = this.txtLastName.Text;
            clientToCreate.Age = this.txtAge.Text == "" ? 0 : Convert.ToInt32(this.txtAge.Text);
            clientToCreate.SecondName = this.txtSecondName.Text;
            clientToCreate.Identification = this.txtIdentification.Text;
            clientToCreate.CompanyID = Program.CompanyID;

            var clientCreator = new ClientCreator(_moneySaverRepository);
            var result = clientCreator.CreateNewClient(clientToCreate);

            if (result.ResourceCreated)
                _frmClientList.LoadGridData();

            HandleResult(result, "Trabajador");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
