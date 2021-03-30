using Newtonsoft.Json;

namespace TMDb.Client.Entities.People
{
    public class TVEpisodesGuestStar
    {
        [JsonProperty("adult")]
        public virtual bool Adult { get; set; }

        [JsonProperty("popularity")]
        public virtual double? Popularity { get; set; }

        [JsonProperty("gender")]
        public virtual int? Gender { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("known_for_department")]
        public virtual string KnownForDepartment { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("original_name")]
        public virtual string OriginalName { get; set; }

        [JsonProperty("profile_path")]
        public virtual string ProfilePath { get; set; }

        [JsonProperty("credit_id")]
        public virtual string CreditId { get; set; }
    }
}