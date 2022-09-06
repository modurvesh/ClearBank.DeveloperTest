namespace ClearBank.DeveloperTest.Interfaces
{
    public interface IDataStoreFactory
    {
        IDataStore GetDataStore(string dataStoreType);
    }
}
