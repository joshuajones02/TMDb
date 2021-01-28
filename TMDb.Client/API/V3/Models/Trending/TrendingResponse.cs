using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TMDb.Client.Enums;

namespace TMDb.Client.Api.V3.Models.Trending
{
    public class TrendingResponse : TMDbCollectionResponse<TrendingResultItem>
    {
    }

    [Obsolete("This object is a temporary replacement until Union JsonConverter logic has been completed correctly, needs a rewrite.")]
    public class TrendingResultItem
    {
        [JsonProperty("adult", NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? Adult { get; set; }

        [JsonProperty("video", NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? Video { get; set; }

        [JsonProperty("popularity")]
        public virtual double? Popularity { get; set; }

        [JsonProperty("vote_average", NullValueHandling = NullValueHandling.Ignore)]
        public virtual double? VoteAverage { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("vote_count", NullValueHandling = NullValueHandling.Ignore)]
        public virtual int? VoteCount { get; set; }

        [JsonProperty("backdrop_path", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string BackdropPath { get; set; }

        [JsonProperty("original_language", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string OriginalLanguage { get; set; }

        [JsonProperty("original_title", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string OriginalTitle { get; set; }

        [JsonProperty("overview", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string Overview { get; set; }

        [JsonProperty("poster_path", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string PosterPath { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string Title { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string Name { get; set; }

        [JsonProperty("original_name", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string OriginalName { get; set; }

        [JsonProperty("profile_path")]
        public virtual string ProfilePath { get; set; }

        [JsonProperty("known_for_department", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string KnownForDepartment { get; set; }

        [JsonProperty("release_date", NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? ReleaseDate { get; set; }

        [JsonProperty("first_air_date", NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FirstAirDate { get; set; }

        [JsonProperty("gender", NullValueHandling = NullValueHandling.Ignore)]
        public virtual Gender? Gender { get; set; }

        [JsonProperty("media_type")]
        public virtual MediaType MediaType { get; set; }

        [JsonProperty("genre_ids", NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<int> GenreIds { get; set; }

        [JsonProperty("origin_country", NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<string> OriginCountry { get; set; }

        [JsonProperty("known_for", NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<TrendingMovie> KnownFor { get; set; }
    }
}