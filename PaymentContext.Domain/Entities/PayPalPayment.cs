namespace PaymentContext.Domain.Entities
{
    public sealed class PayPalPayment : Payment
    {
        public PayPalPayment(DateTimeOffset paidDate,
                             DateTimeOffset expireDate,
                             decimal total,
                             decimal totalPaid,
                             string payer,
                             string transactionCode) : base(paidDate, expireDate, total, totalPaid, payer)
        {
            TransactionCode = transactionCode;
        }

        public string TransactionCode { get; private set; }
    }
}
