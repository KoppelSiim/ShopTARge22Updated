using ShopTARge22.Core.Dto.AccuWeatherDtos;

namespace ShopTARge22.Core.ServiceInterface
{
    public interface IAccuWeatherServices
    {
        //Task<string?> GetSubmittedCityKey(string city);
        //Task<string?> GetWeatherInfo(string cityKey);
        Task<AccuWeatherResponseRootDto> GetWeatherInfo(AccuWeatherResponseRootDto dto);
    }
}
