namespace DesignPatterns.Factory
{
    public class Client
    {
        private string _operationSystem = "MacOs";
        private FormRenderer _formRenderer;
        
        public void Init()
        {
            if (_operationSystem == "Windows")
            {
                _formRenderer = new WindowsFormRenderer();
            }
            else if (_operationSystem == "MacOs")
            {
                _formRenderer = new MacOsFormRenderer();
            }
        }

        public void ShowForm()
        {
            _formRenderer.Render();
        }
    }
}