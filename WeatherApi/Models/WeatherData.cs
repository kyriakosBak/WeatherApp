namespace WeatherApi.Models;

public record WeatherData
{
    public LocationData Location { get; init; }
    public CurrentWeatherData Current { get; init; }
}