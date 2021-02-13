using System;

namespace StrategyPattern
{
    public class JsonDataProvider : IDataProvider
    {
        public void Save(string data)
        {
            Console.WriteLine("SaveData: JSON");
        }
    }
}