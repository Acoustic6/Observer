using System;
using Observer.Observable;

namespace Observer
{
    public class Meteostation
    {
        private Random random;
        private WeatherData weatherData;

        public Meteostation()
        {
            this.random = new Random();
        }

        public int getTemperature() {
            return 15 + random.Next(10);
        }

        public int getHumidity() {
            return 60 + random.Next(10);
        }

        public int getPressure() {
            return 740 + random.Next(10);
        }

        public void setWeatherData(WeatherData weatherData) {
            this.weatherData = weatherData;
        }

        public void mesurementsChanged() {
            this.weatherData.mesurementsChanged();
        }
    }
}