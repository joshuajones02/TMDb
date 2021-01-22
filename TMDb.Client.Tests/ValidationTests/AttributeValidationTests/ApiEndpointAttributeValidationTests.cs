using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TMDb.Client.Attributes;
using Xunit;

namespace TMDb.Client.Tests.ValidationTests.AttributeTests
{
    public class ApiEndpointAttributeValidationTests
    {
        private readonly IEnumerable<Type> _assemblyTypes;

        public ApiEndpointAttributeValidationTests()
        {
            _assemblyTypes = Assembly.GetAssembly(typeof(ApiEndpointAttribute)).GetTypes();
        }

        [Fact]
        public void ApiEndpoint_HavePathDefinedTest()
        {
            var types = _assemblyTypes
                .Where(type => Attribute.IsDefined(type, typeof(ApiGetEndpointAttribute))
                            || Attribute.IsDefined(type, typeof(ApiPostEndpointAttribute))
                            || Attribute.IsDefined(type, typeof(ApiDeleteEndpointAttribute))
                            || Attribute.IsDefined(type, typeof(ApiPutEndpointAttribute)));

            var message = "Bad properties: ";
            var badTypeCount = 0;

            foreach (var type in types)
            {
                var attribute = (ApiEndpointAttribute)type
                    .GetCustomAttributes(inherit: true)
                    .Single(x => x.GetType().IsAssignableFrom(typeof(ApiEndpointAttribute))
                              || x.GetType().IsSubclassOf(typeof(ApiEndpointAttribute)));

                if (string.IsNullOrEmpty(attribute.Path))
                {
                    message += type.Name + " ";
                    badTypeCount++;
                }
            }

            Assert.True(badTypeCount == 0, message);
        }
    }
}