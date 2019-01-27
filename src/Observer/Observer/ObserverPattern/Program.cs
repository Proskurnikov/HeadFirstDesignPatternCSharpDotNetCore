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
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurements(26, 65, 760);
            weatherData.SetMeasurements(30, 70, 750);
            weatherData.SetMeasurements(0, 90, 790);

            #if (!vscode) // Add this for run from VS in order to console window will keep open
            Console.WriteLine("Press Enter for exit");
            Console.ReadLine();
            #endif
        }
    }
}
