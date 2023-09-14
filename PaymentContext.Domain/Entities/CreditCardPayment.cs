namespace PaymentContext.Domain.Entities
{
    public sealed class CreditCardPayment : Payment
    {
        public CreditCardPayment(DateTimeOffset paidDate,
                                 DateTimeOffset expireDate,
                                 decimal total,
                                 decimal totalPaid,
                                 string payer,
                                 string cardHolderName,
                                 string cardNumber,
                                 string lastTransactionNumber) : base(paidDate, expireDate, total, totalPaid, payer)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionNumber { get; private set; }


    }
}
