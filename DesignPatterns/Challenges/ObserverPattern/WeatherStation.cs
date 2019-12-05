using DesignPatterns.ObserverPattern.Interfaces;
using System.Collections.Generic;

namespace DesignPatterns.Challenges.ObserverPattern
{
    public class WeatherStation : ISubject<WeatherStation>
    {
        private IList<IObserver<WeatherStation>> _observers;

        public WeatherStation()
        {
            this._observers = new List<IObserver<WeatherStation>>();
        }

        public float Temperature { get; private set; }
        public float WindSpeed { get; private set; }
        public float Pressure { get; private set; }

        public void RegisterObserver(IObserver<WeatherStation> observer)
        {
            this._observers.Add(observer);
        }

        public void RemoveObserver(IObserver<WeatherStation> observer)
        {
            this._observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach(var observer in this._observers)
            {
                observer.Update(this);
            }
        }
    }
}
