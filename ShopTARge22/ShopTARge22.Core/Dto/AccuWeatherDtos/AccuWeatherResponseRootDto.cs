using System.Text.Json.Serialization;

namespace ShopTARge22.Core.Dto.AccuWeatherDtos
{
    public class AccuWeatherResponseRootDto
    {

        public string WeatherText { get; set; }
        public TemperatureInfo Temperature { get; set; }
        public RealFeelTemperatureInfo RealFeelTemperature { get; set; }
        public int RelativeHumidity { get; set; }
        public WindInfo Wind { get; set; }
        public PressureInfo Pressure { get; set; }

        public class TemperatureInfo
        {
            public Metric Metric { get; set; }
        }

        public class RealFeelTemperatureInfo
        {
            public Metric Metric { get; set; }
        }

        public class Metric
        {
            public double Value { get; set; }
        }

        public class WindInfo
        {
            public WindSpeedInfo Speed { get; set; }

            public class WindSpeedInfo
            {
                public Metric Metric { get; set; }
            }
        }

        public class PressureInfo
        {
            public Metric Metric { get; set; }
        }
    }
}
