using System;
using System.Collections.Generic;

namespace WeatherStation.ObservableModel
{
    class WeatherData : IObservable<Measurements>
    {
        HashSet<IObserver<Measurements>> observers = new HashSet<IObserver<Measurements>>();

        #region IObersvable

        public IDisposable Subscribe(IObserver<Measurements> observer)
        {
            observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }

        #endregion IObservable

        class Unsubscriber : IDisposable
        {
            HashSet<IObserver<Measurements>> _observers;
            IObserver<Measurements> _observer;

            public Unsubscriber(HashSet<IObserver<Measurements>> observers, IObserver<Measurements> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null) _observers.Remove(_observer);
            }
        }

        public void GetMeasurements(Measurements? measurements)
        {

            foreach (IObserver<Measurements> observer in observers)
            {
                if (measurements == null)
                    observer.OnError(new Exception("Unknown measurements"));
                else
                    observer.OnNext(measurements.Value);
            }
        }
    }
}
