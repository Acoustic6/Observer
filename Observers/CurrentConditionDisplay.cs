using System;

namespace Observer.Observers
{
    public class CurrentConditionDisplay
    {
        public void Update(int temp, int humidity, int pressure)
        {
            Console.WriteLine($"temperature: {temp}, humidity: {humidity}, pressure: {pressure}");
        }
    }
}