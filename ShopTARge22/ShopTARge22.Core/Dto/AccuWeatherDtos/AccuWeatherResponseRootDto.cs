using System.Text.Json.Serialization;

namespace ShopTARge22.Core.Dto.AccuWeatherDtos
{
    public class AccuWeatherResponseRootDto
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
        public class ApparentTemperature
        {
            public Metric Metric { get; set; }
        }

        public class Ceiling
        {
            public Metric Metric { get; set; }
        }

        public class DewPoint
        {
            public Metric Metric { get; set; }
        }

        public class Direction
        {
            public int Degrees { get; set; }
            public string Localized { get; set; }
            public string English { get; set; }
        }

        public class Metric
        {
            public double Value { get; set; }
            public string Unit { get; set; }
            public int UnitType { get; set; }
            public string Phrase { get; set; }
        }

        public class Pressure
        {
            public Metric Metric { get; set; }
        }

        public class PressureTendency
        {
            public string LocalizedText { get; set; }
            public string Code { get; set; }
        }

        public class RealFeelTemperature
        {
            public Metric Metric { get; set; }
        }

        public class RealFeelTemperatureShade
        {
            public Metric Metric { get; set; }
        }

       public class Root
       {
            public string WeatherText { get; set; }
            public Temperature Temperature { get; set; }
            public RealFeelTemperature RealFeelTemperature { get; set; }
            public RealFeelTemperatureShade RealFeelTemperatureShade { get; set; }
            public int RelativeHumidity { get; set; }
            public Wind Wind { get; set; }
            public Pressure Pressure { get; set; }
            public ApparentTemperature ApparentTemperature { get; set; }
        }
       
        public class Speed
        {
            public Metric Metric { get; set; }
        }

        public class Temperature
        {
            public Metric Metric { get; set; }
        }

        public class Visibility
        {
            public Metric Metric { get; set; }
        }

        public class WetBulbTemperature
        {
            public Metric Metric { get; set; }
        }

        public class Wind
        {
            public Direction Direction { get; set; }
            public Speed Speed { get; set; }
        }

        public class WindChillTemperature
        {
            public Metric Metric { get; set; }
        }

        public class WindGust
        {
            public Speed Speed { get; set; }
        }

    }
}
