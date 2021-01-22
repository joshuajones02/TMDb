using Newtonsoft.Json;

namespace TMDb.Client.Api.V3.Models.People
{
    public class PeopleTVCreditsCrew : PeopleTVCreditsBasePerson
    {
        [JsonProperty("department")]
        public virtual string Department { get; set; }

        [JsonProperty("job")]
        public virtual string Job { get; set; }
    }
}