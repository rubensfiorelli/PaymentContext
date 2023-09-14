using PaymentContext.Core.Domain.Validations;
using PaymentContext.Domain.Primitives;
using PaymentContext.Domain.Validations.Interfaces;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public sealed class Student : BaseEntity, IContract
    {
        //permito add nessa lista
        private List<Subscription> _subscriptions;
        public Student(Name name, DocumentNumber document, Email email, Address address)
        {
            _subscriptions = new List<Subscription>();
            Name = name;
            Document = document;
            Email = email;
            Address = address;
        }

        public Name Name { get; private set; }
        public DocumentNumber Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }





        //essa apesar de receber as subscriptions, fica sendo readyonly para ser acessada de fora, assim meu dominio se torna uncorruptivel
        public IReadOnlyCollection<Subscription> Subscriptions => _subscriptions;
        public void AddSubscription(Subscription subscription)
        {
            foreach (var item in Subscriptions)
                item.Disable();

            _subscriptions.Add(subscription);
        }

        public override bool IsValid()
        {
            var contracts = new ContractValidations<Student>()
                     .NameIsOk(Name.FirstName, Name.LastName, "O campo não de ser nulo!", "Student")
                     .DocumentIsOk(Document.Number, "Informe o número do cocumento", "Numero Documento")
                     .EmailIsOk(Email.EmailAddress, "Por favor, informe um email válido", "E-Mail")
                     .AddressIsOk(Address.Number, Address.Street, Address.ZipCode, "Informe o endereço completo", "Endereço");

            return contracts.IsValid();
        }
    }
}
