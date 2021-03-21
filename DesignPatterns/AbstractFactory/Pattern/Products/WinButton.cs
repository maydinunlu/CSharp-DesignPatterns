using System;

namespace AbstractFactoryPattern
{
    public class WinButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render WinButton");
        }
    }
}