using iText.Barcodes.Dmcode;
using Microsoft.Reporting.WinForms;
using Service.Core.Dtos;
using Service.Core.Dtos.ClientsDto;
using Service.Handlers.ClientHandlers;
using Service.Handlers.LoansHandlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.ClientsForms
{
    public partial class FrmAllClientsCurrentSummary : BaseForm
    {
        private ClientsSummaryReportDto ClientSummaryReportDto;
        public FrmAllClientsCurrentSummary()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAllClientsCurrentSummary_Load(object sender, EventArgs e)
        {
            LoadClientsCurrentSummaryData();
            InitializeReport();
        }

        private void LoadClientsCurrentSummaryData()
        {
            ClientSummaryReportDto = Mediator.Send(new GenerateClientsCurrentSummaryReportQuery ()).Result.Value;
        }

        private void InitializeReport()
        {
            rvAllClientsSummary.LocalReport.ReportEmbeddedResource = "UI.Reports.AllClientsCurrentSummary.AllClientsSummaryReport.rdlc";

            var rs = new ReportDataSource();
            rs.Name = "DataSet1";
            rs.Value = ClientSummaryReportDto.ClientsSummaries;

            var rParams = new List<ReportParameter>();
            var titleParam = new ReportParameter("SummaryTitle", "Consolidado actual fondo de ahorro y préstamo");

            rParams.Add(titleParam);

            rvAllClientsSummary.LocalReport.DisplayName = "Desglose general";
            rvAllClientsSummary.LocalReport.SetParameters(rParams);
            rvAllClientsSummary.LocalReport.DataSources.Add(rs);

            rvAllClientsSummary.RefreshReport();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
