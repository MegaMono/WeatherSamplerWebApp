namespace WeatherSamplerBlazorApp.Services
{
    public class WeatherState
    {
        // Holds the latest JSON from the API
        public string JsonResult { get; private set; } = "";

        // Event triggered when JSON changes
        public event Action? OnChange;

        // Call this to update the JSON and notify subscribers
        public void SetJson(string json)
        {
            JsonResult = json;
            OnChange?.Invoke();
        }
    }
}
