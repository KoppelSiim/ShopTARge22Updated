namespace ShopTARge22.Models.AccuWeatherForecast
{
    public class AccuWeatherViewModel
    {
        public string CityName { get; set; }
        public double? Temperature { get; set; }
        public double TempFeelsLike { get; set; }
        public int? Humidity { get; set; }
        public double Pressure { get; set; }
        public double WindSpeed { get; set; }
        public string WeatherConditions { get; set; }
    }
}
