using Service.Core.Interfaces;
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
    public partial class FrmSavingAccountDetail : BaseForm
    {
        private readonly IMoneySaverRepository _moneySaverRepository;
        private readonly int _selectedSavingAccountID;

        public FrmSavingAccountDetail(IMoneySaverRepository moneySaverRepository, int selectedSavingAccountID)
        {
            InitializeComponent();
            _moneySaverRepository = moneySaverRepository;
            _selectedSavingAccountID = selectedSavingAccountID;
        }
    }
}
