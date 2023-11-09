using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ShopTARge22.Core.Dto.CoctailsDtos
{
    // Root tuleb sisse
    public class CoctailRootDto
    {
        [JsonProperty("drinks")]
        public Drink Drink { get; set; }
    }

    public class Drink
    {
        [JsonProperty("idDrink")]
        [JsonPropertyName("idDrink")]
        public string IdDrink { get; set; }

        [JsonProperty("strDrink")]
        [JsonPropertyName("strDrink")]
        public string StrDrink { get; set; }

        [JsonProperty("strDrinkAlternate")]
        [JsonPropertyName("strDrinkAlternate")]
        public string StrDrinkAlternate { get; set; }

        [JsonProperty("strTags")]
        [JsonPropertyName("strTags")]
        public string StrTags { get; set; }

        [JsonProperty("strVideo")]
        [JsonPropertyName("strVideo")]
        public string StrVideo { get; set; }

        [JsonProperty("strCategory")]
        [JsonPropertyName("strCategory")]
        public string StrCategory { get; set; }

        [JsonProperty("strIBA")]
        [JsonPropertyName("strIBA")]
        public string StrIBA { get; set; }

        [JsonProperty("strAlcoholic")]
        [JsonPropertyName("strAlcoholic")]
        public string StrAlcoholic { get; set; }

        [JsonProperty("strGlass")]
        [JsonPropertyName("strGlass")]
        public string StrGlass { get; set; }

        [JsonProperty("strInstructions")]
        [JsonPropertyName("strInstructions")]
        public string StrInstructions { get; set; }

        [JsonProperty("strInstructionsES")]
        [JsonPropertyName("strInstructionsES")]
        public string StrInstructionsES { get; set; }

        [JsonProperty("strInstructionsDE")]
        [JsonPropertyName("strInstructionsDE")]
        public string StrInstructionsDE { get; set; }

        [JsonProperty("strInstructionsFR")]
        [JsonPropertyName("strInstructionsFR")]
        public string StrInstructionsFR { get; set; }

        [JsonProperty("strInstructionsIT")]
        [JsonPropertyName("strInstructionsIT")]
        public string StrInstructionsIT { get; set; }

        [JsonProperty("strInstructionsZH-HANS")]
        [JsonPropertyName("strInstructionsZH-HANS")]
        public string StrInstructionsZHHANS { get; set; }

        [JsonProperty("strInstructionsZH-HANT")]
        [JsonPropertyName("strInstructionsZH-HANT")]
        public string StrInstructionsZHHANT { get; set; }

        [JsonProperty("strDrinkThumb")]
        [JsonPropertyName("strDrinkThumb")]
        public string StrDrinkThumb { get; set; }

        [JsonProperty("strIngredient1")]
        [JsonPropertyName("strIngredient1")]
        public string StrIngredient1 { get; set; }

        [JsonProperty("strIngredient2")]
        [JsonPropertyName("strIngredient2")]
        public string StrIngredient2 { get; set; }

        [JsonProperty("strIngredient3")]
        [JsonPropertyName("strIngredient3")]
        public string StrIngredient3 { get; set; }

        [JsonProperty("strIngredient4")]
        [JsonPropertyName("strIngredient4")]
        public string StrIngredient4 { get; set; }

        [JsonProperty("strIngredient5")]
        [JsonPropertyName("strIngredient5")]
        public string StrIngredient5 { get; set; }

        [JsonProperty("strIngredient6")]
        [JsonPropertyName("strIngredient6")]
        public string StrIngredient6 { get; set; }

        [JsonProperty("strIngredient7")]
        [JsonPropertyName("strIngredient7")]
        public string StrIngredient7 { get; set; }

        [JsonProperty("strIngredient8")]
        [JsonPropertyName("strIngredient8")]
        public string StrIngredient8 { get; set; }

        [JsonProperty("strIngredient9")]
        [JsonPropertyName("strIngredient9")]
        public string StrIngredient9 { get; set; }

        [JsonProperty("strIngredient10")]
        [JsonPropertyName("strIngredient10")]
        public string StrIngredient10 { get; set; }

        [JsonProperty("strIngredient11")]
        [JsonPropertyName("strIngredient11")]
        public string StrIngredient11 { get; set; }

        [JsonProperty("strIngredient12")]
        [JsonPropertyName("strIngredient12")]
        public string StrIngredient12 { get; set; }

        [JsonProperty("strIngredient13")]
        [JsonPropertyName("strIngredient13")]
        public string StrIngredient13 { get; set; }

        [JsonProperty("strIngredient14")]
        [JsonPropertyName("strIngredient14")]
        public string StrIngredient14 { get; set; }

        [JsonProperty("strIngredient15")]
        [JsonPropertyName("strIngredient15")]
        public string StrIngredient15 { get; set; }

        [JsonProperty("strMeasure1")]
        [JsonPropertyName("strMeasure1")]
        public string StrMeasure1 { get; set; }

        [JsonProperty("strMeasure2")]
        [JsonPropertyName("strMeasure2")]
        public string StrMeasure2 { get; set; }

        [JsonProperty("strMeasure3")]
        [JsonPropertyName("strMeasure3")]
        public string StrMeasure3 { get; set; }

        [JsonProperty("strMeasure4")]
        [JsonPropertyName("strMeasure4")]
        public string StrMeasure4 { get; set; }

        [JsonProperty("strMeasure5")]
        [JsonPropertyName("strMeasure5")]
        public string StrMeasure5 { get; set; }

        [JsonProperty("strMeasure6")]
        [JsonPropertyName("strMeasure6")]
        public string StrMeasure6 { get; set; }

        [JsonProperty("strMeasure7")]
        [JsonPropertyName("strMeasure7")]
        public string StrMeasure7 { get; set; }

        [JsonProperty("strMeasure8")]
        [JsonPropertyName("strMeasure8")]
        public string StrMeasure8 { get; set; }

        [JsonProperty("strMeasure9")]
        [JsonPropertyName("strMeasure9")]
        public string StrMeasure9 { get; set; }

        [JsonProperty("strMeasure10")]
        [JsonPropertyName("strMeasure10")]
        public string StrMeasure10 { get; set; }

        [JsonProperty("strMeasure11")]
        [JsonPropertyName("strMeasure11")]
        public string StrMeasure11 { get; set; }

        [JsonProperty("strMeasure12")]
        [JsonPropertyName("strMeasure12")]
        public string StrMeasure12 { get; set; }

        [JsonProperty("strMeasure13")]
        [JsonPropertyName("strMeasure13")]
        public string StrMeasure13 { get; set; }

        [JsonProperty("strMeasure14")]
        [JsonPropertyName("strMeasure14")]
        public string StrMeasure14 { get; set; }

        [JsonProperty("strMeasure15")]
        [JsonPropertyName("strMeasure15")]
        public string StrMeasure15 { get; set; }

        [JsonProperty("strImageSource")]
        [JsonPropertyName("strImageSource")]
        public string StrImageSource { get; set; }

        [JsonProperty("strImageAttribution")]
        [JsonPropertyName("strImageAttribution")]
        public string StrImageAttribution { get; set; }

        [JsonProperty("strCreativeCommonsConfirmed")]
        [JsonPropertyName("strCreativeCommonsConfirmed")]
        public string StrCreativeCommonsConfirmed { get; set; }

        [JsonProperty("dateModified")]
        [JsonPropertyName("dateModified")]
        public string DateModified { get; set; }
    }
}
