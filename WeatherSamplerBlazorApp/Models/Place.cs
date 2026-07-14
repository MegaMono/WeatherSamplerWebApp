namespace WeatherSamplerBlazorApp.Models
{
    public class Place
    {
        // Name of the location.
        public required string Name { get; set; }
        // Latitude coordinate.
        public double Lat { get; set; }
        // Longitude coordinate.
        public double Lon { get; set; }

        // This string override displays the name of the place in the ComboBox.
        public override string ToString()
        {
            return Name;
        }
    }
}
