using System;

namespace ObserverPattern
{
    public class UIObject : IObserver
    {
        public void Update()
        {
            Console.WriteLine("UI Updated!");
        }
    }
}