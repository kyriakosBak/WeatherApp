using WeatherApi.Models;

namespace WeatherApi;

public interface IWeatherClient
{
    Task<WeatherData> GetRealTimeWeather(string city);
}

public class WeatherApiClient : IWeatherClient
{
    private readonly HttpClient _httpClient;
    private readonly string apiKey = "";
    
    public WeatherApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<WeatherData> GetRealTimeWeather(string city)
    {
        return await _httpClient.GetFromJsonAsync<WeatherData>(
            $"current.json?key={apiKey}&q={city}&aqi=no");
    }
}