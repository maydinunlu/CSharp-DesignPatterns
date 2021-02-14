using System.Collections.Generic;

namespace ObserverPattern
{
    public class Subject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Update()
        {
            _observers.ForEach(x=>x.Update());
        }
    }
}