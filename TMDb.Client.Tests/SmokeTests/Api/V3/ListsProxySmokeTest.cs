using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Account;
using TMDb.Client.Api.V3.Models.Lists;
using TMDb.Client.Tests.TestConstants;
using Xunit;

namespace TMDb.Client.Tests.SmokeTests.Api.V3
{
    public class ListsProxySmokeTest : TestsClient
    {
        private static ListSmokeTestData _listSmokeTestData;

        public ListsProxySmokeTest()
        {
            if (_listSmokeTestData == null)
            {
                Task.Run(Initialize).Wait();
            }
        }

        private class ListSmokeTestData
        {
            public int AccountId { get; internal set; }
            public int MediaId { get; internal set; }
            public int ListId { get; internal set; }
            public string SessionId { get; internal set; }
            public string Language { get; internal set; }
        }

        private async Task Initialize()
        {
            var mediaId = (int)Movie.Immortals;
            var language = Language.AmericanEnglish;
            var accountData = await GetAccountDataAsync();

            var getCreatedListsResponse = await Client.Account.GetAsync(new GetCreatedListsRequest
            {
                AccountId = accountData.AccountId,
                LanguageAbbreviation = language,
                SessionId = accountData.SessionId,
                Page = 1
            });

            if (getCreatedListsResponse.Results.Any())
            {
                var list = getCreatedListsResponse.Results.First();
                _listSmokeTestData = new ListSmokeTestData
                {
                    AccountId = accountData.AccountId,
                    Language = language,
                    ListId = list.Id,
                    MediaId = mediaId,
                    SessionId = accountData.SessionId
                };
            }
            else
            {
                var createListResponse = await Client.Lists.PostAsync(new CreateListRequest
                {
                    SessionId = accountData.SessionId,
                    Name = "Smoke test " + DateTime.Now.ToString("f"),
                    Description = "ListItemStatusSmokeTest",
                });

                await Client.Lists.PostAsync(new ListAddMovieRequest
                {
                    SessionId = accountData.SessionId,
                    ListId = createListResponse.ListId,
                    LanguageAbbreviation = language,
                    MediaId = mediaId
                });

                _listSmokeTestData = new ListSmokeTestData
                {
                    AccountId = accountData.AccountId,
                    Language = language,
                    ListId = createListResponse.ListId,
                    MediaId = mediaId,
                    SessionId = accountData.SessionId
                };
            }
        }

        [Fact]
        public async Task ListDetailsSmokeTest()
        {
            // Arrange

            // Act
            var response = await Client.Lists.GetAsync(new ListDetailsRequest
            {
                ListId = _listSmokeTestData.ListId,
                LanguageAbbreviation = _listSmokeTestData.Language
            });

            // Assert
            Assert.IsType<ListDetailsResponse>(response);
        }

        [Fact]
        public async Task ListItemStatusSmokeTest()
        {
            // Arrange
            var language = _listSmokeTestData.Language;
            var listId = _listSmokeTestData.ListId;
            var mediaId = _listSmokeTestData.MediaId;
            var sessionId = _listSmokeTestData.SessionId;

            var listDetailsResponse = await Client.Lists.GetAsync(new ListDetailsRequest
            {
                ListId = listId,
                LanguageAbbreviation = language
            });

            if (listDetailsResponse.Items.Where(x => x.Id.Equals(mediaId)).Any() == false)
            {
                await Client.Lists.PostAsync(new ListAddMovieRequest
                {
                    ListId = listId,
                    LanguageAbbreviation = language,
                    MediaId = mediaId,
                    SessionId = sessionId
                });
            }

            // Act
            var response = await Client.Lists.GetAsync(new ListItemStatusRequest
            {
                ListId = listId,
                MovieId = mediaId
            });

            // Assert
            Assert.IsType<ListItemStatusResponse>(response);
            Assert.True(response.ItemPresent);
        }

