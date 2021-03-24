namespace DesignPatterns.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Windows");
            
            IButton button = client.GuiFactory.CreateButton();
            button.Render();

            ICheckbox checkbox = client.GuiFactory.CreateCheckbox();
            checkbox.Render();
        }
    }
}