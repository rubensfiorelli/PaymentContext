using PaymentContext.Domain.Notifications;

namespace PaymentContext.Core.Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> AddressIsOk(string address, string street, string zipCode, string message, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(address))
                AddNotification(new Notification(message, propertyName));

            if (string.IsNullOrWhiteSpace(street))
                AddNotification(new Notification(message, propertyName));

            if (string.IsNullOrWhiteSpace(zipCode))
                AddNotification(new Notification(message, propertyName));

            return this;
        }

    }
}
