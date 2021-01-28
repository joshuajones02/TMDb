using System;
using static TMDb.Client.Tests.Configuration;

namespace TMDb.Client.Tests
{
    public class TestsSettings
    {
        public string ApiKey { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string Version { get; set; }

        public TestsSettings()
        {
            var message = "Add this information into the tests project's appsettings.json file";
            var accountMessage = "A {0} is required, DO NOT USE YOUR PERSONAL ACCOUNT, instead create an additional account for testing only. {1}";
            Username = AppSettings.Get("TestsSettings:Username") ?? throw new ArgumentNullException(string.Format(accountMessage, "username", message));
            Password = AppSettings.Get("TestsSettings:Password") ?? throw new ArgumentNullException(string.Format(accountMessage, "password", message));
            var apiKeyMessage = "An api key is required to run the smoke tests. " + message;
            ApiKey = AppSettings.Get("TestsSettings:ApiKey") ?? throw new ArgumentNullException(apiKeyMessage);
            Version = "3";
        }

        private static TestsSettings _instance;
        public static TestsSettings Instance => _instance ??= new TestsSettings();
    }

}