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

       /* public static AccuWeatherResponseDto FromRoot(List<AccuWeatherResponseRootDto.Root> roots)
        {
            if (roots != null && roots.Count > 0)
            {
                var root = roots[0]; // Take the first element from the list
                Console.WriteLine(root.RealFeelTemperature.Metric.Value);
                return new AccuWeatherResponseDto
                {
                    Temp = root.Temperature.Metric.Value,
                    RealFeelTemp = root.RealFeelTemperature.Metric.Value,
                    RelativeHum = root.RelativeHumidity,
                    PressureM = root.Pressure.Metric.Value,
                    WeatherText = root.WeatherText,
                    WindSpeed = root.Wind.Speed.Metric.Value
                };
            }

            Console.WriteLine("Cannot get data from root");
            return null;
        }*/
    }
}

