using Newtonsoft.Json;
using System;

namespace TMDb.Client.API.V3.Models.Configuration
{
    public class ConfigurationResponse : TMDbResponse
    {
        [JsonProperty("images")]
        public virtual ImageConfiguration Images { get; set; }

        [JsonProperty("change_keys")]
        public virtual string[] ChangeKeys { get; set; }
    }

    public class ImageConfiguration
    {
        [JsonProperty("base_url")]
        public virtual Uri BaseUrl { get; set; }

        [JsonProperty("secure_base_url")]
        public virtual Uri SecureBaseUrl { get; set; }

        [JsonProperty("backdrop_sizes")]
        public virtual string[] BackdropSizes { get; set; }

        [JsonProperty("logo_sizes")]
        public virtual string[] LogoSizes { get; set; }

        [JsonProperty("poster_sizes")]
        public virtual string[] PosterSizes { get; set; }

        [JsonProperty("profile_sizes")]
        public virtual string[] ProfileSizes { get; set; }

        [JsonProperty("still_sizes")]
        public virtual string[] StillSizes { get; set; }
    }
}