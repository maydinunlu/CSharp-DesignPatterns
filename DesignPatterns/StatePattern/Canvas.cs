namespace StatePattern
{
    public class Canvas
    {
        private IControl _currentControl;
        public IControl CurrentControl
        {
            get => _currentControl;
            set => _currentControl = value;
        }

        public void Render()
        {
            _currentControl.Render();
        }
    }
}