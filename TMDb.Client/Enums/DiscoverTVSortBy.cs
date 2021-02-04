using System.ComponentModel;

namespace TMDb.Client.Enums
{
    // TODO: Store enum/descrtion kvp in cached dictionary
    public enum DiscoverTVSortBy
    {
        [Description("popularity.desc")]
        PopularityDescending = 0,

        [Description("popularity.asc")]
        PopularityAscending,

        [Description("first_air_date.desc")]
        FirstAirDateDescending,

        [Description("first_air_date.asc")]
        FirstAirDateAscending,

        [Description("vote_average.desc")]
        VoteAverageDescending,

        [Description("vote_average.asc")]
        VoteAverageAscending
    }
}