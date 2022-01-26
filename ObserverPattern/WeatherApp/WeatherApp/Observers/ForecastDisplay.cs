public class ForecastDisplay : IObserver, IDisplayElement
{
    private readonly WeatherData WeatherData;
    public float Temperature { get; set; }
    public float Humidity { get; set; }
    public float Pressure { get; set; }
    public ForecastDisplay(WeatherData weatherData)
    {
        WeatherData = weatherData;
        WeatherData.RegisterObserver(this);
    }
    public void Display()
    {
        Console.WriteLine($"ForecastDisplay: Temperature = {Temperature}; Humidity = {Humidity}; Pressure = {Pressure}");
    }

    public void Update()
    {
        Temperature = WeatherData.Temperature;
        Humidity = WeatherData.Humidity;
        Pressure = WeatherData.Pressure;
        Display();
    }

    public void UnsubscribeFromCurrentSubject()
    {
        WeatherData.RemoveObserver(this);
    }
}
