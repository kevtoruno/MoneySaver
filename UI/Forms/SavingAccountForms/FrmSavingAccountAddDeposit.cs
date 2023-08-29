using Service.Core.Dtos;
using Service.Core.Dtos.PeriodsDto;
using Service.Core.Interfaces;
using Service.Features.Client;
using Service.Features.Periods;
using Service.Features.SavingAccounts;
using Service.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.SavingAccountForms
{
    public partial class FrmSavingAccountAddDeposit : BaseForm
    {
        private readonly int _savingAccountID;
        public FrmSavingAccountDetail _frmSavingAccountDetail;

        public FrmSavingAccountAddDeposit()
        {
            InitializeComponent();
        }

        public FrmSavingAccountAddDeposit(int savingAccountID, FrmSavingAccountDetail frmSavingAccountDetail)
        {
            InitializeComponent();
            _savingAccountID = savingAccountID;
            _frmSavingAccountDetail = frmSavingAccountDetail;
        }

        private void FrmSavingAccountAddDeposit_Load(object sender, EventArgs e)
        {

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
            var saDepositToCreate = new SADepositToCreateDto
            {
                SavingAccountID = _savingAccountID,
                Amount = Convert.ToDecimal(this.txtAmount.Value),
                InterestsAmount = Convert.ToDecimal(this.txtInterestsAmount.Value),
                CreatedDate = this.dtDateCreated.Value.Date
            };

            var result = Mediator.Send(new AddDepositCommand { DepositToCreateDto = saDepositToCreate });

            if (result.Result.ResourceCreated)
                _frmSavingAccountDetail.LoadFormData();

            HandleResult(result.Result);
        }
    }
}
