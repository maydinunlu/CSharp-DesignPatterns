using System;

namespace StrategyPattern
{
    public class XmlDataProvider : IDataProvider
    {
        public void Save(string data)
        {
            Console.WriteLine("SaveData: XML");
        }
    }
}