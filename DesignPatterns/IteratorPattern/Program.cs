using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var browseHistory = new BrowseHistory();
            browseHistory.Push("https://www.google.com");
            browseHistory.Push("https://www.bing.com");
            browseHistory.Push("https://www.yandex.com");

            Console.WriteLine("Browse History");
            IIterator iterator = browseHistory.CreateIterator();
            while (iterator.HasNext())
            {
                var url = iterator.Current;
                Console.WriteLine($"Url: {url}");
                iterator.Next();
            }
        }
    }
}