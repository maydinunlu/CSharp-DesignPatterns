using System;

namespace FactoryPattern
{
    public class MacOsForm : Form
    {
        public void Render()
        {
            Console.WriteLine("RenderForm: MacOs");
        }
    }
}