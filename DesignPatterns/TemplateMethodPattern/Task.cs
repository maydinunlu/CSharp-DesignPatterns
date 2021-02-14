using System;

namespace TemplateMethodPattern
{
    public abstract class Task
    {
        public void Execute()
        {
            Console.WriteLine("Execute()");
            Console.WriteLine("- Do: Something General");
            
            Action1();
            Action2();
        }

        protected abstract void Action1();
        protected abstract void Action2();
    }
}