namespace AbstractFactoryPattern
{
    public class Client
    {
        private string _operationSystem = "MacOs";
        public IGUIFactory GuiFactory { get; }

        public Client(string operationSystem)
        {
            _operationSystem = operationSystem;
            
            if (_operationSystem == "Windows")
            {
                GuiFactory = new WinFactory();
            }
            else if (_operationSystem == "MacOs")
            {
                GuiFactory = new MacFactory();
            }
        }
    }
}