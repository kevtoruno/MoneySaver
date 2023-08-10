using Service.Core.Dtos;
using Service.Core.Dtos.PeriodsDto;
using Service.Core.Interfaces;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.SavingAccountForms
{
    public partial class FrmSavingAccountWithdrawInterests : BaseForm
    {
        private readonly int _savingAccountID;
        private readonly FrmSavingAccountDetail _frmSavingAccountDetail;

        public FrmSavingAccountWithdrawInterests(int savingAccountID, FrmSavingAccountDetail frmSavingAccountDetail)
        {
            InitializeComponent();
            _savingAccountID = savingAccountID;
            _frmSavingAccountDetail = frmSavingAccountDetail;
        }

        private void FrmSavingAccountWithdrawInterests_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
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
            var result = Mediator.Send(new WinthdrawInterestsCommand()
            {
                SavingAccountID = _savingAccountID,
                CreatedDate = dtDateCreated.Value.Date
            });

            if (result.Result.ResourceCreated)
                _frmSavingAccountDetail.LoadFormData();

            HandleResult(result.Result);
        }
    }
}
