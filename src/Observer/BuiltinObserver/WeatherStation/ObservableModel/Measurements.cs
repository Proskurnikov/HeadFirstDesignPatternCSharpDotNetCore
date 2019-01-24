namespace WeatherStation.ObservableModel
{
    struct Measurements
    {
        public float Temperature { get; private set; }
        public float Humidity { get; private set; }
        public float Pressure { get; private set; }

        public Measurements(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
        }

    }
}
