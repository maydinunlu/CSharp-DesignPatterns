using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("With Constructor Injection");
            DataStorage storage = new DataStorage(new XmlDataProvider());
            storage.Save("data");
            
            Console.WriteLine("With Method Injection");
            storage.Save("data", new JsonDataProvider());
        }
    }
}