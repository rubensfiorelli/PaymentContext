using PaymentContext.Domain.Primitives;

namespace PaymentContext.Domain.Entities
{
    public class Subscription : BaseEntity
    {
        private List<Payment> _payments;         //permito add nessa lista

        public Subscription(DateTimeOffset? expireDate)
        {
            ExpireDate = expireDate;
            IsActive = true;
            _payments = new List<Payment>();
        }

        public DateTimeOffset? ExpireDate { get; private set; }
        public bool IsActive { get; set; }

        //essa apesar de receber as subscriptions, fica sendo readyonly para ser acessada de fora, assim meu dominio se torna incorruptivel
        public IReadOnlyCollection<Payment> Payments => _payments;


        public void AddPayment(Payment payment)
        {
            _payments.Add(payment);
        }

        public void Active()
        {
            IsActive = true;
            UpdatedAt = DateTimeOffset.UtcNow;
        }

        public void Disable()
        {
            IsActive = false;
            UpdatedAt = DateTimeOffset.UtcNow;
        }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
