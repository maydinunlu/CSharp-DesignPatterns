using System;

namespace AbstractFactoryPattern
{
    public class WinCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Render WinCheckbox");
        }
    }
}