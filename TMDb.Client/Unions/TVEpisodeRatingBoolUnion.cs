using TMDb.Client.Entities.Things;

namespace TMDb.Client.API.V3.Models.TVEpisodes
{
    public struct TVEpisodeRatingBoolUnion
    {
        public bool? Bool;
        public TVEpisodeRating TVEpisodeRating;

        public static implicit operator TVEpisodeRatingBoolUnion(bool @bool) =>
            new TVEpisodeRatingBoolUnion 
            { 
                Bool = @bool 
            };

        public static implicit operator TVEpisodeRatingBoolUnion(TVEpisodeRating tvEpisodeRating) =>
            new TVEpisodeRatingBoolUnion 
            { 
                TVEpisodeRating = tvEpisodeRating 
            };
    }
}