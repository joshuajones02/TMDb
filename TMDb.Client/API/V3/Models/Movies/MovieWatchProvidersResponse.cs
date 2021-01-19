using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TMDb.Client.API.V3.Models.Movies
{
    public class MovieWatchProvidersResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("results")]
        public Results Results { get; set; }
    }

    public class Results
    {
        [JsonProperty("AR")]
        public WatchProviderOptions AR { get; set; }

        [JsonProperty("AT")]
        public WatchProviderOptions AT { get; set; }

        [JsonProperty("AU")]
        public WatchProviderOptions AU { get; set; }

        [JsonProperty("BE")]
        public WatchProviderOptions BE { get; set; }

        [JsonProperty("BR")]
        public WatchProviderOptions BR { get; set; }

        [JsonProperty("CA")]
        public WatchProviderOptions CA { get; set; }

        [JsonProperty("CH")]
        public WatchProviderOptions CH { get; set; }

        [JsonProperty("CL")]
        public WatchProviderOptions CL { get; set; }

        [JsonProperty("CO")]
        public WatchProviderOptions CO { get; set; }

        [JsonProperty("CZ")]
        public WatchProviderOptions CZ { get; set; }

        [JsonProperty("DE")]
        public WatchProviderOptions DE { get; set; }

        [JsonProperty("DK")]
        public WatchProviderOptions DK { get; set; }

        [JsonProperty("EC")]
        public WatchProviderOptions EC { get; set; }

        [JsonProperty("EE")]
        public WatchProviderOptions EE { get; set; }

        [JsonProperty("ES")]
        public WatchProviderOptions ES { get; set; }

        [JsonProperty("FI")]
        public WatchProviderOptions FI { get; set; }

        [JsonProperty("FR")]
        public WatchProviderOptions FR { get; set; }

        [JsonProperty("GB")]
        public WatchProviderOptions GB { get; set; }

        [JsonProperty("GR")]
        public WatchProviderOptions GR { get; set; }

        [JsonProperty("HU")]
        public WatchProviderOptions HU { get; set; }

        [JsonProperty("ID")]
        public WatchProviderOptions ID { get; set; }

        [JsonProperty("IE")]
        public WatchProviderOptions IE { get; set; }

        [JsonProperty("IN")]
        public WatchProviderOptions IN { get; set; }

        [JsonProperty("IT")]
        public WatchProviderOptions IT { get; set; }

        [JsonProperty("JP")]
        public WatchProviderOptions JP { get; set; }

        [JsonProperty("KR")]
        public WatchProviderOptions KR { get; set; }

        [JsonProperty("LT")]
        public WatchProviderOptions LT { get; set; }

        [JsonProperty("LV")]
        public WatchProviderOptions LV { get; set; }

        [JsonProperty("MX")]
        public WatchProviderOptions MX { get; set; }

        [JsonProperty("MY")]
        public WatchProviderOptions MY { get; set; }

        [JsonProperty("NL")]
        public WatchProviderOptions NL { get; set; }

        [JsonProperty("NO")]
        public WatchProviderOptions NO { get; set; }

        [JsonProperty("NZ")]
        public WatchProviderOptions NZ { get; set; }

        [JsonProperty("PE")]
        public WatchProviderOptions PE { get; set; }

        [JsonProperty("PH")]
        public WatchProviderOptions PH { get; set; }

        [JsonProperty("PL")]
        public WatchProviderOptions PL { get; set; }

        [JsonProperty("PT")]
        public WatchProviderOptions PT { get; set; }

        [JsonProperty("RO")]
        public WatchProviderOptions RO { get; set; }

        [JsonProperty("RU")]
        public WatchProviderOptions RU { get; set; }

        [JsonProperty("SE")]
        public WatchProviderOptions SE { get; set; }

        [JsonProperty("SG")]
        public WatchProviderOptions SG { get; set; }

        [JsonProperty("TH")]
        public WatchProviderOptions TH { get; set; }

        [JsonProperty("TR")]
        public WatchProviderOptions TR { get; set; }

        [JsonProperty("US")]
        public WatchProviderOptions US { get; set; }

        [JsonProperty("VE")]
        public WatchProviderOptions VE { get; set; }

        [JsonProperty("ZA")]
        public WatchProviderOptions ZA { get; set; }
    }

    public class WatchProviderOptions
    {
        [JsonProperty("link")]
        public Uri Link { get; set; }

        [JsonProperty(
            propertyName: "flatrate", 
            NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<WatchProvider> FlatRate { get; set; }

        [JsonProperty(
            propertyName: "rent",
            NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<WatchProvider> Rent { get; set; }

        [JsonProperty(
            propertyName: "buy",
            NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<WatchProvider> Buy { get; set; }
    }

    public class WatchProvider
    {
        [JsonProperty("display_priority")]
        public int? DisplayPriority { get; set; }

        [JsonProperty("provider_id")]
        public int ProviderId { get; set; }

        [JsonProperty("logo_path")]
        public string LogoPath { get; set; }

        [JsonProperty("provider_name")]
        public string ProviderName { get; set; }
    }
}
