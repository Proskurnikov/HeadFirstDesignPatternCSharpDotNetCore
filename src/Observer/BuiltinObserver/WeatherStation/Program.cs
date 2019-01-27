using System;
using WeatherStation.ObservableModel;
using WeatherStation.Observers;

namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            WeatherData weatherData = new WeatherData();
            CurrentConditionObserver currentConditionObserver = new CurrentConditionObserver(weatherData);
            weatherData.GetMeasurements(new Measurements(11, 88, 777));
            weatherData.GetMeasurements(null);

            currentConditionObserver.OnCompleted();

            weatherData.GetMeasurements(new Measurements(25, 50, 750));

            Console.ReadLine();
        }
    }
}
