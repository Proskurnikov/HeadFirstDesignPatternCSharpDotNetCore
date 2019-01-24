using ObserverPattern.Observers;

namespace ObserverPattern.Observable
{
    interface ISubject
    {
        void RegisterObserver(IObserver observer);
        bool RemoveObserver(IObserver observer);
        void NotifyObservers();
    }

}
