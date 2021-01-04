using Newtonsoft.Json;

namespace TMDb.Client.Models
{
    public class Crew
    {
        [JsonProperty("adult")]
        public bool Adult { get; set; }

        [JsonProperty("popularity")]
        public double Popularity { get; set; }

        [JsonProperty("gender")]
        public int Gender { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("credit_id")]
        public string CreditId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("original_name")]
        public string OriginalName { get; set; }

        [JsonProperty("profile_path")]
        public string ProfilePath { get; set; }

        [JsonProperty("character")]
        public string Character { get; set; }

        [JsonProperty("job")]
        public string CrewJob { get; set; }

        [JsonProperty("department")]
        public string CrewDepartment { get; set; }

        [JsonProperty("known_for_department")]
        public string KnownForDepartment { get; set; }
    }
}