using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.Models.Proxies.TVSeasons
{
    public class TVSeasonsImagesResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("posters")]
        public virtual IEnumerable<Image> Posters { get; set; }
    }

    public class Image
    {
        [JsonProperty("aspect_ratio")]
        public virtual double AspectRatio { get; set; }

        [JsonProperty("vote_average")]
        public virtual double VoteAverage { get; set; }

        [JsonProperty("vote_count")]
        public virtual int VoteCount { get; set; }

        [JsonProperty("height")]
        public virtual int Height { get; set; }

        [JsonProperty("width")]
        public virtual int Width { get; set; }

        [JsonProperty("file_path")]
        public virtual string FilePath { get; set; }

        [JsonProperty("iso_639_1")]
        public virtual string Language { get; set; }
    }
}