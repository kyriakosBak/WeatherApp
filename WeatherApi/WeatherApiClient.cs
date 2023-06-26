using WeatherApi.Models;

namespace WeatherApi;

public interface IWeatherClient
{
    Task<WeatherData?> GetRealTimeWeather(string city);
}

public class WeatherApiClient : IWeatherClient
{
    private readonly HttpClient _httpClient;
    private readonly string? _apiKey;
    
    public WeatherApiClient(HttpClient httpClient, IConfiguration config)
    {
        _httpClient = httpClient;
        _apiKey = config.GetValue<string>("WeatherApi:ApiKey");
    }

    public async Task<WeatherData?> GetRealTimeWeather(string city)
    {
        return await _httpClient.GetFromJsonAsync<WeatherData>(
            $"current.json?key={_apiKey}&q={city}&aqi=no");
    }
}