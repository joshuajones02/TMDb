using TMDb.Client.API.V3.Models.People;

namespace TMDb.Client.Unions
{
    public struct PopularPeopleKnownForMovieTVUnion
    {
        public PopularPeopleKnownForMovie Movie;
        public PopularPeopleKnownForTV TV;

        public static implicit operator PopularPeopleKnownForMovieTVUnion(PopularPeopleKnownForMovie movie) =>
            new PopularPeopleKnownForMovieTVUnion
            {
                Movie = movie
            };

        public static implicit operator PopularPeopleKnownForMovieTVUnion(PopularPeopleKnownForTV tv) =>
            new PopularPeopleKnownForMovieTVUnion
            {
                TV = tv
            };
    }
}