// See https://aka.ms/new-console-template for more information
public class WeatherData : ISubject
{
    public List<IObserver> Observers = new();
    public float Temperature { get; set; } = 0;
    public float Humidity { get; set; } = 0;
    public float Pressure { get; set; } = 0;
    public WeatherData()
    {

    }

    public void SetMeasurements(float temp, float humidity, float pressure)
    {
        Temperature = temp;
        Humidity = humidity;
        Pressure = pressure;
        MeasurementsChanged();
    }

    public void MeasurementsChanged()
    {
        NotifyObservers();
    }

    public void RegisterObserver(IObserver observer)
    {
        Observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        Observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach(var obs in Observers)
        {
            obs.Update();
        }
    }
}
