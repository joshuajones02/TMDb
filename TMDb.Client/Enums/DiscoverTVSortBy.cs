using System.ComponentModel;

namespace TMDb.Client.Enums
{
    public enum DiscoverTVSortBy
    {
        [Description("popularity.asc")]
        PopularityAscending,

        [Description("popularity.desc")]
        PopularityDescending,

        [Description("release_date.asc")]
        ReleaseDateAscending,

        [Description("release_date.desc")]
        ReleaseDateDescending,

        [Description("revenue.asc")]
        RevenueAscending,

        [Description("revenue.desc")]
        RevenueDescending,

        [Description("primary_release_date.asc")]
        PrimaryReleaseDateAscending,

        [Description("primary_release_date.desc")]
        PrimaryReleaseDateDescending,

        [Description("original_title.asc")]
        OriginalTitleAscending,

        [Description("original_title.desc")]
        OriginalTitleDescending,

        [Description("vote_average.asc")]
        VoteAverageAscending,

        [Description("vote_average.desc")]
        VoteAverageDescending,

        [Description("vote_count.asc")]
        VoteCountAscending,

        [Description("vote_count.desc")]
        VoteCountDescending
    }
}