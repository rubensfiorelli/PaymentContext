using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Commands
{
    public class CreateCreditCardSubscriptionCommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string LastTransactionNumber { get; set; }
        public string BoletoNumber { get; set; }
        public string PaymentNumber { get; set; }
        public DateTimeOffset PaidDate { get; set; }
        public DateTimeOffset ExpireDate { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
        public string Payer { get; set; }
        public EDocumentType PayerDocument { get; set; }
        public DocumentNumber DocumentNumber { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}
