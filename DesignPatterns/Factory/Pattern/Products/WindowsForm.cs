using System;

namespace DesignPatterns.Factory
{
    public class WindowsForm : Form
    {
        public void Render()
        {
            Console.WriteLine("RenderForm: Windows");
        }
    }
}