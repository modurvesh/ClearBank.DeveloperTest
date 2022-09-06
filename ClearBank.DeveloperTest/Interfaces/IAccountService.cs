using ClearBank.DeveloperTest.Types;

namespace ClearBank.DeveloperTest.Interfaces
{
    public interface IAccountService
    {
        Account GetAccount(string accountNumber);
        void UpdateAccount(Account account);
    }
}