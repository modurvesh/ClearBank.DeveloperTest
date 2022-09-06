using System.Configuration;
using ClearBank.DeveloperTest.Interfaces;

namespace ClearBank.DeveloperTest.Services
{
    public class ConfigurationService : IConfigurationService
    {
        public string DataStoreType => ConfigurationManager.AppSettings["DataStoreType"];
    }
}
