using Newtonsoft.Json;
using TMDb.Client.Entities.Things;

namespace TMDb.Client.Api.V3.Models.Account
{
    public class GetAccountDetailsResponse : TMDbResponse
    {
        [JsonProperty("include_adult")]
        public virtual bool? IncludeAdult { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("iso_3166_1")]
        public virtual string CountryCode { get; set; }

        [JsonProperty("iso_639_1")]
        public virtual string LanguageAbbreviation { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("username")]
        public virtual string Username { get; set; }

        [JsonProperty("avatar")]
        public virtual Avatar Avatar { get; set; }
    }
}