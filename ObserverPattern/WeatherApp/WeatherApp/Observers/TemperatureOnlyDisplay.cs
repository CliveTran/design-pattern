public class TemperatureOnlyDisplay : IObserver, IDisplayElement
{
    private readonly WeatherData WeatherData;
    public float Temperature { get; set; }
    public TemperatureOnlyDisplay(WeatherData weatherData) // Consider using interface to subscribe to any subject
    {
        WeatherData = weatherData;
        WeatherData.RegisterObserver(this);
    }
    public void Display()
    {
        Console.WriteLine($"TemperatureOnlyDisplay: {Temperature}");
    }

    public void Update()
    {
        Temperature = WeatherData.Temperature;
        Display();
    }
}
