using ClearBank.DeveloperTest.Interfaces;
using ClearBank.DeveloperTest.Types;

namespace ClearBank.DeveloperTest.Services
{
    public class CalculatorService : ICalculatorService
    {
        public void DeductPaymentAmountFromAccountBalance(Account account, decimal amount)
        {
            account.Balance -= amount;
        }
    }
}
