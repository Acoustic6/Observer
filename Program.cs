using System;
using Observer.Observable;
using Observer.Observers;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var meteostation = new Meteostation();
            var weatherData = new WeatherData(meteostation);
            meteostation.mesurementsChanged();
            meteostation.mesurementsChanged();
            meteostation.mesurementsChanged();
        }
    }
}
