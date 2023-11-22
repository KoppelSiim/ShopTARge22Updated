using System.ComponentModel;

namespace ShopTARge22.Models.AccuWeatherForecast
{
    public class AccuWeatherViewModel
    {
        [DisplayName("City")]
        public string CityName { get; set; }
        [DisplayName("Temperature")]
        public double? Temperature { get; set; }
        [DisplayName("Temp Feels like")]
        public double TempFeelsLike { get; set; }
        [DisplayName("Humidity")]
        public int? Humidity { get; set; }
        [DisplayName("Pressure")]
        public double Pressure { get; set; }
        [DisplayName("Wind Speed")]
        public double WindSpeed { get; set; }
        [DisplayName("Weather Condition")]
        public string WeatherConditions { get; set; }
    }
}
