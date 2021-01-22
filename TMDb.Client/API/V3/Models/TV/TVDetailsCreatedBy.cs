using Newtonsoft.Json;

namespace TMDb.Client.Api.V3.Models.TV
{
    public class TVDetailsCreatedBy
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("credit_id")]
        public virtual string CreditId { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("gender")]
        public virtual int Gender { get; set; }

        [JsonProperty("profile_path")]
        public virtual string ProfilePath { get; set; }
    }

    //public partial class Genre
    //{
    //    [JsonProperty("id")]
    //    public int Id { get; set; }

    //    [JsonProperty("name")]
    //    public string Name { get; set; }
    //}

    //public partial class LastEpisodeToAir
    //{
    //    [JsonProperty("air_date")]
    //    public DateTime? AirDate { get; set; }

    //    [JsonProperty("episode_number")]
    //    public int EpisodeNumber { get; set; }

    //    [JsonProperty("id")]
    //    public int Id { get; set; }

    //    [JsonProperty("name")]
    //    public string Name { get; set; }

    //    [JsonProperty("overview")]
    //    public string Overview { get; set; }

    //    [JsonProperty("production_code")]
    //    [JsonConverter(typeof(ParseStringConverter))]
    //    public int ProductionCode { get; set; }

    //    [JsonProperty("season_number")]
    //    public int SeasonNumber { get; set; }

    //    [JsonProperty("still_path")]
    //    public string StillPath { get; set; }

    //    [JsonProperty("vote_average")]
    //    public double VoteAverage { get; set; }

    //    [JsonProperty("vote_count")]
    //    public int VoteCount { get; set; }
    //}

    //public partial class Network
    //{
    //    [JsonProperty("name")]
    //    public string Name { get; set; }

    //    [JsonProperty("id")]
    //    public int Id { get; set; }

    //    [JsonProperty("logo_path")]
    //    public string LogoPath { get; set; }

    //    [JsonProperty("origin_country")]
    //    public string OriginCountry { get; set; }
    //}

    //public partial class ProductionCountry
    //{
    //    [JsonProperty("iso_3166_1")]
    //    public string Iso3166_1 { get; set; }

    //    [JsonProperty("name")]
    //    public string Name { get; set; }
    //}

    //public class Season
    //{
    //    [JsonProperty("air_date")]
    //    public DateTime? AirDate { get; set; }

    //    [JsonProperty("episode_count")]
    //    public int EpisodeCount { get; set; }

    //    [JsonProperty("id")]
    //    public int Id { get; set; }

    //    [JsonProperty("name")]
    //    public string Name { get; set; }

    //    [JsonProperty("overview")]
    //    public string Overview { get; set; }

    //    [JsonProperty("poster_path")]
    //    public string PosterPath { get; set; }

    //    [JsonProperty("season_number")]
    //    public int SeasonNumber { get; set; }
    //}

    //public class SpokenLanguage
    //{
    //    [JsonProperty("english_name")]
    //    public string EnglishName { get; set; }

    //    [JsonProperty("iso_639_1")]
    //    public string Iso639_1 { get; set; }

    //    [JsonProperty("name")]
    //    public string Name { get; set; }
    //}
}