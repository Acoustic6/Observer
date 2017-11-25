using System.Collections.Generic;
using Observer.Observers;

namespace Observer.Observable
{
    public class WeatherData : IObservable
    {
        private Meteostation meteostation;
        private List<IObserver> observers;
        private int temperature;
        private int humidity;
        private int pressure;

        public WeatherData(Meteostation meteostation)
        {
            this.meteostation = meteostation;
            meteostation.setWeatherData(this);
            this.observers = new List<IObserver>();
        }

        public void mesurementsChanged() 
        {
            temperature = this.getTemperature();
            humidity = this.getHumidity();
            pressure = this.getPressure();
            this.notifyObservers();
        }

        public void notifyObservers()
        {
            foreach(IObserver observer in this.observers) {
                observer.Update(this.temperature, this.humidity, this.pressure);
            }
        }
        
        public void registerObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        private int getTemperature() {
            return meteostation.getTemperature();
        }

        private int getHumidity() {
            return meteostation.getHumidity();
        }

        public int getPressure() {
            return meteostation.getPressure();
        }
    }
}