using System;
using Observer.Observable;

namespace  Observer.Observers
{
    public interface IObserver
    {
        void Update(IObservable observable, object eventArgs);
        void Subscribe(IObservable weatherData);
        void Unsubscribe();
    }
}