using System;

namespace StatePattern
{
    public class TextControl : IControl
    {
        public void Render()
        {
            Console.WriteLine("Render: Text");
        }
    }
}