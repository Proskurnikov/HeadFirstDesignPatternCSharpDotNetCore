using System;
using System.Collections.Generic;
using System.Text;

namespace EventObserver.WeatherData
{
    class WeatherObservable
    {
        public EventHandler<Measurements> Observers;

        public void GetMeasurements(Measurements measurements)
        {
            Observers(this, measurements);
        }
    }
}
