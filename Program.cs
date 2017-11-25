using System;
using Observer.Observable;
using Observer.Observers;
using Observers;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var meteostation = new Meteostation();
            var weatherData = new WeatherData(meteostation);
            var currentConditionDisplay = new CurrentConditionDisplay(weatherData);
            meteostation.mesurementsChanged();
            var forecastDisplay = new ForecastDisplay(weatherData);
            meteostation.mesurementsChanged();
            currentConditionDisplay.Unsubscribe();
            meteostation.mesurementsChanged();
            var statisticsDisplay = new StatisticsDisplay(weatherData);
            currentConditionDisplay.Subscribe(weatherData);
            meteostation.mesurementsChanged();
        }
    }
}
