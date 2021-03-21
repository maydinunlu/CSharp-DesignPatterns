using System;

namespace AbstractFactoryPattern
{
    public class MacCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Render MacCheckbox");
        }
    }
}