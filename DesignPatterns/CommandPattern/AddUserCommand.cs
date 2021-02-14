namespace CommandPattern
{
    public class AddUserCommand : ICommand
    {
        private UserService _userService;

        public AddUserCommand(UserService userService)
        {
            _userService = userService;
        }
        
        public void Execute()
        {
            _userService.AddUser();
        }
    }
}