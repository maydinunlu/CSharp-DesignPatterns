using System;

namespace TemplateMethodPattern
{
    public class SendMailTask : Task
    {
        protected override void Action1()
        {
            Console.WriteLine("- Do: Action1");
        }

        protected override void Action2()
        {
            Console.WriteLine("- Do: Action2");
        }
    }
}