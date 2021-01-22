using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.Api.V3.Models.Certifications
{
    public class MovieCertifications : Certifications
    {
        [JsonProperty("NZ")]
        public virtual IEnumerable<ContentRating> NZ { get; set; }

        [JsonProperty("IN")]
        public virtual IEnumerable<ContentRating> IN { get; set; }

        [JsonProperty("NL")]
        public virtual IEnumerable<ContentRating> NL { get; set; }

        [JsonProperty("FI")]
        public virtual IEnumerable<ContentRating> FI { get; set; }

        [JsonProperty("BG")]
        public virtual IEnumerable<ContentRating> BG { get; set; }

        [JsonProperty("ES")]
        public virtual IEnumerable<ContentRating> ES { get; set; }

        [JsonProperty("PH")]
        public virtual IEnumerable<ContentRating> PH { get; set; }

        [JsonProperty("PT")]
        public virtual IEnumerable<ContentRating> PT { get; set; }
    }

    public class Certifications
    {
        [JsonProperty("RU")]
        public virtual IEnumerable<ContentRating> RU { get; set; }

        [JsonProperty("US")]
        public virtual IEnumerable<ContentRating> US { get; set; }

        [JsonProperty("CA")]
        public virtual IEnumerable<ContentRating> CA { get; set; }

        [JsonProperty("AU")]
        public virtual IEnumerable<ContentRating> AU { get; set; }

        [JsonProperty("FR")]
        public virtual IEnumerable<ContentRating> FR { get; set; }

        [JsonProperty("DE")]
        public virtual IEnumerable<ContentRating> DE { get; set; }

        [JsonProperty("TH")]
        public virtual IEnumerable<ContentRating> TH { get; set; }

        [JsonProperty("KR")]
        public virtual IEnumerable<ContentRating> KR { get; set; }

        [JsonProperty("GB")]
        public virtual IEnumerable<ContentRating> GB { get; set; }

        [JsonProperty("BR")]
        public virtual IEnumerable<ContentRating> BR { get; set; }
    }
}