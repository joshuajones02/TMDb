using Newtonsoft.Json;

namespace TMDb.Client.Entities.People
{
    public class Crew
    {
        [JsonProperty("adult")]
        public virtual bool? Adult { get; set; }

        [JsonProperty("popularity")]
        public virtual double? Popularity { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("gender")]
        public virtual int? Gender { get; set; }

        [JsonProperty("order")]
        public virtual int? Order { get; set; }

        [JsonProperty("credit_id")]
        public virtual string CreditId { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("original_name")]
        public virtual string OriginalName { get; set; }

        [JsonProperty("profile_path")]
        public virtual string ProfilePath { get; set; }

        [JsonProperty("character")]
        public virtual string Character { get; set; }

        [JsonProperty("job")]
        public virtual string CrewJob { get; set; }

        [JsonProperty("department")]
        public virtual string CrewDepartment { get; set; }

        [JsonProperty("known_for_department")]
        public virtual string KnownForDepartment { get; set; }
    }
}