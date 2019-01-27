using System;
using System.Collections.Generic;
using System.Text;
using EventObserver.WeatherData;

namespace EventObserver.WeatherObservers
{
    class CurrentCondition
    {
        public CurrentCondition(WeatherObservable weatherObservable)
        {
            weatherObservable.Observers += Update;
        }

        void Update(object weatherObservable, Measurements measurements)
        {
            if (measurements != null)
            Console.WriteLine($"Current: temperature {measurements.Temperature}, humidity {measurements.Humidity}");
            else Console.WriteLine("Can't get weather measurements");
        }
    }
}
