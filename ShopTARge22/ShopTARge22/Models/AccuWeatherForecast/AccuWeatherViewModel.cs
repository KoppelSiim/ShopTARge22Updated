namespace ShopTARge22.Models.AccuWeatherForecast
{
    public class AccuWeatherViewModel
    {
        public string CityName { get; set; }
        public double? Temp { get; set; }
        public double RealFeelTemp { get; set; }
        public int? RelativeHum { get; set; }
        public double PressureM { get; set; }
        public double WindSpeed { get; set; }
        public string WeatherText { get; set; }
    }
}
