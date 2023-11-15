using ShopTARge22.Core.ServiceInterface;
using Newtonsoft.Json;

namespace ShopTARge22.ApplicationServices.Services
{
    public class AccuWeatherServices : IAccuWeatherServices
    {

        private readonly string apiKey = "myapikey";
        public async Task<string?> GetSubmittedCityKey(string city)
        {
           
            string resourceUrl = "http://dataservice.accuweather.com/locations/v1/cities/search";
            string apiCallUrl = $"{resourceUrl}?apikey={apiKey}&q={city}";
          
            using (HttpClient client = new())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiCallUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        
                        string responseBody = await response.Content.ReadAsStringAsync();
                        var cityInfoList = ParseJsonResponse(responseBody);

                        if (cityInfoList.Count > 0)
                        {
                            string cityKey = cityInfoList[0]["Key"].ToString();
                            Console.WriteLine($"Key: {cityKey}");
                            return cityKey;
                        }
                        else
                        {
                            Console.WriteLine("City key not found in the response.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                }
            }
            return null;
        }
        // Method to parse JSON response using Newtonsoft.Json
        private List<Dictionary<string, object>> ParseJsonResponse(string responseBody)
        {
            // Deserialize to a list of dictionaries
            return JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(responseBody);
        }
    }
}
