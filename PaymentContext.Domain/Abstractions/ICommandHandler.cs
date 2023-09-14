namespace PaymentContext.Domain.Abstractions
{
    public interface ICommandHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
