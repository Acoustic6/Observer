using Observer.Observers;

namespace Observer.Observable
{
    public interface IObservable
    {
         void registerObserver(IObserver observer);
         void removeObserver(IObserver observer);
         void notifyObservers();
    }
}