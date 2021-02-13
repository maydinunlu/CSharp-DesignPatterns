using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Canvas canvas = new Canvas();
            
            canvas.CurrentControl = new ButtonControl();
            canvas.Render();
            
            canvas.CurrentControl = new TextControl();
            canvas.Render();
        }
    }
}