using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.People;

namespace TMDb.Client.Api.V3.ClientProxies
{
    public class PeopleProxy : ApiProxy
    {
        public PeopleProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<PeopleDetailsResponse> GetAsync(PeopleDetailsRequest request) =>
            Client.SendAsync<PeopleDetailsResponse>(request);

        public virtual Task<PeopleChangesResponse> GetAsync(PeopleChangesRequest request) =>
            Client.SendAsync<PeopleChangesResponse>(request);

        public virtual Task<PeopleMovieCreditsResponse> GetAsync(PeopleMovieCreditsRequest request) =>
            Client.SendAsync<PeopleMovieCreditsResponse>(request);

        public virtual Task<PeopleTVCreditsResponse> GetAsync(PeopleTVCreditsRequest request) =>
            Client.SendAsync<PeopleTVCreditsResponse>(request);

        public virtual Task<PeopleCombinedCreditsResponse> GetAsync(PeopleCombinedCreditsRequest request) =>
            Client.SendAsync<PeopleCombinedCreditsResponse>(request);
        
        public virtual Task<PeopleExternalIdsResponse> GetAsync(PeopleExternalIdsRequest request) =>
            Client.SendAsync<PeopleExternalIdsResponse>(request);
        
        public virtual Task<PeopleImagesResponse> GetAsync(PeopleImagesRequest request) =>
            Client.SendAsync<PeopleImagesResponse>(request);
        
        public virtual Task<PeopleTaggedImagesResponse> GetAsync(PeopleTaggedImagesRequest request) =>
            Client.SendAsync<PeopleTaggedImagesResponse>(request);
        
        public virtual Task<PeopleTranslationsResponse> GetAsync(PeopleTranslationsRequest request) =>
            Client.SendAsync<PeopleTranslationsResponse>(request);
        
        public virtual Task<LatestPeopleResponse> GetAsync(LatestPeopleRequest request) =>
            Client.SendAsync<LatestPeopleResponse>(request);
        
        public virtual Task<PopularPeopleResponse> GetAsync(PopularPeopleRequest request) =>
            Client.SendAsync<PopularPeopleResponse>(request);
    }
}