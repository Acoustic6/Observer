using Observers;
using Observer.Observable;
using System;

namespace Observer.Observers
{
    public class StatisticsDisplay : IObserver, IDisplay
    {
        private IObservable weatherData;
        private int temperature;
        private int humidity;
        private int pressure;
        
        public StatisticsDisplay(IObservable weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.registerObserver(this);
        }

        public void Subscribe(IObservable weatherData) {
            this.weatherData = weatherData;
            this.weatherData.registerObserver(this);
        }

        public void Unsubscribe() {
            this.weatherData.removeObserver(this);
            this.weatherData = null;
        }

        public void Update(IObservable observable, object additionalData)
        {
            var weatherData = (WeatherData)observable;
            this.temperature = weatherData.getTemperature();
            this.humidity = weatherData.getHumidity();
            this.pressure = weatherData.getPressure();
            this.Disaply();
        }

        public void Disaply()
        {
            Console.WriteLine($"Displaying statistics using temp={temperature}, humidity={humidity}. pressure={pressure}.");
        }
    }
}