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
    public partial class FrmSavingAccountTotalWithdraw : BaseForm
    {
        public int _savingAccountID;
        public FrmSavingAccountDetail _frmSavingAccountDetail;

        public FrmSavingAccountTotalWithdraw()
        {
            InitializeComponent();
        }

        public FrmSavingAccountTotalWithdraw(int savingAccountID, FrmSavingAccountDetail frmSavingAccountDetail)
        {
            InitializeComponent();
            _savingAccountID = savingAccountID;
            _frmSavingAccountDetail = frmSavingAccountDetail;
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

        private void FrmSavingAccountTotalWithdraw_Load(object sender, EventArgs e)
        {

        }

        private void btnTotalWithdraw_Click(object sender, EventArgs e)
        {
            var mbOption = MessageBox.Show($"¿Está seguro que desea realizar un retiro total? El fondo de ahorro será cerrado.", "Confirmación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (mbOption == DialogResult.Yes)
            {
                var result = Mediator.Send(new FullWithdrawalCommand { SavingAccountID = _savingAccountID, Date = this.dtDateCreated.Value.Date }).Result;

                if (result.ResourceCreated)
                    _frmSavingAccountDetail.LoadFormData();

                HandleResult(result);
            }
        }
    }
}
