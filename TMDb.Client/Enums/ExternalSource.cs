using System.ComponentModel;

namespace TMDb.Client.Enums
{
    public enum ExternalSource
    {
        [Description("imdb_id")]
        IMDbId,

        [Description("freebase_id")]
        FreeBaseId,

        [Description("freebase_mid")]
        FreeBaseMid,

        [Description("tvdb_id")]
        TVDbId,

        [Description("tvrage_id")]
        TVRageId,

        [Description("facebook_id")]
        FacebookId,

        [Description("twitter_id")]
        TwitterId,

        [Description("instagram_id")]
        InstagramId
    }
}