using System;
using Observer.Observable;
using Observers;

namespace Observer.Observers
{
    public class CurrentConditionDisplay : IObserver, IDisplay
    {
        private IObservable weatherData;
        private int temperature;
        private int humidity;
        private int pressure;

        public CurrentConditionDisplay(IObservable weatherData)
        {
            this.Subscribe(weatherData);
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
            Console.WriteLine($"Displaying current conditions using temp={temperature}, humidity={humidity}. pressure={pressure}.");
        }
    }
}