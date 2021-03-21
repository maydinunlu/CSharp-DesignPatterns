using System;

namespace AbstractFactoryPattern
{
    public class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render MacButton");
        }
    }
}