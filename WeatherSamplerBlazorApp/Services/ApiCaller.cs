namespace WeatherSamplerBlazorApp.Services
{
    /*
     * ApiCaller is a class that makes HTTP requests.
     */
    public class ApiCaller
    {
        // Private class used for HTTP requests.
        private readonly HttpClient httpClient;

        private const string ApiKey = "a1795063ef15befbc50c1823bb36176e";

        // Initializes HTTPClient.
        public ApiCaller(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        /*
         * Fetch data from specified URL
         * It is sent URL openweathermap.org and returns its response as a string.
         */
        public async Task<string> GetDataAsync(string url)
        {

          // Sends URL request.
          HttpResponseMessage response = await httpClient.GetAsync(url);

          //Throw HTTPException if request is not successful. 
          response.EnsureSuccessStatusCode();

          // Return response as a string value.
          return await response.Content.ReadAsStringAsync();
        }

        // Get weather
        public async Task<string> GetWeatherAsync(double lat, double lon)
        { 
            string url =
                  $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={ApiKey}";

            return await GetDataAsync(url);
        }
    }
}
