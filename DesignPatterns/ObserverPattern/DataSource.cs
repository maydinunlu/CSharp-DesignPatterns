namespace ObserverPattern
{
    public class DataSource : Subject
    {
        private int _value;
        public int Value
        {
            get => _value;
            set
            {
                _value = value;
                Update();
            }
        } 
    }
}