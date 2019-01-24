using System;
using WeatherStation.ObservableModel;

namespace WeatherStation.Observers
{
    class CurrentConditionObserver : IObserver<Measurements>
    {
        #region Variables

        IDisposable unsubscriber;

        #endregion Variables

        #region Ctor

        public CurrentConditionObserver(IObservable<Measurements> weatherData)
        {
            unsubscriber = weatherData?.Subscribe(this);
        }

        #endregion Ctor

        #region IObserver

        public void OnCompleted()
        {
            unsubscriber?.Dispose();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Can't update weather");
        }

        public void OnNext(Measurements measurements)
        {
            Console.WriteLine($"Current: temperature {measurements.Temperature} ");
        }

        #endregion IObserver
    }
}
