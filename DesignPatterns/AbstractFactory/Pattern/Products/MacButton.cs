using System;

namespace DesignPatterns.AbstractFactory
{
    public class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render MacButton");
        }
    }
}