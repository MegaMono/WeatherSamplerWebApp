using WeatherSamplerBlazorApp.Models;

namespace WeatherSamplerBlazorApp.Services
{
    internal class PlaceStorage
    {
        // Return a list of hard coded places.
        public static List<Place> GetPlaces()
        {
            return new List<Place>
            {
                // Default entry for the combo box.
                new Place{Name = "--Select a location--", Lat = 0, Lon = 0},
                new Place{Name = "Addis Ababa, Ethiopia", Lat = 9.0196, Lon = 38.7525},
                new Place{Name = "Antarctica", Lat = -90, Lon = 0},
                new Place{Name = "Aomori City, Japan", Lat = 40.8222, Lon = 140.7474},
                new Place{Name = "Attu Island, Alaska", Lat = 52.8763, Lon = 172.8905},
                new Place{Name = "Cape Disappointment, Washington", Lat = 46.2756, Lon = -124.0518},
                new Place{Name = "Cranston, Rhode Island", Lat = 41.7798, Lon = -71.4373},
                new Place{Name = "Easter Island, Chile", Lat = -27.1127, Lon = -109.3497},
                new Place{Name = "Grand Banks, Newfoundland", Lat = 45, Lon = -50},
                new Place{Name = "Greenland Ice Sheet Project 2", Lat = 72.5833, Lon = -38.4667},
                new Place{Name = "Hong Kong, China", Lat = 22.3027, Lon = 114.1772},
                new Place{Name = "Jakarta, Indonesia", Lat = -6.2000, Lon = 106.8167},
                new Place{Name = "Kamchatka Peninsula, Russia", Lat = 56, Lon = 159},
                new Place{Name = "Kathmandu Valley, Nepal", Lat = 27.7103, Lon = 85.3222},
                new Place{Name = "Lagos, Nigeria", Lat = 6.4654, Lon = 3.4064},
                new Place{Name = "Lake Maracaibo, Venezuela", Lat = 10.0278, Lon = -71.5769},
                new Place{Name = "Longyearbyen, Svalbard", Lat = 78.13, Lon = 15.38},
                new Place{Name = "London, United Kingdom", Lat = 51.5072, Lon = -0.1275},
                new Place{Name = "Swakopmund, Namibia", Lat = -22.6749, Lon = 14.5258},
                new Place{Name = "Marrakesh, Morocco", Lat = 31.6295, Lon = -7.9811},
                new Place{Name = "Mistake Island, Maine", Lat = 44.4747, Lon = -67.5351},
                new Place{Name = "Madurai, India", Lat = 9.9252, Lon = 78.1198},
                new Place{Name = "Mawsynram, India", Lat = 25.2973, Lon = 91.5827},
                new Place{Name = "Monteverde Cloud Forest, Costa Rica", Lat = 10.3000, Lon = -84.8167},
                new Place{Name = "Mount Baker, Washington", Lat = 48.7767, Lon = -121.8144},
                new Place{Name = "Mount Everest, Nepal", Lat = 27.9882, Lon = 86.9254},
                new Place{Name = "Moscow, Russia", Lat = 55.7558, Lon = 37.6173},
                new Place{Name = "Mountain View, Hawaii", Lat = 19.5558, Lon = -155.1081},
                new Place{Name = "New York, New York", Lat = 40.7128, Lon = -74.0060},
                new Place{Name = "North Pole", Lat = 90, Lon = 0},
                new Place{Name = "Palau, Koror", Lat = 7.34, Lon = 134.48},
                new Place{Name = "Perth, Australia", Lat = -31.9505, Lon = 115.8605},
                new Place{Name = "Ponta Delgada, Azores", Lat = 37.7394, Lon = -25.6687},
                new Place{Name = "Pushmataha County, Oklahoma", Lat = 34.4820, Lon = 95.3103},
                new Place{Name = "Reykjavik, Iceland", Lat = 64.1466, Lon = -21.9426},
                new Place{Name = "Samarkand, Uzbekistan", Lat = 39.6508, Lon = 66.9654},
                new Place{Name = "Santiago, Chile", Lat = -33.4489, Lon = -70.6693},
                new Place{Name = "South Pole", Lat = -90, Lon = 0},
                new Place{Name = "Sydney, Australia", Lat = -33.8651, Lon = 151.2099},
                new Place{Name = "Tehran, Iran", Lat = 35.7219, Lon = 51.3347},
                new Place{Name = "Titusville, Florida", Lat = 28.61, Lon = 80.82},
                new Place{Name = "Tutunendo, Columbia", Lat = 5.7446, Lon = 76.5400},
                new Place{Name = "Ulaanbaatar, Mongolia", Lat = 47.8864, Lon = 106.9057},
                new Place{Name = "Ushuaia, Argentina", Lat = -54.8019, Lon = -68.3030},
                new Place{Name = "Vancouver, Canada", Lat = 49.2463, Lon = -123.1162},
                new Place{Name = "Windhoek, Namibia", Lat = -22.5649, Lon = 17.0842},
                new Place{Name = "Yuma, Arizona", Lat = 32.6984, Lon = -114.6504}
            };
        }
    }
}
