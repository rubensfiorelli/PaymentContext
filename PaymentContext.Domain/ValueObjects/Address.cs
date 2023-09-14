namespace PaymentContext.Domain.ValueObjects
{
    public record Address(string Number,
                          string Complement,
                          string Street,
                          string City,
                          string State,
                          string ZipCode,
                          string Country) : ValueObject
    {
    }
}