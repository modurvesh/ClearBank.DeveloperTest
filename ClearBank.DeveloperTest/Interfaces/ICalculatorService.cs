using ClearBank.DeveloperTest.Types;

namespace ClearBank.DeveloperTest.Interfaces
{
    public interface ICalculatorService
    {
        void DeductPaymentAmountFromAccountBalance(Account account, decimal amount);
    }
}