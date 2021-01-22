using TMDb.Client.Entities.Things;

namespace TMDb.Client.Api.V3.Models.TVEpisodes
{
    public struct TVRatingBoolUnion
    {
        public bool? Bool;
        public TVRating TVRating;

        public static implicit operator TVRatingBoolUnion(bool @bool) =>
            new TVRatingBoolUnion
            {
                Bool = @bool
            };

        public static implicit operator TVRatingBoolUnion(TVRating tvRating) =>
            new TVRatingBoolUnion
            {
                TVRating = tvRating
            };
    }
}