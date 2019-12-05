using DesignPatterns.ObserverPattern.Interfaces;
using System.Collections.Generic;

namespace DesignPatterns.ObserverPattern
{
    public class SimpleSubject : ISubject<int>
    {
        private IList<IObserver<int>> _observers;

        public SimpleSubject()
        {
            this._observers = new List<IObserver<int>>();
        }

        private int _value = 0;

        public void SetValue(int value)
        {
            _value = value;
            this.NotifyObservers();
        }

        public void RegisterObserver(IObserver<int> observer)
        {
            this._observers.Add(observer);
        }

        public void RemoveObserver(IObserver<int> observer)
        {
            this._observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in this._observers)
            {
                observer.Update(this._value);
            }
        }
    }
}
