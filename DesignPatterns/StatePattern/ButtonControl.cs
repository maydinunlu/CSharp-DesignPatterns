using System;

namespace StatePattern
{
    public class ButtonControl : IControl
    {
        public void Render()
        {
            Console.WriteLine("Render: Button");
        }
    }
}