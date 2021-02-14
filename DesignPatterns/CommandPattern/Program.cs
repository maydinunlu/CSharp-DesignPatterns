using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            UserService userService = new();
            ICommand addUserCommand = new AddUserCommand(userService);
            var button = new Button(addUserCommand);
            button.Click();
        }
    }
}