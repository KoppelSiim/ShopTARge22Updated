using ShopTARge22.Core.ServiceInterface;
using Nancy.Json;
using ShopTARge22.Core.Dto.AccuWeatherDtos;
using System.Net;

namespace ShopTARge22.ApplicationServices.Services
{
    public class AccuWeatherServices : IAccuWeatherServices
    {

        private readonly string apiKey = "myApiKey";
        public async Task<AccuWeatherResponseRootDto> GetWeatherInfo(AccuWeatherResponseRootDto dto)
        {
            string resourceUrl = "http://dataservice.accuweather.com/currentconditions/v1/";
            string apiCallUrl = $"{resourceUrl}{dto.City}?apikey={apiKey}&details=true";
            using (WebClient client = new())
            {
                string json = client.DownloadString(apiCallUrl);
                Console.WriteLine(json);
            }
                return dto;
        }
        
    }
}
