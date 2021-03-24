using System;

namespace DesignPatterns.Factory
{
    public class MacOsForm : Form
    {
        public void Render()
        {
            Console.WriteLine("RenderForm: MacOs");
        }
    }
}