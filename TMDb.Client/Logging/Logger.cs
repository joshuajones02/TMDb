using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using TMDb.Client.JsonConverters;

namespace TMDb.Client.Logging
{
    internal class LogManager
    {
        private readonly JsonSerializerSettings _serializerSettings;
        private string _typeName;

        internal LogManager() : this(null)
        {
        }

        internal LogManager(string name)
        {
            _serializerSettings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Converters = new List<JsonConverter>
                {
                    new EnumDescriptionConverter(),
                    new StringEnumConverter { AllowIntegerValues = false }
                }
            };

            _typeName = name;
        }

        protected string LogId => Guid.NewGuid().ToString("N");
        internal string LogError(object logData) => Log(logData, true);
        internal string LogException(Exception ex) => LogError(ex.Minify());
        internal string LogInfo(object logData) => Log(logData, false);
        protected string Log(object data, bool isError)
        {
            if (!Debugger.IsAttached)
                return null;

            var logId = LogId;
            var wrapper = new { data, logId };
            var serialized = wrapper.ToJson(_serializerSettings);

            var logEvent = _typeName.HasValue() ?
                string.Format("{0} : {1}", _typeName, serialized) : serialized;

            if (isError)
                Trace.TraceError(logEvent);
            else
                Trace.TraceInformation(logEvent);

            return logId;
        }

        internal static LogManager GetLogger<T>() => new LogManager(typeof(T).Name);
    }
}