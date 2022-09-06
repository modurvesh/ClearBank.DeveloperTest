using ClearBank.DeveloperTest.Types;

namespace ClearBank.DeveloperTest.Interfaces
{
    public interface IDataStore
    {
        /// <summary>
        /// This method gets the account from the data store.
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns>The account that has been requested.</returns>
        Account GetAccount(string accountNumber);

        /// <summary>
        /// This method updates the account in the data store.
        /// </summary>
        /// <param name="account"></param>
        void UpdateAccount(Account account);
    }
}
