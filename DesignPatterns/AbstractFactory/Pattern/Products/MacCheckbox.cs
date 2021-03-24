using System;

namespace DesignPatterns.AbstractFactory
{
    public class MacCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Render MacCheckbox");
        }
    }
}