using Domain.DomainExceptions.LoanExceptions;
using System;
using System.Linq;

namespace Domain.Entities.Loans;

public class LoanDomain
{
    public int LoanID { get; set; }
    public int ClientID { get; set; }
    public int LoanInterestID { get; set; }
    public CompanyDomain Company { get; set; }    
    public int CreatedBy { get; set; }
    public string CKCode { get; set; }
    public string Description { get; set; }
    public int TotalTerms { get; set; }
    /// <summary>
    /// Amount of money asked for the Client.
    /// </summary>
    public decimal LoanAmount { get; set; }

    public decimal Interests { get; set; }
    /// <summary>
    /// Amount to give the customer to.
    /// This amount equals LoanAmount - interests - papercost decreased.
    /// </summary>
    public decimal Amount { get; set; }
    public decimal DueAmount {  get => LoanInstallments.Sum(i => i.DueAmount); }
    public decimal TermAmount { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime CreatedDate { get; set; }
    public bool IsCurrent { get; set; }
    public decimal PaperCost { get; set; }

    public string GuarantorFullName { get; set; }
    public string GuarantorWorkArea { get; set; }
    public string GuarantorINSSNo { get; set; }
    public decimal GuarantorBaseIncome { get; set; }
    public string GuarantorAddress { get; set; }

    public List<LoanInstallmentsDomain> LoanInstallments { get; internal set; }
    public List<LoanPaymentHistoryDomain> LoanPaymentHistories { get; internal set; }

    public LoanDomain()
    {
        
    }

    public void MakeExtraPayment(decimal amount, DateTime payDate, int subPeriodID)
    {
        ValidateAmount(amount);

        CheckIfDateItsLatest(payDate);
        PayPendingInstallmentsForAmount(amount, payDate);  
        AddPaymentHistory(subPeriodID: subPeriodID, payDate, amount, isExtraPayment: true);
        FinishLoanIfApplies();

        Company.DecreaseFloatingAmount(amount);
        Company.AddCurrentAmount(amount);
    }

    private void ValidateAmount(decimal amount)
    {
        if (amount > this.DueAmount)
            throw new AmountToPayHigherThanDueAmountException();

        if (amount <= 0)
            throw new Exception("La cantidad a pagar no puede ser menor o igual a 0");

        if (amount % this.TermAmount != 0)
            throw new AmountIsNotMultipleWithTermAmount(this.TermAmount);
    }

    private void PayPendingInstallmentsForAmount(decimal amount, DateTime payDate)
    {
        var pendingInstallments = LoanInstallments
            .Where(l => l.DueAmount > 0)
            .ToList();

        foreach (var pendingInstallment in pendingInstallments.OrderBy(i => i.DueDate))
        {
            if (amount == 0)
                break;

            decimal remainingAmount = pendingInstallment.PayAmount(amount, payDate);

            amount = remainingAmount;
        }
    }

    public void PayInstallment(int installmentID, int subPeriodID, DateTime payDate)
    {
        var loanInstallmentToPay = LoanInstallments.FirstOrDefault(l => l.LoanInstallmentID == installmentID) 
            ?? throw new Exception("No existe cuota");

        decimal paymentAmount = loanInstallmentToPay.DueAmount;

        CheckIfDateItsLatest(payDate);

        loanInstallmentToPay.FullPay(payDate);   

        AddPaymentHistory(subPeriodID, payDate, paymentAmount);

        FinishLoanIfApplies();

        Company.DecreaseFloatingAmount(paymentAmount);
        Company.AddCurrentAmount(paymentAmount);
    }

    private void AddPaymentHistory(int? subPeriodID, DateTime payDate, decimal amount, bool isExtraPayment = false) 
    {
        var paymentHistory = new LoanPaymentHistoryDomain
        {
            Amount = amount,
            Date = payDate,
            IsExtraPayment = isExtraPayment,
            LoanID = this.LoanID,
            SubPeriodID = subPeriodID
        };

        LoanPaymentHistories.Add(paymentHistory);
    }

    private void FinishLoanIfApplies()
    {
        if (DueAmount == 0)
            this.IsCurrent = false;
    }

    private void CheckIfDateItsLatest(DateTime payDate)
    {
        var latestPaymentDate = LoanPaymentHistories
            .OrderByDescending(x => x.Date).FirstOrDefault();

        if (latestPaymentDate != null)
        {
            if (latestPaymentDate.Date >= payDate)
                throw new Exception("La fecha seleccionada debe ser mayor a la fecha del ultimo pago realizado.");
        }
    }
}

public class LoanPaymentHistoryDomain
{
    public int LoanHistoryID { get; set; }
    public int LoanID { get; set; }
    public int? SubPeriodID { get; set; }
    public decimal Amount { get; set; }
    public bool IsExtraPayment { get; set; }
    public DateTime Date { get; set; }
    public int CreatedBy { get; set; }
}
