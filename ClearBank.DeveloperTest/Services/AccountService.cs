using ClearBank.DeveloperTest.Interfaces;
using ClearBank.DeveloperTest.Types;

namespace ClearBank.DeveloperTest.Services
{
    public class AccountService : IAccountService
    {
        private readonly IConfigurationService _configurationService;
        private readonly IDataStoreFactory _dataStoreFactory;

        public AccountService(IConfigurationService configurationService, IDataStoreFactory dataStoreFactory)
        {
            _configurationService = configurationService;
            _dataStoreFactory = dataStoreFactory;
        }

        public Account GetAccount(string accountNumber)
        {
            var dataStore = _dataStoreFactory.GetDataStore(_configurationService.DataStoreType);
            return dataStore.GetAccount(accountNumber);
        }

        public void UpdateAccount(Account account)
        {
            var dataStore = _dataStoreFactory.GetDataStore(_configurationService.DataStoreType);
            dataStore.UpdateAccount(account);
        }
    }
}
