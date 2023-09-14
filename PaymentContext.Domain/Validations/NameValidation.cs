using PaymentContext.Domain.Notifications;

namespace PaymentContext.Core.Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> NameIsOk(string firstName, string lastName, string message, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                AddNotification(new Notification(message, propertyName));

            if (string.IsNullOrWhiteSpace(lastName))
                AddNotification(new Notification(message, propertyName));

            return this;
        }
    }
}
