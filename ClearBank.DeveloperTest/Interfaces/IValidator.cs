using ClearBank.DeveloperTest.Types;

namespace ClearBank.DeveloperTest.Interfaces
{
    public interface IValidator
    {
        MakePaymentResult Validate(Account account, decimal requestAmount = 0);
    }
}
