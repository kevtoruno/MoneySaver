using Microsoft.Reporting.WinForms;
using Service.Core.Dtos;
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
    public partial class FrmSavingAccountReport : BaseForm
    {
        private readonly SavingAccountToDetailDto _savingAccountToDetailDto;

        public FrmSavingAccountReport(SavingAccountToDetailDto savingAccountToDetailDto)
        {
            InitializeComponent();
            _savingAccountToDetailDto = savingAccountToDetailDto;
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

        private void FrmSavingAccountReport_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Reports.SavingAccountReport.rdlc";

            var rs = new ReportDataSource();

            var rParams = new List<ReportParameter>();

            var nameParam = new ReportParameter("ClientFullName", _savingAccountToDetailDto.ClientFullName);
            var amountParam = new ReportParameter("Amount", _savingAccountToDetailDto.Amount);
            var amountForInterestsParam = new ReportParameter("AmountForInterests", _savingAccountToDetailDto.AmountForInterests);

            rParams.Add(nameParam);
            rParams.Add(amountParam);
            rParams.Add(amountForInterestsParam);

            rs.Name = "DataSet1";
            rs.Value = _savingAccountToDetailDto.SavingAccountsHistoryToList;

            reportViewer1.LocalReport.SetParameters(rParams);
            reportViewer1.LocalReport.DataSources.Add(rs);
            reportViewer1.LocalReport.DisplayName =  $"Ahorros {_savingAccountToDetailDto.ClientFullName} {DateTime.Now.ToString("dd-MM-yyyy")}";

            reportViewer1.RefreshReport();
        }
    }
}
