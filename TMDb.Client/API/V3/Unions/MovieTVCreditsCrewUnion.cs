namespace TMDb.Client.Api.V3.Models.People
{
    public struct MovieTVCreditsCrewUnion
    {
        public PeopleMovieCreditsCrew Movie;
        public PeopleTVCreditsCrew TV;

        public static implicit operator MovieTVCreditsCrewUnion(PeopleMovieCreditsCrew movie) =>
            new MovieTVCreditsCrewUnion
            {
                Movie = movie
            };

        public static implicit operator MovieTVCreditsCrewUnion(PeopleTVCreditsCrew tv) =>
            new MovieTVCreditsCrewUnion
            {
                TV = tv
            };
    }
}