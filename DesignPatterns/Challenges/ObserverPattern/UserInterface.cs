using DesignPatterns.ObserverPattern.Interfaces;

namespace DesignPatterns.Challenges.ObserverPattern
{
    public class UserInterface : IObserver<WeatherStation>
    {
        private WeatherStation _weatherStation;

        public void Update(WeatherStation value)
        {
        }

        public void Display()
        {
            // Display weather properties
        }
    }
}
