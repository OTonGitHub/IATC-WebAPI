using Microsoft.AspNetCore.Mvc;

namespace S5L2_Sandbox.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IConfiguration _config;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IConfiguration config)
    {
        _logger = logger;
        this._config = config;
    }

    [HttpGet("GetConnectionString")]
    public string GetConnectionString()
    {
        return _config.GetConnectionString("DefaultConnectionString") ?? "Section or Default Connection String Not Found";
    }

    [HttpGet(Name = "GetWeatherForecast")] /* Name is used for the RouteLink in the Razor Page - Not Actual Route Name */
    public IEnumerable<WeatherForecast> ForecastsCheck()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
