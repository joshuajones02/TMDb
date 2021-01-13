using System.Runtime.Serialization;

namespace TMDb.Client.Enums
{
    public enum VideoType
    {
        Trailer, 
        Teaser, 
        Clip, 
        Featurette,

        [EnumMember(Value = "Opening Credits")]
        OpeningCredits,

        [EnumMember(Value = "Behind the Scenes")]
        BehindTheScenes, 

        Bloopers, 
        Recap
    }
}