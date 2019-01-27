using ObserverPattern.Observable;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Observers
{
    class ForecastDisplay : IObserver, IDisplayElement
    {
        #region Variables

        float currentPressure = 760; // 760 mmHg = 29.92 inHg (in book "inHg");
        float lastPressure;
        ISubject weatherData;

        #endregion Varibles

        #region Ctor

        public ForecastDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        #endregion Ctor

        #region IDisplayElement

        public void Display()
        {
            string message = "";
            if (currentPressure > lastPressure) message = "Improving weather on the way!";
            if (currentPressure == lastPressure) message = "More of the same";
            if (currentPressure < lastPressure) message = "Watch out cooler, rainy weather";
            Console.WriteLine($"Forecast: {message}");
        }

        #endregion IDisplayElement

        #region IDisplayElement

        public void Update(float temperature, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;

            Display();
        }

        #endregion IDisplayElement
    }
}
