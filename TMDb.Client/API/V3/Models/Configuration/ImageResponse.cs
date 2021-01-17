using Newtonsoft.Json;
using System;

namespace TMDb.Client.API.V3.Models.Configuration
{
    public class ImageResponse
    {
        [ApiParameter(
            Name = "images")]
        public ImageConfiguration Images { get; set; }

        [ApiParameter(
            Name = "change_keys")]
        public string[] ChangeKeys { get; set; }
    }

    public class ImageConfiguration
    {
        [ApiParameter(
            Name = "base_url")]
        public Uri BaseUrl { get; set; }

        [ApiParameter(
            Name = "secure_base_url")]
        public Uri SecureBaseUrl { get; set; }

        [ApiParameter(
            Name = "backdrop_sizes")]
        public string[] BackdropSizes { get; set; }

        [ApiParameter(
            Name = "logo_sizes")]
        public string[] LogoSizes { get; set; }

        [ApiParameter(
            Name = "poster_sizes")]
        public string[] PosterSizes { get; set; }

        [ApiParameter(
            Name = "profile_sizes")]
        public string[] ProfileSizes { get; set; }

        [ApiParameter(
            Name = "still_sizes")]
        public string[] StillSizes { get; set; }
    }
}