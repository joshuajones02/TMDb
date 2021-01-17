using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.People;

namespace TMDb.Client.API.V3.ClientProxies
{
    public class PeopleProxy : ApiProxy
    {
        public PeopleProxy(TMDbClient client) : base(client)
        {
        }

        public virtual string FormatPath(string path, int personId) =>
            string.Format(path, personId);

        public virtual Task<PeopleDetailsResponse> GetAsync(PeopleDetailsRequest request) =>
            Client.GetAsync<PeopleDetailsResponse>(
                Serialize(FormatPath("/person/{0}", request.PersonId), request));

        public virtual Task<PeopleChangesResponse> GetAsync(PeopleChangesRequest request) =>
            Client.GetAsync<PeopleChangesResponse>(
                Serialize(FormatPath("/person/{0}/changes", request.PersonId), request));

        public virtual Task<PeopleMovieCreditsResponse> GetAsync(PeopleMovieCreditsRequest request) =>
            Client.GetAsync<PeopleMovieCreditsResponse>(
                Serialize(FormatPath("s/person/{0}/movie_credits", request.PersonId), request));

        public virtual Task<PeopleTVCreditsResponse> GetAsync(PeopleTVCreditsRequest request) =>
            Client.GetAsync<PeopleTVCreditsResponse>(
                Serialize(FormatPath("/person/{0}/tv_credits", request.PersonId), request));

        public virtual Task<PeopleCombinedCreditsResponse> GetAsync(PeopleCombinedCreditsRequest request) =>
            Client.GetAsync<PeopleCombinedCreditsResponse>(
                Serialize(FormatPath("/person/{0}/combined_credits", request.PersonId), request));

        public virtual Task<PeopleExternalIdsResponse> GetAsync(PeopleExternalIdsRequest request) =>
            Client.GetAsync<PeopleExternalIdsResponse>(
                Serialize(FormatPath("/person/{0}/external_ids", request.PersonId), request));

        public virtual Task<PeopleImagesResponse> GetAsync(PeopleImagesRequest request) =>
            Client.GetAsync<PeopleImagesResponse>(
                Serialize(FormatPath("/person/{0}/images", request.PersonId), request));

        public virtual Task<PeopleTaggedImagesResponse> GetAsync(PeopleTaggedImagesRequest request) =>
            Client.GetAsync<PeopleTaggedImagesResponse>(
                Serialize(FormatPath("/person/{0}/tagged_images", request.PersonId), request));

        public virtual Task<PeopleTranslationsResponse> GetAsync(PeopleTranslationsRequest request) =>
            Client.GetAsync<PeopleTranslationsResponse>(
                Serialize(FormatPath("/person/{0}/translations", request.PersonId), request));

        public virtual Task<LatestPeopleResponse> GetAsync(LatestPeopleRequest request) =>
            Client.GetAsync<LatestPeopleResponse>(Serialize("/person/latest", request));

        public virtual Task<PeopleDetailsResponse> GetAsync(PopularPeopleRequest request) =>
            Client.GetAsync<PeopleDetailsResponse>(Serialize("/person/popular", request));
    }
}