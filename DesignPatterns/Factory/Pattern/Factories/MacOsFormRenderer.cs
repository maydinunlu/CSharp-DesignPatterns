namespace FactoryPattern
{
    public class MacOsFormRenderer : FormRenderer
    {
        public override Form CreateForm()
        {
            return new MacOsForm();
        }
    }
}