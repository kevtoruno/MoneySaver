using AutoMapper;
using Data.Repositories;
using Service.Core.Dtos;
using Service.Core.Dtos.LoansDto;
using Service.Core.Dtos.PeriodsDto;
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
using UI.Forms.PeriodsForms;

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

            if (this.LoanToDetailDto.IsCurrent == false)
            {
                this.btnDelete.Visible = false;
            }
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
            this.lblSavingAccTitle.Text = "Préstamo CK: " + LoanToDetailDto.CKCode;

            if (LoanToDetailDto.IsCurrent)
            {
                this.lblStatusData.Text = "Pendiente";
                this.lblStatusData.ForeColor = Color.Yellow;
            }
            else
            {
                this.lblStatusData.Text = "Pagado";
                this.lblStatusData.ForeColor = Color.LawnGreen;
                this.btnExtraPayment.Visible = false;
                this.btnRestructure.Visible = false;
            }
        }

        private void SetGridsData()
        {
            var gridInstallmentsData = CreateBindingSource(LoanToDetailDto.TransactionHistory);

            this.gridInstallments.AutoGenerateColumns = false;
            this.gridInstallments.DataSource = gridInstallmentsData;
        }

        private void gridInstallments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var currentRow = this.gridInstallments.Rows[e.RowIndex];
            var transactionType = (LoanTransactionType)currentRow.Cells["TransactionType"].Value;

            if (transactionType != LoanTransactionType.Installment)
                return;

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

        private void btnPayInstallment_Click(object sender, EventArgs e)
        {
            if (this.gridInstallments.Rows.Count <= 0)
                return;

            if (this.gridInstallments.CurrentRow.Cells["LoanInstallmentID"].Value == null)
            {
                MessageBox.Show("Debe seleccionar una cuota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isPaid = (bool)this.gridInstallments.CurrentRow.Cells["IsPaid"].Value;
            if (isPaid)
            {
                MessageBox.Show("Esta cuota ya está pagada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string installmentAmount = this.gridInstallments.CurrentRow.Cells["DueAmountDisplay"].Value.ToString() ?? "";

            int selectedInstallmentID = (int)this.gridInstallments.CurrentRow.Cells["LoanInstallmentID"].Value;

            var frmInstallment = new FrmLoanPayInstallment(_selectedLoanID, selectedInstallmentID, this, installmentAmount);
            frmInstallment.ShowDialog();
        }

        private void gridInstallments_SelectionChanged(object sender, EventArgs e)
        {
            var transactionType = (LoanTransactionType)this.gridInstallments.CurrentRow.Cells["TransactionType"].Value;

            if (transactionType == LoanTransactionType.Installment)
            {
                bool isPaid = (bool)this.gridInstallments.CurrentRow.Cells["IsPaid"].Value;

                this.btnPayInstallment.Visible = !isPaid;
            }
            else
                this.btnPayInstallment.Visible = false;
        }

        private void btnExtraPayment_Click(object sender, EventArgs e)
        {
            var frmInstallment = new FrmLoanExtraPayment(_selectedLoanID, this);
            frmInstallment.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var mbOption = MessageBox.Show($"¿Está seguro que desea eliminar el préstamo?.",
                "Confirmación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (mbOption == DialogResult.Yes)
            {
                DeleteLoan(_selectedLoanID);
            }
        }

        private void DeleteLoan(int selectedLoanID)
        {
            var result = Mediator.Send(new DeleteLoanCommand
            {
                LoanID = selectedLoanID
            }).Result;

            HandleResult(result);

            if (result.ResourceCreated)
            {
                Program.InitialMenu.OpenChildForm(new FrmLoansList());
            }
            else
                MessageBox.Show(result.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRestructure_Click(object sender, EventArgs e)
        {
            var frmInstallment = new FrmLoanRestructure(_selectedLoanID, this);
            frmInstallment.ShowDialog();
        }
    }
}
