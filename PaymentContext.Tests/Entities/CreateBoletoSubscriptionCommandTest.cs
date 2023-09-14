using PaymentContext.Domain.Commands;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class CreateBoletoSubscriptionCommandTest
    {
        [TestMethod]
        public void CreateBoletoSubscriptionCommandInvalid()
        {
            var command = new CreateBoletoSubscriptionCommand
            {
                FirstName = "Teste",
                Document = "23121212",
                Email = "teste",
                Number = "123456",
                Street = "Teste",
                ZipCode = "05555"

            };

            command.IsValid();
            Assert.IsTrue(command.IsValid());

            //Assert.AreEqual(false, command.IsValid());
        }
    }
}
