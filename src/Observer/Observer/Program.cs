using ObserverPattern.Observable;
using ObserverPattern.Observers;
using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Observer ***");

            WeatherData weatherData = new WeatherData();

            CurrentConditionalDisplay conditionalDisplay = new CurrentConditionalDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);

            weatherData.SetMeasurements(26, 65, 30);
            weatherData.SetMeasurements(30, 70, 29);

            Console.ReadLine();
        }
    }
}
