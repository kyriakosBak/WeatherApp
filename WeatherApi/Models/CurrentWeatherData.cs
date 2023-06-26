namespace WeatherApi.Models;

public record CurrentWeatherData
{
    public long LastUpdatedEpoch { get; init; }
    public string LastUpdated { get; init; }
    public double TempC { get; init; }
    public double TempF { get; init; }
    public int IsDay { get; init; }
    public ConditionData Condition { get; init; }
    public double WindMph { get; init; }
    public double WindKph { get; init; }
    public int WindDegree { get; init; }
    public string WindDirection { get; init; }
    public double PressureMb { get; init; }
    public double PressureIn { get; init; }
    public double PrecipitationMm { get; init; }
    public double PrecipitationIn { get; init; }
    public int Humidity { get; init; }
    public int Cloud { get; init; }
    public double FeelsLikeC { get; init; }
    public double FeelsLikeF { get; init; }
    public double VisibilityKm { get; init; }
    public double VisibilityMiles { get; init; }
    public double UvIndex { get; init; }
    public double GustMph { get; init; }
    public double GustKph { get; init; }
}

public record ConditionData
{
    public string Text { get; init; }
    public string Icon { get; init; }
    public int Code { get; init; }
}