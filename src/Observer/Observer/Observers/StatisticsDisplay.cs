using ObserverPattern.Observable;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Observers
{
    class StatisticsDisplay : IDisplayElement, IObserver
    {
        #region Variables

        float tempSum;
        float numReadings;
        float minTemp = 200;
        float maxTemp = -200;

        ISubject weatherData;

        #endregion Variables

        #region Ctor

        public StatisticsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        #endregion Ctor

        #region IDisplayElement

        public void Display() => Console.WriteLine($"Statistics: Avg temperature {tempSum / numReadings} °C, max temperature {maxTemp} °C, min temperature {minTemp} °C");

        #endregion IDisplayElement

        #region IObserver

        public void Update(float temperature, float humidity, float pressure)
        {
            tempSum += temperature;
            numReadings++;
            if (minTemp > temperature) minTemp = temperature;
            if (maxTemp < temperature) maxTemp = temperature;
            Display();
        }

        #endregion IObserver
    }
}