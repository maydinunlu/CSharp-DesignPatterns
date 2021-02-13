namespace StrategyPattern
{
    public class DataStorage
    {
        private IDataProvider _dataProvider;

        public DataStorage(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public void Save(string data)
        {
            _dataProvider.Save(data);
        }
        
        public void Save(string data, IDataProvider provider)
        {
            provider.Save(data);
        }
    }
}