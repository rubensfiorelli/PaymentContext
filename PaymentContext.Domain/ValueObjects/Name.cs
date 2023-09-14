namespace PaymentContext.Domain.ValueObjects
{
    public record Name(string FirstName, string LastName) : ValueObject
    {
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
