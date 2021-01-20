using Newtonsoft.Json;

namespace TMDb.Client.Entities.Media
{
    public class Image
    {
        [JsonProperty("aspect_ratio")]
        public virtual double? AspectRatio { get; set; }

        [JsonProperty("vote_average")]
        public virtual double? VoteAverage { get; set; }

        [JsonProperty("vote_count")]
        public virtual int VoteCount { get; set; }

        [JsonProperty("height")]
        public virtual int Height { get; set; }

        [JsonProperty("width")]
        public virtual int Width { get; set; }

        [JsonProperty("file_path")]
        public virtual string FilePath { get; set; }

        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [JsonProperty("iso_639_1")]
        public virtual string LanguageAbbreviation { get; set; }
    }
}