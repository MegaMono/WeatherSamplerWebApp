using WeatherSamplerBlazorApp.Models;
using WeatherSamplerBlazorApp.Services;

public class WeatherProcessor
{
    private readonly WeatherResult _weatherResult = new();
    private readonly WeatherMedia _media = new();

    public WeatherDisplayInfo Process(string json)
    {
        string icon = _weatherResult.GetIcon(json);

        return new WeatherDisplayInfo
        {
            WeatherLabel = $"Weather condition: {_media.GetConditionLabel(icon)}",
            TempLabel = $"Actual temperature: {_weatherResult.GetActualTemp(json)}°F",
            FeelsLikeLabel = $"Feels like temperature: {_weatherResult.GetFeelsLikeTemp(json)}°F",
            HumidityLabel = $"Humidity: {_weatherResult.GetHumidity(json)}%",
            ImagePath = _media.GetImagePath(icon),
            SoundPath = _media.GetSoundPath(icon)
        };
    }
}

public class WeatherDisplayInfo
{
    public string WeatherLabel { get; set; } = "";
    public string TempLabel { get; set; } = "";
    public string FeelsLikeLabel { get; set; } = "";
    public string HumidityLabel { get; set; } = "";
    public string ImagePath { get; set; } = "";
    public string SoundPath { get; set; } = "";
}
