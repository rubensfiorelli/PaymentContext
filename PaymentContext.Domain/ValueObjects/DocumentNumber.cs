using PaymentContext.Domain.Enums;

namespace PaymentContext.Domain.ValueObjects
{
    public record DocumentNumber(string Number, EDocumentType DocumentType) : ValueObject
    {
    }
}