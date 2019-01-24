using System.Collections.Generic;
using ObserverPattern.Observers;

namespace ObserverPattern.Observable
{
    public class WeatherData : ISubject
    {
        #region Variables

        private List<IObserver> observers = new List<IObserver>();
        private float temperature;
        private float humidity;
        private float pressure;

        #endregion

        #region ISubject

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }
        
        public void RegisterObserver(IObserver observer) => observers.Add(observer);

        public bool RemoveObserver(IObserver observer) => observers.Remove(observer);

        #endregion

        #region Methods

        /// <summary>
        /// Sets measurements and then notify observers
        /// </summary>
        /// <param name="temperature">celsius, C (in original book Fahrenhate)</param>
        /// <param name="humidity">percent, % (like in original book)</param>
        /// <param name="pressure">mmHg (in original book inHg)</param>
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            NotifyObservers();
        }

        #endregion
    }
}