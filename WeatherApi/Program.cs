using WeatherApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient<IWeatherClient, WeatherApiClient>(client =>
{
    client.BaseAddress = new Uri("http://api.weatherapi.com/v1/");
});

var app = builder.Build();

// Get config items
IConfiguration configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", () => "Weather app entry point.");

app.MapGet("/realTime/{location}", async (string location, IWeatherClient weatherClient) =>
{
    return await weatherClient.GetRealTimeWeather(location);
});

// Redirects http requests to https
app.UseHttpsRedirection();

app.Run();
