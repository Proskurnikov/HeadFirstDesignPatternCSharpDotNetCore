using System;
using System.Collections.Generic;
using System.Text;

namespace EventObserver.WeatherData
{
    class Measurements
    {
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double Pressure { get; set; }

        public Measurements(double temperature, double humidity, double pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
        }
    }
}
