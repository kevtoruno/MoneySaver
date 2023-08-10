using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Service.Core.Dtos;
using Service.Core.Dtos.LoansDto;
using Service.Core.Interfaces;
using Service.Features.Loans;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.LoanForms
{
    public partial class FrmLoanNew : BaseForm
    {
        private readonly IMoneySaverRepository _moneySaverRepository;
        private readonly ILoansRepository _loansRepo;
        private readonly FrmLoansList _frmLoansList;
        private LoanToCreateDto LoanToCreateDto;
        public FrmLoanNew(IMoneySaverRepository moneySaverRepository, ILoansRepository loansRepo, FrmLoansList frmLoansList)
        {
            InitializeComponent();
            _moneySaverRepository = moneySaverRepository;
            _loansRepo = loansRepo;
            _frmLoansList = frmLoansList;
            LoanToCreateDto = new LoanToCreateDto();
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
            SetLoanToCreateDto();

            var loanCreator = new LoansCreator(_loansRepo, _moneySaverRepository, Program.ServiceProvider.GetRequiredService<IMapper>());
            var result = loanCreator.CreateLoan(LoanToCreateDto);

            HandleResult(result);

            if (result.ResourceCreated)
                _frmLoansList.LoadGridData();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            SetLoanToCreateDto();

            var loanCreator = new LoansCreator(_loansRepo, _moneySaverRepository, Program.ServiceProvider.GetRequiredService<IMapper>());
            var result = loanCreator.PreviewLoan(LoanToCreateDto);

            if (result.IsSucess)
            {
                this.btnCreate.Visible = true;
                SetPreviewData(result.Value);
            }
            else
                HandleResult(result);
        }

        private void SetLoanToCreateDto()
        {
            LoanToCreateDto.StartDate = dtStartDate.Value;
            LoanToCreateDto.TotalTerms = (int)txtInstallments.Value;
            LoanToCreateDto.INSSNo = txtINSS.Text;
            LoanToCreateDto.Description = txtDescription.Text;
            LoanToCreateDto.LoanAmount = txtLoanAmount.Value;
            LoanToCreateDto.GuarantorFullName = txtGuarantorFullName.Text;
            LoanToCreateDto.GuarantorINSSNo = txtGuarantorINSS.Text;
            LoanToCreateDto.GuarantorWorkArea = txtGuarantorWorkArea.Text;
            LoanToCreateDto.GuarantorAddress = txtGurantorAddress.Text;
            LoanToCreateDto.GuarantorBaseIncome = txtGuarantorBaseIncome.Value;
            LoanToCreateDto.CKCode = txtCKCode.Text;
        }

        private void SetPreviewData(LoanPreviewDto previewDto)
        {
            lblAmountData.Visible = true;
            lblAmountData.Text = previewDto.Amount;

            lblClientFullNameData.Visible = true;
            lblClientFullNameData.Text = previewDto.ClientFullname;

            lblInterestsData.Visible = true;
            lblInterestsData.Text = previewDto.Interests;

            lblPaperCostData.Visible = true;
            lblPaperCostData.Text = previewDto.PaperCostAmount;

            lblTermAmountData.Visible = true;
            lblTermAmountData.Text = previewDto.TermAmount;

            SetGridData(previewDto);
        }

        private void SetGridData(LoanPreviewDto previewDto)
        {
            BindingSource bindingSource = CreateBindingSource(previewDto.LoanInstallments);

            this.gridPreview.AutoGenerateColumns = false;
            this.gridPreview.DataSource = bindingSource;
        }
    }
}
