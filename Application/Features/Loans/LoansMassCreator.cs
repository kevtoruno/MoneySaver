using AutoMapper;
using Domain.Entities.Loans;
using Service.Core;
using Service.Core.Dtos;
using Service.Core.Dtos.LoansDto;
using Service.Core.Interfaces;
using Service.Features.PDFDataExtractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Features.Loans
{
    internal class LoansMassCreator
    {
        private readonly IMoneySaverRepository _moneySaverRepo;
        private readonly ILoansRepository _loansRepo;
        private List<LoansForPreviewMassCreationDto> loansForPreviewDto;
        private List<ClientToListDto> clientsFromDB;
        private List<LoansToListDto> existingLoans;
        public LoansMassCreator(IMoneySaverRepository moneySaverRepo, ILoansRepository loansRepo)
        {
            _moneySaverRepo = moneySaverRepo;
            _loansRepo = loansRepo;
        }

        public Result<List<LoansForPreviewMassCreationDto>> GenerateLoanMassCreationPreview(string path)
        {
            try
            {
                var loanDataExcelExtractor = new LoanDataExcelExtractor();

                loansForPreviewDto = loanDataExcelExtractor.CreateDtoFromExcelFile(path);

                clientsFromDB = _moneySaverRepo.GetClientsList("");
                existingLoans = _loansRepo.GetLoansList("");

                SetValidRecordsWhereINSSExists();
                SetInvalidRecordIfThereIsExistingLoan();

                return Result<List<LoansForPreviewMassCreationDto>>.Success(loansForPreviewDto.OrderBy(l => l.IsValid).ToList());
            }
            catch (Exception ex)
            {
                Helper.SendErrorToText(ex);
                return Result<List<LoansForPreviewMassCreationDto>>.Failure(ex.Message);
            }
            
        }

        private void SetValidRecordsWhereINSSExists()
        {
            foreach (var loanForPreview in loansForPreviewDto)
            {
                if (loanForPreview.LoanAmount == 0 || loanForPreview.TotalInstallments == 0)
                {
                    loanForPreview.IsValid = false;
                    loanForPreview.ErrorMessage = "Cantidad préstamo o cuotas no pueden ser 0";
                    continue;
                }

                var clientFromDb = clientsFromDB.FirstOrDefault(c => c.INSS == loanForPreview.INSSNo);

                if (clientFromDb != null)
                {
                    loanForPreview.IsValid = true;
                    loanForPreview.ClientFullName = clientFromDb.FullName;
                    loanForPreview.ClientID = clientFromDb.ClientID;
                }
                else
                {
                    loanForPreview.IsValid = false;
                    loanForPreview.ErrorMessage = "NO EXISTE UN INSS ASOCIADO EN SISTEMA";
                }
            }
        }

        private void SetInvalidRecordIfThereIsExistingLoan()
        {
            foreach (var loanForPreview in loansForPreviewDto)
            {
                bool INSSExists = existingLoans.Any(c => c.CKCode == loanForPreview.CKCode);

                if (INSSExists)
                {
                    loanForPreview.IsValid = false;
                    loanForPreview.ErrorMessage = "Ya existe un préstamo con este mismo CK.";
                }
            }
        }
    }
}
