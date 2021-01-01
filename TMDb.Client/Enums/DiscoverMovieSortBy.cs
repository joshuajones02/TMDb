using System.ComponentModel;

namespace TMDb.Client.Enums
{
    public enum DiscoverMovieSortBy
    {
        [Description("popularity.asc")]
        PopularityAscending,

        [Description("popularity.desc")]
        PopularityDescending,

        [Description("first_air_date.asc")]
        FirstAirDateAscending,

        [Description("first_air_date.desc")]
        FirstAirDateDescending,

        [Description("vote_average.asc")]
        VoteAverageAscending,

        [Description("vote_average.desc")]
        VoteAverageDescending,
    }
}