        [Fact]
        public async Task CreateListSmokeTest()
        {
            // Arrange
            var sessionId = _listSmokeTestData.SessionId;
            var listName = "Smoke test " + DateTime.Now.ToString("U");
            var description = "ListItemStatusSmokeTest";

            // Act
            var response = await Client.Lists.PostAsync(new CreateListRequest
            {
                SessionId = sessionId,
                Name = listName,
                Description = description,
            });

            // Assert
            Assert.IsType<CreateListResponse>(response);
            Assert.True(response.Success);

            // Cleanup
            try
            {
                await Client.Lists.DeleteAsync(new DeleteListRequest
                {
                    SessionId = sessionId,
                    ListId = response.ListId
                });
            }
            catch (Exception ex)
            {
                // Note: TMDb is returning 500 here, the lists are being deleted
                // appropriately so ignore if 500 is returned otherwise throw.
                if (ex is HttpRequestException requestException
                 && requestException.StatusCode == HttpStatusCode.InternalServerError)
                {
                    return;
                }

                throw;
            }
        }

        [Theory]
        [InlineData((int)Movie.AvengersEndGame, Language.AmericanEnglish)]
        [InlineData((int)Movie.Insidious, Language.AmericanEnglish)]
        [InlineData((int)Movie.Jumanji, Language.AmericanEnglish)]
        public async Task ListAddMovieSmokeTest(int mediaId, string language)
        {
            // Arrange
            var listId = _listSmokeTestData.ListId;
            var sessionId = _listSmokeTestData.SessionId;
            var listDetailsResponse = await Client.Lists.GetAsync(new ListDetailsRequest
            {
                ListId = listId,
                LanguageAbbreviation = language
            });

            if (listDetailsResponse.Items.Where(x => x.Id.Equals(mediaId)).Any())
            {
                await Client.Lists.PostAsync(new ListRemoveMovieRequest
                {
                    ListId = listId,
                    MediaId = mediaId,
                    SessionId = sessionId
                });
            }

            // Act
            var response = await Client.Lists.PostAsync(new ListAddMovieRequest
            {
                ListId = listId,
                LanguageAbbreviation = language,
                MediaId = mediaId,
                SessionId = sessionId
            });

            // Assert
            Assert.IsType<ListAddMovieResponse>(response);
        }

        [Theory]
        [InlineData((int)Movie.BillyMadison, Language.AmericanEnglish)]
        public async Task ListRemoveMovieSmokeTest(int mediaId, string language)
        {
            // Arrange
            var listId = _listSmokeTestData.ListId;
            var sessionId = _listSmokeTestData.SessionId;
            var listDetailsResponse = await Client.Lists.GetAsync(new ListDetailsRequest
            {
                ListId = listId,
                LanguageAbbreviation = language
            });

            if (listDetailsResponse.Items.Where(x => x.Id.Equals(mediaId)).Any() == false)
            {
                await Client.Lists.PostAsync(new ListAddMovieRequest
                {
                    ListId = listId,
                    LanguageAbbreviation = language,
                    MediaId = mediaId,
                    SessionId = sessionId
                });
            }

            // Act
            var response = await Client.Lists.PostAsync(new ListRemoveMovieRequest
            {
                ListId = listId,
                MediaId = mediaId,
                SessionId = sessionId
            });

            // Assert
            Assert.IsType<ListRemoveMovieResponse>(response);
        }

        [Fact]
        public async Task ClearListSmokeTest()
        {
            // Arrange

            // Act
            var response = await Client.Lists.PostAsync(new ClearListRequest
            {
                Confirm = true,
                ListId = _listSmokeTestData.ListId,
                SessionId = _listSmokeTestData.SessionId
            });

            // Assert
            Assert.IsType<ClearListResponse>(response);
        }

        // TODO: Cannot currently unit test this until issue is identified
        // TMDb is returning a 500 upon deleting a list. I'm receiving
        // receiving this issue even when using their API directly 
        // from their documentation
        //[Theory]
        //[InlineData(0)]
        //public async Task DeleteListSmokeTest(int listId)
        //{
        //    var response = await Client.Lists.DeleteAsync(new DeleteListRequest
        //    {
        //    });

        //    Assert.IsType<DeleteListResponse>(response);
        //}
    }
}