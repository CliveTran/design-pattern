public class CurrentConditionDisplay : IObserver, IDisplayElement
{
    private readonly WeatherData WeatherData;
    public float Temperature { get; set; }
    public float Humidity { get; set; }
    public float Pressure { get; set; }
    public CurrentConditionDisplay(WeatherData weatherData)
    {
        WeatherData = weatherData;
        WeatherData.RegisterObserver(this);
    }
    public void Display()
    {
        Console.WriteLine($"CurrentConditionDisplay: Temperature = {Temperature}; Humidity = {Humidity}; Pressure = {Pressure}");
    }

    public void Update(float temp, float humidity, float pressure)
    {
        Temperature = temp;
        Humidity = humidity;
        Pressure = pressure;
        Display();
    }
    public void UnsubscribeFromCurrentSubject()
    {
        WeatherData.RemoveObserver(this);
    }
}
