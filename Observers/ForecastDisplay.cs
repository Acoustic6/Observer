using System;

namespace Observer.Observers
{
    public class ForecastDisplay
    {
        public void Update(int temp, int humidity, int pressure)
        {
            Console.WriteLine($"temperature: {temp}, humidity: {humidity}, pressure: {pressure}");
        }
    }
}