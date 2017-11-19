using Observer.Observers;

namespace Observer.Observable
{
    public class WeatherData
    {
        private Meteostation meteostation;
        
        private CurrentConditionDisplay currentConditionDisplay;
        private ForecastDisplay forecastDisplay;
        private StatisticsDisplay statisticsDisplay;

        public WeatherData(Meteostation meteostation)
        {
            this.currentConditionDisplay = new CurrentConditionDisplay();
            this.forecastDisplay = new ForecastDisplay();
            this.statisticsDisplay = new StatisticsDisplay();

            this.meteostation = meteostation;
            meteostation.setWeatherData(this);

        }

        public void mesurementsChanged() 
        {
            int temperature = this.getTemperature();
            int humidity = this.getHumidity();
            int pressure = this.getPressure();

            currentConditionDisplay.Update(temperature, humidity, pressure);
            forecastDisplay.Update(temperature, humidity, pressure);
            statisticsDisplay.Update(temperature, humidity, pressure);
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