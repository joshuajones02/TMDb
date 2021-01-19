using System.ComponentModel;
using System.Runtime.Serialization;

namespace TMDb.Client.Enums
{
    public enum DiscoverTVSortBy
    {
        [Description("popularity.asc")]
        [EnumMember(Value = "popularity.asc")]
        PopularityAscending,

        [Description("popularity.desc")]
        [EnumMember(Value = "popularity.desc")]
        PopularityDescending,

        [Description("first_air_date.asc")]
        [EnumMember(Value = "first_air_date.asc")]
        FirstAirDateAscending,

        [Description("first_air_date.desc")]
        [EnumMember(Value = "first_air_date.desc")]
        FirstAirDateDescending,

        [Description("vote_average.asc")]
        [EnumMember(Value = "vote_average.asc")]
        VoteAverageAscending,

        [Description("vote_average.desc")]
        [EnumMember(Value = "vote_average.desc")]
        VoteAverageDescending,
    }
}