using PaymentContext.Core.Domain.Validations;
using PaymentContext.Domain.Abstractions;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Validations.Interfaces;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Commands
{
    public class CreateBoletoSubscriptionCommand : IContract, ICommand
    {
        //Fail Fast Validation

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string BarCode { get; set; }
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
        public string Country { get; set; }

        public bool IsValid()
        {
            var contracts = new ContractValidations<CreateBoletoSubscriptionCommand>()
                     .NameIsOk(FirstName, LastName, "O campo não de ser nulo!", "Student")
                     .DocumentIsOk(Document, "Informe o número do cocumento", "Numero Documento")
                     .EmailIsOk(Email, "Por favor, informe um email válido", "E-Mail")
                     .AddressIsOk(Number, Street, ZipCode, "Informe o endereço completo", "Endereço");

            return contracts.IsValid();
        }


    }
}
