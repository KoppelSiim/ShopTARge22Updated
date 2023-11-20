using static ShopTARge22.Core.Dto.AccuWeatherDtos.AccuWeatherResponseRootDto;

namespace ShopTARge22.Core.Dto.AccuWeatherDtos
{
    public class AccuWeatherResponseDto
    {

        //Temperature.Metric.Value	double	Rounded value in specified units. May be NULL.
        //RealFeelTemperature	object	Patented AccuWeather RealFeel Temperature. Contains Metric and Imperial Values.
        //RelativeHumidity	int32	Relative humidity. May be NULL.
        //Pressure	object	Atmospheric pressure. Contains Metric and Imperial Values. metric mb! 
        //Wind.Speed	object	Wind Speed. Contains Metric and Imperial Values.
        //WeatherText	string	Phrase description of the current weather condition. Displayed in the language set with language code in URL.


        public double? Temp { get; set; }
        public double RealFeelTemp { get; set; }
        public int? RelativeHum { get; set; }
        public double PressureM { get; set; }
        public string WeatherText { get; set; }
        public double WindSpeed { get; set; }

    }
}

