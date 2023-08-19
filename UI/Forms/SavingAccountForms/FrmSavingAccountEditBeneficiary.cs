using Service.Core.Dtos;
using Service.Core.Dtos.SavingAccountsDto;
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

namespace UI.Forms.SavingAccountForms
{
    public partial class FrmSavingAccountEditBeneficiary : BaseForm
    {
        private BeneficiaryToEditDto BeneficiaryToEditDto;
        private readonly FrmSavingAccountDetail _frmSavingAccountDetail;
        private readonly int _savingAccountID;

        public FrmSavingAccountEditBeneficiary(FrmSavingAccountDetail frmSavingAccountDetail, int savingAccountID)
        {
            InitializeComponent();
            _frmSavingAccountDetail = frmSavingAccountDetail;
            _savingAccountID = savingAccountID;
            BeneficiaryToEditDto = new BeneficiaryToEditDto();
        }

        private void FrmSavingAccountEditBeneficiary_Load(object sender, EventArgs e)
        {
            var result = Mediator.Send(new GetSavingAccountBeneficiaryQuery
            {
                SavingAccountID = _savingAccountID
            }).Result;

            if (result.IsSucess == false)
            {
                MessageBox.Show("Error", "No se encontró un fondo de ahorro");
                this.Close();
            }

            BeneficiaryToEditDto = result.Value;
            SetFormDataFromDto();
        }

        private void SetFormDataFromDto()
        {
            txtBeneficiaryAddress.Text = BeneficiaryToEditDto.BeneficiaryAddress;
            txtBeneficiaryLastName.Text = BeneficiaryToEditDto.BeneficiaryLastNames;
            txtBeneficiaryNames.Text = BeneficiaryToEditDto.BeneficiaryNames;
            txtBeneficiaryRelationship.Text = BeneficiaryToEditDto.BeneficiaryRelationship;
            txtBenenficiaryPhoneNumber.Text = BeneficiaryToEditDto.BeneficiaryPhoneNumber;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SetDtoFromFormData();
            var result = Mediator.Send(new EditSavingAccountBeneficiaryCommand { BeneficiaryToEditDto = BeneficiaryToEditDto }).Result;

            if (result.ResourceCreated)
                _frmSavingAccountDetail.LoadFormData();

            HandleResult(result);    
        }

        private void SetDtoFromFormData()
        {
            BeneficiaryToEditDto.BeneficiaryAddress = txtBeneficiaryAddress.Text;
            BeneficiaryToEditDto.BeneficiaryLastNames = txtBeneficiaryLastName.Text;
            BeneficiaryToEditDto.BeneficiaryNames = txtBeneficiaryNames.Text;
            BeneficiaryToEditDto.BeneficiaryRelationship = txtBeneficiaryRelationship.Text;
            BeneficiaryToEditDto.BeneficiaryPhoneNumber = txtBenenficiaryPhoneNumber.Text;
        }
    }
}
