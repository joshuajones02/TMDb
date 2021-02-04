using System.ComponentModel;

namespace TMDb.Client.Enums
{
    // TODO: Store enum/descrtion kvp in cached dictionary
    public enum DiscoverMovieSortBy
    {
        [Description("popularity.desc")]
        PopularityDescending = 0,

        [Description("popularity.asc")]
        PopularityAscending,

        [Description("release_date.desc")]
        ReleaseDateDescending,

        [Description("release_date.asc")]
        ReleaseDateAscending,

        [Description("vote_average.desc")]
        VoteAverageDescending,

        [Description("vote_average.asc")]
        VoteAverageAscending,

        [Description("revenue.desc")]
        RevenueDescending,

        [Description("revenue.asc")]
        RevenueAscending,

        [Description("primary_release_date.desc")]
        PrimaryReleaseDateDescending,

        [Description("primary_release_date.asc")]
        PrimaryReleaseDateAscending,

        [Description("original_title.desc")]
        OriginalTitleDescending,

        [Description("original_title.asc")]
        OriginalTitleAscending,

        [Description("vote_count.desc")]
        VoteCountDescending,

        [Description("vote_count.asc")]
        VoteCountAscending
    }
}