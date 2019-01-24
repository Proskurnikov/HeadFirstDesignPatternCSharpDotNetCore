using ObserverPattern.Observable;

namespace ObserverPattern.Observers
{
    class CurrentConditionalDisplay : IObserver, IDisplayElement
    {
        #region Variables

        private float temperature;
        private float humidity;
        private ISubject weatherData;

        #endregion

        #region Ctor

        public CurrentConditionalDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        #endregion

        #region IDisplayElement

        public void Display() => System.Console.WriteLine($"Current conditions: {temperature} °C degrees and humidity {humidity} %");

        #endregion

        #region IObserver

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }

        #endregion
    }
}
