using System;

namespace FactoryPattern
{
    public class WindowsForm : Form
    {
        public void Render()
        {
            Console.WriteLine("RenderForm: Windows");
        }
    }
}