using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TMDb.Client.Api;
using TMDb.Client.Attributes;
using Xunit;

namespace TMDb.Client.Tests.ValidationTests.ModelValidationTests
{
    public class RequestBaseValidationTests
    {
        private readonly IEnumerable<Type> _requestTypes;

        public RequestBaseValidationTests()
        {
            _requestTypes = Assembly
                .GetAssembly(typeof(RequestBase))
                .GetTypes()
                .Where(t => t.IsSubclassOf(typeof(RequestBase)));
        }

        [Fact]
        public void RequestBase_ConcreteChildren_HaveApiEndpointAttributeTest()
        {
            var invalidTypes = _requestTypes
                .Where(t => !t.IsAbstract
                         && !t.GetCustomAttributes(inherit: true)
                              .Any(x => x.GetType().IsAssignableFrom(typeof(ApiEndpointAttribute))
                                     || x.GetType().IsSubclassOf(typeof(ApiEndpointAttribute))))
                .Select(t => t.GetTypeInfo().AsType().Name);

            Assert.True(invalidTypes.Count() == 0, "Bad types: " + string.Join(", ", invalidTypes));
        }

        [Fact]
        public void RequestBase_AbstractChildren_DoNotHaveApiEndpointAttributeTest()
        {
            var invalidTypes = _requestTypes
                .Where(t => t.IsAbstract
                         && t.GetCustomAttributes(inherit: true)
                              .Any(x => x.GetType().IsAssignableFrom(typeof(ApiEndpointAttribute))
                                     || x.GetType().IsSubclassOf(typeof(ApiEndpointAttribute))))
                .Select(t => t.GetTypeInfo().AsType().Name);

            Assert.True(invalidTypes.Count() == 0, "Bad types: " + string.Join(", ", invalidTypes));
        }

        [Fact]
        public void RequestBase_Children_Properties_HaveApiParameterAttributeTest()
        {
            var props = _requestTypes
                .Select(type => type.GetProperties())
                .SelectMany(propInfo => propInfo)
                .Where(propInfo => propInfo.GetCustomAttribute<ApiParameterAttribute>() == null
                                && propInfo.GetCustomAttribute<ApiParameterIgnoreAttribute>() == null)
                .Select(propInfo => propInfo.Name);

            Assert.True(props.Count() == 0, "Bad properties: " + string.Join(", ", props));
        }
    }
}