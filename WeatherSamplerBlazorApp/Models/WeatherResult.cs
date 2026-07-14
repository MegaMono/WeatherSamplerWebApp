using System.Globalization;

namespace WeatherSamplerBlazorApp.Models
{
    public class WeatherResult
    {
        /*
         * This method extracts the weather icon code from the JSON result
         * passed in from the API call.
         */
        public string GetIcon(string jsonResult)
        {
            // Find the "icon" key.
            string iconKey = "\"icon\":\"";

            // Find the index where 'icon' appears in the JSON result.
            int iconIndex = jsonResult.IndexOf(iconKey);

            // Calculate the start of the icon value after the key.
            int iconValueStart = iconIndex + iconKey.Length;

            // Find the ending '"' that closes the icon value.
            int iconValueEnd = jsonResult.IndexOf("\"", iconValueStart);

            // Extract and return the icon substring.
            return jsonResult.Substring(iconValueStart, iconValueEnd - iconValueStart).Trim();
        }
        public string GetActualTemp(string jsonResult)
        {
            // Find "temp" key 
            string actualTempKey = "\"temp\":";

            // Find the index where the key appears in the JSON.
            int actualTempIndex = jsonResult.IndexOf(actualTempKey);

            // Calculate the start of the temp value that begins just after the key.
            int valueStart = actualTempIndex + actualTempKey.Length;

            // The closing character at the end of the temp value is a comma.                
            int valueEnd = jsonResult.IndexOf(",", valueStart);

            // Temp values are returned in kelvin.
            string kelvinStringValue = jsonResult.Substring(valueStart, valueEnd - valueStart).Trim();

            // Kelvin values are sent to the Fahrenheit conversion method.
            return KelvinToFahrenheit(kelvinStringValue);
        }

        /*
        * Get Feels Like Temp
        */
        public string GetFeelsLikeTemp(string jsonResult)
        {
            // Define the key found in the JSON result.
            string key = "\"feels_like\":";

            // Find the index of where the key appears.
            int index = jsonResult.IndexOf(key);

            // Calculate where the value starts after the key by adding the length of the key to the index.
            int valueStart = index + key.Length;

            // Feels Like JSON values end in a comma.
            int valueEnd = jsonResult.IndexOf(",", valueStart);

            // Feels like values are returned in kelvin.
            string kelvinStringValue = jsonResult.Substring(valueStart, valueEnd - valueStart).Trim();

            //Kelvin values are sent to the Fahrenheit conversion method.
            return KelvinToFahrenheit(kelvinStringValue);  
        }

        public string GetHumidity(string jsonResult)
        {
            // Find the key for "humidity"
            string humidityKey = "\"humidity\":";

            // Find the index where the icon appears.
            int humidityIndex = jsonResult.IndexOf(humidityKey);

            // The "humidity" value begins where the key ends.
            int valueStart = humidityIndex + humidityKey.Length;

            // The "humidity" value ends with a comma.
            int valueEnd = jsonResult.IndexOf(',', valueStart);

            // Return the associated humidity value.
            return jsonResult.Substring(valueStart, valueEnd - valueStart).Trim();
        }

        /*
         * This method converts Kelvin values to Fahrenheit.
         */
        public string KelvinToFahrenheit(string kelvinStringValue)
        {
            // Kelvin values are passed in from the JSON temperature methods.
            // InvariantCulture provides that data will be properly parsed regardless of 
            // decimal/comma separators.
            double kelvin = double.Parse(kelvinStringValue, CultureInfo.InvariantCulture);

            // Temperature conversion formula.
            double fahrenheit = (kelvin - 273.15) * 1.8 + 32;

            // Single decimal precision is close enough for temp.
            // InvariantCulture ensures that the proper decimal separator will be shown to the user.
            return fahrenheit.ToString("F1", CultureInfo.InvariantCulture);
        }
    }
}
