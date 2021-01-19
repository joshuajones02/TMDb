using System.ComponentModel;
using System.Runtime.Serialization;

namespace TMDb.Client.Enums
{
    public enum DiscoverMovieSortBy
    {
        [Description("popularity.asc")]
        [EnumMember(Value = "popularity.asc")]
        PopularityAscending,

        [Description("popularity.desc")]
        [EnumMember(Value = "popularity.desc")]
        PopularityDescending,

        [Description("release_date.asc")]
        [EnumMember(Value = "release_date.asc")]
        ReleaseDateAscending,

        [Description("release_date.desc")]
        [EnumMember(Value = "release_date.desc")]
        ReleaseDateDescending,

        [Description("vote_average.asc")]
        [EnumMember(Value = "vote_average.asc")]
        VoteAverageAscending,

        [Description("vote_average.desc")]
        [EnumMember(Value = "vote_average.desc")]
        VoteAverageDescending,

        [Description("revenue.asc")]
        [EnumMember(Value = "revenue.asc")]
        RevenueAscending,

        [Description("revenue.desc")]
        [EnumMember(Value = "revenue.desc")]
        RevenueDescending,

        [Description("primary_release_date.asc")]
        [EnumMember(Value = "primary_release_date.asc")]
        PrimaryReleaseDateAscending,

        [Description("primary_release_date.desc")]
        [EnumMember(Value = "primary_release_date.desc")]
        PrimaryReleaseDateDescending,

        [Description("original_title.asc")]
        [EnumMember(Value = "original_title.asc")]
        OriginalTitleAscending,

        [Description("original_title.desc")]
        [EnumMember(Value = "original_title.desc")]
        OriginalTitleDescending,

        [Description("vote_count.asc")]
        [EnumMember(Value = "vote_count.asc")]
        VoteCountAscending,

        [Description("vote_count.desc")]
        [EnumMember(Value = "vote_count.desc")]
        VoteCountDescending
    }
}