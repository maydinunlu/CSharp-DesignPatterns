using System;

namespace DesignPatterns.AbstractFactory
{
    public class WinCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Render WinCheckbox");
        }
    }
}