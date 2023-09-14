using PaymentContext.Domain.Notifications;

namespace PaymentContext.Core.Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> DocumentIsOk(string documentNumber, string message, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(documentNumber))
                AddNotification(new Notification(message, propertyName));

            return this;
        }
    }
}
