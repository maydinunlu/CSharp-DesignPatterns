using System;

namespace DesignPatterns.AbstractFactory
{
    public class WinButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render WinButton");
        }
    }
}