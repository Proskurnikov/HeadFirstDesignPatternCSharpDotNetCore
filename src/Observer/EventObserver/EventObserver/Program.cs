using System;
using EventObserver.WeatherData;
using EventObserver.WeatherObservers;

namespace EventObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            WeatherObservable weatherObservable = new WeatherObservable();
            CurrentCondition currentCondition = new CurrentCondition(weatherObservable);

            weatherObservable.GetMeasurements(new Measurements(10, 60, 760));
            weatherObservable.GetMeasurements(null);

            #if (!vscode) // Add this for run from VS in order to console window will keep open
            Console.WriteLine("Press Enter for exit");
            Console.ReadLine();
            #endif
        }
    }
}
