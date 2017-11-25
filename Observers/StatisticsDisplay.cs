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

        public void Update(int temp, int hum, int pres)
        {
            this.temperature = temp;
            this.humidity = hum;
            this.pressure = pres;
            this.Disaply();
        }

        public void Disaply()
        {
            Console.WriteLine($"Displaying statistics using temp={temperature}, humidity={humidity}. pressure={pressure}.");
        }
    }
}