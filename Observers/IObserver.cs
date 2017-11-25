using System;
using Observer.Observable;

namespace  Observer.Observers
{
    public interface IObserver
    {
        void Update(int temp, int humidity, int pressure);
        void Subscribe(IObservable weatherData);
        void Unsubscribe();
    }
}