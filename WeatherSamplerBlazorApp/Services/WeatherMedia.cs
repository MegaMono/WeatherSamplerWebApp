namespace WeatherSamplerBlazorApp.Services
{
    /*
    * WeatherMedia manages the media assets.
    */
    internal class WeatherMedia
    {
        /*
         * GetImagePath returns the file path of the gif image 
         * based on the icon code passed in from main form.
         */
        public string GetImagePath(string gifPath)
        {
            // This switch statement maps the icon codes returned from the API call to 
            // animated gif images.
            switch (gifPath)
            {
                // I have chosen to map both day and night icon codes to the same gif.
                // In further implementation I would create a light and dark mode for each,
                // but I felt this was suitable.
                case "01d":
                case "01n":
                    return "gifs/01ClearSky.gif";
                case "02d":
                case "02n":
                    return "gifs/02FewClouds.gif";
                case "03d":
                case "03n":
                    return "gifs/03ScatteredClouds.gif";
                case "04d":
                case "04n":
                    return "gifs/04BrokenClouds.gif";
                case "09d":
                case "09n":
                    return "gifs/09ShowerRain.gif";
                case "10d":
                case "10n":
                    return "gifs/10Rain.gif";
                case "11d":
                case "11n":
                    return "gifs/11Thunderstorm.gif";
                case "13d":
                case "13n":
                    return "gifs/12Snow.gif";
                case "50d":
                case "50n":
                    return "gifs/50Mist.gif";
                default: return "gifs/DefaultNoImage.png";
            }
        }
        /*
         * GetSoundPath returns the audio path depending on what the
         * API JSON result is.
         */
        public string GetSoundPath(string audioPath)
        {
            // This switch statement maps the icon codes returned from the API call to 
            // synthesized audio interpretations of weather atmosphere.
            switch (audioPath)
            {
                case "01d":
                case "01n":
                    return "audio/1-clear-sky.wav";
                case "02d":
                case "02n":
                    return "audio/2-few-clouds.wav";
                case "03d":
                case "03n":
                    return "audio/3-scattered-clouds.wav";
                case "04d":
                case "04n":
                    return "audio/4-broken-clouds.wav";
                case "09d":
                case "09n":
                    return "audio/9-shower-rain.wav";
                case "10d":
                case "10n":
                    return "audio/10-rain.wav";
                case "11d":
                case "11n":
                    return "audio/11-thunderstorm.wav";
                case "13d":
                case "13n":
                    return "audio/13-snow.wav";
                case "50d":
                case "50n":
                    return "audio/50-mist.wav";
                default: return "audio/testTone.wav";
            }
        }
        /*
         * GetConditionLabel returns the weather condition label depending on what the
         * API JSON result is.
         */
        public string GetConditionLabel(string labelPath)
        {
            // This switch statement maps the API icon code results to a text label
            // to display what the theme of the weather condition is.
            switch (labelPath)
            {
                case "01d":
                case "01n":
                    return "Clear Skies";
                case "02d":
                case "02n":
                    return "Few Clouds";
                case "03d":
                case "03n":
                    return "Scattered Clouds";
                case "04d":
                case "04n":
                    return "Broken Clouds";
                case "09d":
                case "09n":
                    return "Shower Rain";
                case "10d":
                case "10n":
                    return "Rain";
                case "11d":
                case "11n":
                    return "Thunderstorm";
                case "13d":
                case "13n":
                    return "Snow";
                case "50d":
                case "50n":
                    return "Mist";
                default: return "Sounds/testTone.wav";
            }
        }
    }
}
