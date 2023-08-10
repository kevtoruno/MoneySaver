using Service.Core;
using Service.Core.Dtos;
using Service.Core.Interfaces;
using Service.Features.Client;
using Service.Handlers;
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
        private readonly FrmClientList _frmClientList;
        private readonly int _clientID;
        private ClientToCreateDto ClientForEdit;
        public FrmClientNew(FrmClientList frmClientList, int clientID = 0)
        {
            InitializeComponent();
            _frmClientList = frmClientList;
            _clientID = clientID;
            ClientForEdit = new ClientToCreateDto();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmClientNew_Load(object sender, EventArgs e)
        {
            if (_clientID == 0)
                return;

            ClientForEdit = Mediator.Send(new GetClientForEditQuery() { ClientID = _clientID }).Result;

            lblClientTitle.Text = "Editar afiliado";
            btnCreate.Text = "Editar";
            this.Text = "Editar afiliado";
            SetTextBoxesWithData();
        }

        private void SetTextBoxesWithData()
        {
            txtAddress.Text = ClientForEdit.Address;

            if (ClientForEdit.BaseIncome < txtBaseIncome.Minimum)
                txtBaseIncome.Minimum = ClientForEdit.BaseIncome;

            txtBaseIncome.Value = ClientForEdit.BaseIncome;
            txtFirstName.Text = ClientForEdit.FirstName;
            txtIdentification.Text = ClientForEdit.Identification;
            txtINSS.Text = ClientForEdit.INSS;
            txtLastName.Text = ClientForEdit.LastNames;
            txtSecondName.Text = ClientForEdit.SecondName;
            txtWorkArea.Text = ClientForEdit.WorkArea;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (_clientID != 0)
                EditClient();
            else
                CreateNewClient();
        }

        private void EditClient()
        {
            SetClientForEditDtoFromTextBoxes();

            var result = Mediator.Send(new EditClientCommand() { ClientToCreateDto = ClientForEdit });

            if (result.Result.ResourceCreated)
                _frmClientList.LoadGridData();

            HandleResult(result.Result);
        }

        private void CreateNewClient()
        {
            SetClientForEditDtoFromTextBoxes();
            var result = Mediator.Send(new CreateClientCommand() { ClientToCreateDto = ClientForEdit });

            if (result.Result.ResourceCreated)
                _frmClientList.LoadGridData();

            HandleResult(result.Result);
        }

        private void SetClientForEditDtoFromTextBoxes()
        {
            ClientForEdit.FirstName = this.txtFirstName.Text;
            ClientForEdit.INSS = this.txtINSS.Text.RemoveAllWhiteSpaces();
            ClientForEdit.LastNames = this.txtLastName.Text;
            ClientForEdit.SecondName = this.txtSecondName.Text;
            ClientForEdit.Identification = this.txtIdentification.Text;
            ClientForEdit.Address = this.txtAddress.Text;
            ClientForEdit.WorkArea = this.txtWorkArea.Text;
            ClientForEdit.BaseIncome = this.txtBaseIncome.Value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
