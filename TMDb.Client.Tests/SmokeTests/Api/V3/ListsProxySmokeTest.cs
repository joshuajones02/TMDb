using System;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Lists;
using TMDb.Client.Constants;
using TMDb.Client.Unions;
using Xunit;

namespace TMDb.Client.Tests.SmokeTests.Api.V3
{
    public class ListsProxySmokeTest : TestsClient
    {
        // TODO: ListId
        [Theory]
        [InlineData(0, Language.AmericanEnglish)]
        public async Task ListDetailsSmokeTest(int listId, string language)
        {
            //var response = await Client.Lists.GetAsync(new ListDetailsRequest 
            //{ 
            //    ListId = new ListsIntStringIdUnion { IntId = listId },
            //    LanguageAbbreviation = language
            //});

            //Assert.IsType<ListDetailsResponse>(response);
        }

        [Theory]
        [InlineData(0, 0)]
        public async Task ListItemStatusSmokeTest(int listId, int movieId)
        {
            var response = await Client.Lists.GetAsync(new ListItemStatusRequest
            {
                ListId = new ListsIntStringIdUnion { IntId = listId },
                MovieId = movieId
            });

            Assert.IsType<ListItemStatusResponse>(response);
        }

        // TODO: Need session id
        [Theory]
        [InlineData("name", "description")]
        public async Task CreateListSmokeTest(string name, string description)
        {
            //var sessionId = "";

            //var response = await Client.Lists.PostAsync(new CreateListRequest
            //{
            //    Name = name,
            //    SessionId = sessionId,
            //    Description = description
            //});

            //Assert.IsType<CreateListResponse>(response);
        }

        // TODO: Need session id
        [Theory]
        [InlineData(0, Language.AmericanEnglish, 0)]
        public async Task ListAddMovieSmokeTest(int listId, string language, int mediaId)
        {
            //var sessionId = "";

            //var response = await Client.Lists.PostAsync(new ListAddMovieRequest
            //{
            //    ListId = new ListsIntStringIdUnion { IntId = listId },
            //    LanguageAbbreviation = language, 
            //    MediaId = mediaId,
            //    SessionId  = sessionId
            //});

            //Assert.IsType<ListAddMovieResponse>(response);
        }

        // TODO: Need session id
        [Theory]
        [InlineData(0, true)]
        public async Task ClearListSmokeTest(int listId, bool confirm)
        {
            //var sessionId = "";

            //var response = await Client.Lists.PostAsync(new ClearListRequest
            //{
            //    ListId = new ListsIntStringIdUnion { IntId = listId },
            //    Confirm = confirm,
            //    SessionId = sessionId
            //});

            //Assert.IsType<ClearListResponse>(response);
        }

        // TODO: Need session id
        [Theory]
        [InlineData(0)]
        public async Task DeleteListSmokeTest(int listId)
        {
            //var sessionId = "";

            //var response = await Client.Lists.DeleteAsync(new DeleteListRequest
            //{
            //    ListId = new ListsIntStringIdUnion { IntId = listId },
            //    SessionId = sessionId
            //});

            //Assert.IsType<DeleteListResponse>(response);
        }
    }
}