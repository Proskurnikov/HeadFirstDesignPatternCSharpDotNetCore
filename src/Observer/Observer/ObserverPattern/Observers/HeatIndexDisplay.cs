using System;
using ObserverPattern.Observable;

namespace ObserverPattern.Observers
{
    class HeatIndexDisplay : IDisplayElement, IObserver
    {
        #region Variables

        ISubject weatherData;
        double? heatIndex;

        #endregion Variables

        #region Ctor

        public HeatIndexDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        #endregion Ctor

        #region IDisplayElement

        public void Display()
        {
            if (heatIndex != null)
                Console.WriteLine($"Heat index is {heatIndex}");

        }

        #endregion IDisplayElement

        #region IObserver

        public void Update(float temperature, float humidity, float pressure)
        {
            heatIndex = ComputeHeatIndex(temperature, humidity);
            Display();
        }

        #endregion IObserver

        #region Methods

        double? ComputeHeatIndex(float temperature, float relativeHumidity)
        {
            //For this method temperature can be from 21 °C to 46 °C and humidity from 0 to 80 %
            if (temperature < 21 || temperature > 46 || relativeHumidity < 0 || relativeHumidity > 80) return null;

            float t = temperature * 1.8f + 32;
            float rh = relativeHumidity;

            double index = ((16.923 + (0.185212 * t) + (5.37941 * rh) - (0.100254 * t * rh)
            + (0.00941695 * (t * t)) + (0.00728898 * (rh * rh))
            + (0.000345372 * (t * t * rh)) - (0.000814971 * (t * rh * rh)) +
            (0.0000102102 * (t * t * rh * rh)) - (0.000038646 * (t * t * t)) + (0.0000291583 *
            (rh * rh * rh)) + (0.00000142721 * (t * t * t * rh)) +
            (0.000000197483 * (t * rh * rh * rh)) - (0.0000000218429 * (t * t * t * rh * rh)) +
            0.000000000843296 * (t * t * rh * rh * rh)) -
            (0.0000000000481975 * (t * t * t * rh * rh * rh)));

            double indexCelsius = (index - 32) / 1.8f;

            return indexCelsius as double?;
        }

        #endregion Methods
    }
}
