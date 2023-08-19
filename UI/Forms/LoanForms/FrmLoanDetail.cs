using AutoMapper;
using Data.Repositories;
using Service.Core.Dtos;
using Service.Core.Dtos.LoansDto;
using Service.Core.Interfaces;
using Service.Features.Loans;
using Service.Features.SavingAccounts;
using Service.Handlers.LoansHandlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.LoanForms
{
    public partial class FrmLoanDetail : BaseForm
    {
        private LoanToDetailDto LoanToDetailDto;
        private readonly int _selectedLoanID;

        public FrmLoanDetail(int selectedLoanID)
        {
            InitializeComponent();
            _selectedLoanID = selectedLoanID;
        }

        private void FrmLoanDetail_Load(object sender, EventArgs e)
        {
            LoadFormData();
        }

        public void LoadFormData()
        {
            LoanToDetailDto = Mediator.Send(new GetLoanDetailQuery { SelectedLoanID = _selectedLoanID }).Result;
            SetLabelsData();
            SetGridsData();
        }

        private void SetLabelsData()
        {
            this.lblClientFullNameData.Text = LoanToDetailDto.ClientFullName;
            this.lblDescriptionData.Text = LoanToDetailDto.Description;
            this.lblINSSData.Text = LoanToDetailDto.INSS;
            this.lblInstallmentAmountData.Text = LoanToDetailDto.TermAmount;
            this.lblInterestsData.Text = LoanToDetailDto.Interests;
            this.lblLoanAmountData.Text = LoanToDetailDto.LoanAmount;
            this.lblPendingAmountData.Text = LoanToDetailDto.DueAmount;
            this.lblTermsData.Text = LoanToDetailDto.TotalTerms;
            this.lblAmountData.Text = LoanToDetailDto.Amount;

            if (LoanToDetailDto.IsCurrent)
                this.lblStatusData.Text = "Pendiente";
            else
                this.lblStatusData.Text = "Pagado";
        }

        private void SetGridsData()
        {
            var gridInstallmentsData = CreateBindingSource(LoanToDetailDto.Installments);

            this.gridInstallments.AutoGenerateColumns = false;
            this.gridInstallments.DataSource = gridInstallmentsData;
        }

        private void gridInstallments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var currentRow = this.gridInstallments.Rows[e.RowIndex];

            var dueAmount = (decimal)currentRow.Cells["DueAmount"].Value;
            var dueDate = (DateTime)currentRow.Cells["DueDate"].Value;
            var today = DateTime.Now;

            Color backColor = Color.FromArgb(209, 178, 100);
            Color foreColor = Color.Black;

            if (dueAmount == 0)
            {
                backColor = Color.ForestGreen;
                foreColor = Color.White;
            }
            else if (today > dueDate)
            {
                backColor = Color.Red;
                foreColor = Color.White;
            }

            currentRow.DefaultCellStyle.BackColor = backColor;
            currentRow.DefaultCellStyle.ForeColor = foreColor;
        }
    }
}
