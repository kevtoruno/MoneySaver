using Domain.Entities;
using Service.Core;
using Service.Core.Dtos;
using Service.Core.Interfaces;
using Service.Features.Client;
using Service.Features.Periods;
using Service.Handlers.ClientHandlers;
using Service.Handlers.SavingAccountsHandlers;
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
        private readonly FrmSavingAccountList _frmSavingAccountList;
        private SavingAccountToCreateDto SavingAccountToCreateDto;
        public FrmSavingAccountNew(FrmSavingAccountList frmSavingAccountList)
        {
            InitializeComponent();
            _frmSavingAccountList = frmSavingAccountList;
            SavingAccountToCreateDto = new SavingAccountToCreateDto();
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

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string INSSno = this.txtINSS.Text;

            if (INSSno == "" || INSSno.Length <= 5)
            {
                MessageBox.Show("Debe ingresar un número de INSS valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string clietFullName = Mediator.Send(new GetFullNameByINSSQuery { INSSNo = INSSno }).Result;

            if (clietFullName == "")
            {
                MessageBox.Show($"No existe un afiliado asociado al no INSS {INSSno}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SetSavingAccountToCreateDto();

            var mbOption = MessageBox.Show($"¿Está seguro que desea crear un nuevo fondo de ahorro para {clietFullName}?", "Confirmación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (mbOption == DialogResult.Yes)
            {
                var result = Mediator.Send(new CreateSavingAccountCommand { SavingAccountToCreateDto = SavingAccountToCreateDto }).Result;

                if (result.ResourceCreated)
                    _frmSavingAccountList.LoadGridData(saDetailViewID: result.Value);

                HandleResult(result);
            }
        }

        private void SetSavingAccountToCreateDto()
        {
            SavingAccountToCreateDto.INSSNo = txtINSS.Text;
            SavingAccountToCreateDto.BeneficiaryRelationship = txtBeneficiaryRelationship.Text;
            SavingAccountToCreateDto.BeneficiaryNames = txtBeneficiaryNames.Text;
            SavingAccountToCreateDto.BeneficiaryLastNames = txtBeneficiaryLastName.Text;
            SavingAccountToCreateDto.BeneficiaryAddress = txtBeneficiaryAddress.Text;
            SavingAccountToCreateDto.BeneficiaryPhoneNumber = txtBenenficiaryPhoneNumber.Text;
        }
    }
}
