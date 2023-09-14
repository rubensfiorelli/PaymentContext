namespace PaymentContext.Domain.Entities
{
    public sealed class BoletoPayment : Payment
    {
        public BoletoPayment(DateTimeOffset paidDate,
                             DateTimeOffset expireDate,
                             decimal total,
                             decimal totalPaid,
                             string payer,
                             string barCode,
                             string boletoNumber) : base(paidDate, expireDate, total, totalPaid, payer)
        {
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }

    }
}
