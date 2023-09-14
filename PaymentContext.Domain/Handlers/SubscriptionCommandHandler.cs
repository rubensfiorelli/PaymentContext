using PaymentContext.Domain.Abstractions;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Repositories;
using PaymentContext.Domain.Validations.Interfaces;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Handlers
{
    public class SubscriptionCommandHandler : IContract, ICommandHandler<CreateBoletoSubscriptionCommand>
    {
        private readonly IStudentRepository _repository;

        public SubscriptionCommandHandler(IStudentRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CreateBoletoSubscriptionCommand command)
        {
            //Fail Fast Validation
            command.IsValid();
            if (!command.IsValid())
                return new CommandResult(false, "Não foi possivel realizar a assinatura");

            if (_repository.DocumentExists(command.Document))
                return new CommandResult(false, "CPF já existe");

            if (_repository.EmailExists(command.Email))
                return new CommandResult(false, "Email já existe");

            var name = new Name(command.FirstName, command.LastName);
            var document = new DocumentNumber(command.Document, EDocumentType.CPF);
            var email = new Email(command.Email);
            var address = new Address(command.Number, command.Complement, command.Street, command.City, command.State, command.ZipCode, command.Country);

            var student = new Student(name, document, email, address);
            var subscription = new Subscription(DateTimeOffset.UtcNow.AddMonths(1));
            var payment = new BoletoPayment(command.PaidDate,
                                            command.ExpireDate,
                                            command.Total,
                                            command.TotalPaid,
                                            command.Payer,
                                            command.BarCode,
                                            command.BoletoNumber
                                            );

            subscription.AddPayment(payment);
            student.AddSubscription(subscription);

            _repository.CreateSubscription(student);

            return new CommandResult(true, "Sucesso, assinatura realizada!");
        }
    }
}
