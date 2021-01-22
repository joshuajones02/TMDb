using TMDb.Client.Api.V3.Models.People;

namespace TMDb.Client.Unions
{
    public struct PopularPeopleKnownForMovieTVUnion
    {
        public PersonKnownForMovie Movie;
        public PersonKnownForTV TV;

        public static implicit operator PopularPeopleKnownForMovieTVUnion(PersonKnownForMovie movie) =>
            new PopularPeopleKnownForMovieTVUnion
            {
                Movie = movie
            };

        public static implicit operator PopularPeopleKnownForMovieTVUnion(PersonKnownForTV tv) =>
            new PopularPeopleKnownForMovieTVUnion
            {
                TV = tv
            };
    }
}