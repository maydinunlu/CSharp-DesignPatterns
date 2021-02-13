using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Editor editor = new Editor();
            History history = new History();
            
            editor.Content = "Content-1";
            history.Push(editor.CreateState());
            Console.WriteLine("Current: " + editor.Content);

            editor.Content = "Content-2";
            history.Push(editor.CreateState());
            Console.WriteLine("Current: " + editor.Content);

            Console.WriteLine("------------------");
            
            editor.Content = "Content-3";
            editor.Restore(history.Pop());
            editor.Restore(history.Pop());
            Console.WriteLine("Current: " + editor.Content);
        }
    }
}