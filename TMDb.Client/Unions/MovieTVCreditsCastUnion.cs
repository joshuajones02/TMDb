namespace TMDb.Client.API.V3.Models.People
{
    public struct MovieTVCreditsCastUnion
    {
        public PeopleMovieCreditsCast Movie;
        public PeopleTVCreditsCast TV;

        public static implicit operator MovieTVCreditsCastUnion(PeopleMovieCreditsCast movie) =>
            new MovieTVCreditsCastUnion
            {
                Movie = movie
            };

        public static implicit operator MovieTVCreditsCastUnion(PeopleTVCreditsCast tv) =>
            new MovieTVCreditsCastUnion
            {
                TV = tv
            };
    }
}
}