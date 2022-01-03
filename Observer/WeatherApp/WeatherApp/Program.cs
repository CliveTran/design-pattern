var weatherData = new WeatherData();
var current = new CurrentConditionDisplay(weatherData);
var stat = new StatisticsDisplay(weatherData);
var forecast = new ForecastDisplay(weatherData);

Console.WriteLine($"Number of Observers: {weatherData.Observers.Count()}");

weatherData.SetMeasurements(30, 40, 50);

current.UnsubscribeFromCurrentSubject();
Console.WriteLine($"Number of Observers: {weatherData.Observers.Count()}");

weatherData.SetMeasurements(20, 30, 40);