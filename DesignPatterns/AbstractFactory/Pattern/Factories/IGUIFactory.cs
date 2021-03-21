namespace AbstractFactoryPattern
{
    public interface IGUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}