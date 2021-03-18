namespace FactoryPattern
{
    public abstract class FormRenderer
    {
        public void Render()
        {
            Form btn = CreateForm();
            btn.Render();
        }

        public abstract Form CreateForm();
    }
}