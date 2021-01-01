using Newtonsoft.Json;
using System;

namespace TMDb.Client.Models.Configuration
{
    public class ImageResponse
    {
        [JsonProperty("images")]
        public ImageConfiguration Images { get; set; }

        [JsonProperty("change_keys")]
        public string[] ChangeKeys { get; set; }
    }

    public class ImageConfiguration
    {
        [JsonProperty("base_url")]
        public Uri BaseUrl { get; set; }

        [JsonProperty("secure_base_url")]
        public Uri SecureBaseUrl { get; set; }

        [JsonProperty("backdrop_sizes")]
        public string[] BackdropSizes { get; set; }

        [JsonProperty("logo_sizes")]
        public string[] LogoSizes { get; set; }

        [JsonProperty("poster_sizes")]
        public string[] PosterSizes { get; set; }

        [JsonProperty("profile_sizes")]
        public string[] ProfileSizes { get; set; }

        [JsonProperty("still_sizes")]
        public string[] StillSizes { get; set; }
    }
}