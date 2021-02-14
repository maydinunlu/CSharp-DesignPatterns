using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var executer = new SendMailExecuter();
            executer.Execute();
        }
    }
}