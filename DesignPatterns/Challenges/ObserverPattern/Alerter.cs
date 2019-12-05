using DesignPatterns.ObserverPattern.Interfaces;

namespace DesignPatterns.Challenges.ObserverPattern
{
    public class Alerter : IObserver<WeatherStation>
    {
        private WeatherStation _weatherStation;

        public Alerter(ISubject<WeatherStation> weatherStation)
        {
            this._weatherStation = (WeatherStation) weatherStation;
            this._weatherStation.RegisterObserver(this);
        }

        public void Update(WeatherStation weatherStation)
        {
            this._weatherStation = weatherStation;
            this.Alert();
        }

        public void Alert()
        {
            // Create weather alert
        }
    }
}
