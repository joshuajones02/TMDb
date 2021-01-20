using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.TV
{
    public class TVChangesResponse : TMDbResponse
    {
        [JsonProperty("changes")]
        public virtual IEnumerable<TVChangesResult> Changes { get; set; }
    }

    public class TVChangesResult
    {
        [JsonProperty("key")]
        public virtual string Key { get; set; }

        [JsonProperty("items")]
        public virtual List<TVChangesResultItem> Items { get; set; }
    }

    public class TVChangesResultItem
    {
        [JsonProperty("id")]
        public virtual string Id { get; set; }

        [JsonProperty("action")]
        public virtual Action Action { get; set; }

        [JsonProperty("time")]
        public virtual string Time { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public virtual ValueUnion? Value { get; set; }

        [JsonProperty("iso_639_1", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string Iso639_1 { get; set; }

        [JsonProperty("original_value", NullValueHandling = NullValueHandling.Ignore)]
        public virtual OriginalValueUnion? OriginalValue { get; set; }
    }

    public enum Action { Added, Deleted, Updated };

    public partial struct OriginalValueUnion
    {
        public OriginalValueClass OriginalValueClass;
        public string StringValue;

        public static implicit operator OriginalValueUnion(OriginalValueClass originalValueClass) => 
            new OriginalValueUnion 
            {
                OriginalValueClass = originalValueClass 
            };

        public static implicit operator OriginalValueUnion(string stringValue) => 
            new OriginalValueUnion 
            {
                StringValue = stringValue
            };
    }

    public partial struct ValueUnion
    {
        public string StringValue;
        public ValueClass ValueClass;

        public static implicit operator ValueUnion(string stringValue) => 
            new ValueUnion 
            { 
                StringValue = stringValue
            };

        public static implicit operator ValueUnion(ValueClass valueClass) => 
            new ValueUnion 
            { 
                ValueClass = valueClass 
            };
    }

    public class OriginalValueClass
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public virtual int? Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string Name { get; set; }

        [JsonProperty("credit_id", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string CreditId { get; set; }

        [JsonProperty("person_id", NullValueHandling = NullValueHandling.Ignore)]
        public virtual int? PersonId { get; set; }

        [JsonProperty("season_id", NullValueHandling = NullValueHandling.Ignore)]
        public virtual int? SeasonId { get; set; }

        [JsonProperty("poster", NullValueHandling = NullValueHandling.Ignore)]
        public virtual Poster Poster { get; set; }

        [JsonProperty("department", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string Department { get; set; }

        [JsonProperty("job", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string Job { get; set; }
    }

    public class Poster
    {
        [JsonProperty("file_path")]
        public virtual string FilePath { get; set; }

        [JsonProperty("iso_639_1")]
        public virtual string Iso639_1 { get; set; }
    }

    [Obsolete("// TODO: Refactor this to their own strongly typed classes https://developers.themoviedb.org/3/tv/get-tv-changes")]
    public class ValueClass
    {
        [JsonProperty("add_to_every_season", NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? AddToEverySeason { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public virtual int? Id { get; set; }

        [JsonProperty("season_id", NullValueHandling = NullValueHandling.Ignore)]
        public virtual int? SeasonId { get; set; }

        [JsonProperty("season_number", NullValueHandling = NullValueHandling.Ignore)]
        public virtual int? SeasonNumber { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string Name { get; set; }

        [JsonProperty("character", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string Character { get; set; }

        [JsonProperty("credit_id", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string CreditId { get; set; }

        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public virtual int? Order { get; set; }

        [JsonProperty("person_id", NullValueHandling = NullValueHandling.Ignore)]
        public virtual int? PersonId { get; set; }

        [JsonProperty("poster", NullValueHandling = NullValueHandling.Ignore)]
        public virtual Poster Poster { get; set; }

        [JsonProperty("department", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string Department { get; set; }

        [JsonProperty("job", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string Job { get; set; }
    }
}