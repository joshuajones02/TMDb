namespace TMDb.Client.API.V3.Models.TVEpisodes
{
    public struct TVEpisodesBoolRateValueUnion
    {
        public bool? Bool;
        public RateValue Rated;

        public static implicit operator TVEpisodesBoolRateValueUnion(bool Bool) =>
            new TVEpisodesBoolRateValueUnion { Bool = Bool };

        public static implicit operator TVEpisodesBoolRateValueUnion(RateValue Rated) =>
            new TVEpisodesBoolRateValueUnion { Rated = Rated };
    }
}