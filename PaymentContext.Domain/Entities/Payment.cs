using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment
    {
        protected Payment(DateTimeOffset paidDate,
                          DateTimeOffset expireDate,
                          decimal total,
                          decimal totalPaid,
                          string payer)
        {
            Number = Guid.NewGuid().ToString().Replace("-", "").Normalize();
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Payer = payer;
        }

        public string Number { get; private set; }
        public DateTimeOffset PaidDate { get; private set; }
        public DateTimeOffset ExpireDate { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }
        public string Payer { get; private set; }
        public Email Email { get; private set; }
        public DocumentNumber DocumentNumber { get; private set; }
        public Address Address { get; private set; }
    }
}
