using DesignPatterns.ObserverPattern.Interfaces;

namespace DesignPatterns.Challenges.ObserverPattern
{
    public class Logger : IObserver<WeatherStation>
    {
        private WeatherStation _weatherStation;

        public void Update(WeatherStation weatherStation)
        {
            this._weatherStation = weatherStation;
            this.Log();
        }

        public void Log()
        {
            // Log weather properties
        }
    }
}
