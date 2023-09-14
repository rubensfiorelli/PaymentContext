namespace PaymentContext.Domain.Abstractions
{
    public interface ICommand
    {
        bool IsValid();
    }
}
