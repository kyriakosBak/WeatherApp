namespace WeatherApi.Models;

public record LocationData
{
    public string Name { get; init; }
    public string Region { get; init; }
    public string Country { get; init; }
    public double Lat { get; init; }
    public double Lon { get; init; }
    public string TimeZoneId { get; init; }
    public long LocalTimeEpoch { get; init; }
    public string LocalTime { get; init; }
}