using System;
using TMDb.Client.Attributes;

namespace TMDb.Client.Models
{
    [Obsolete("// TODO: Refactor into a single class that contains collections for each parameter type??")]
    public class ApiParameter
    {
        public ApiParameter(string name, ParameterType type, string value)
        {
            ParameterType = type;
            Name = name;
            Value = value;
        }

        // TODO: Contain individual items here?
        // i.e.
        //public Dictionary<string, string> Headers { get; }
        //public Dictionary<string, string> QueryParameters { get; }
        //public Dictionary<string, string> PathParameters { get; }
        //public Dictionary<string, string> JsonBody { get; }
        //public string Version { get; set; }
        //
        //public void Add(string name, ParameterType type, string value)
        //{
        //    if (type == ParameterType.Header)
        //    {
        //
        //    }
        //    else if (type == ParameterType.Query)
        //    {
        //
        //    }
        //    else if (type == ParameterType.Path)
        //    {
        //
        //    }
        //    else if (type == ParameterType.JsonBody)
        //    {
        //
        //    }
        //    else if (type == ParameterType.PathPrepend)
        //    {
        //
        //    }
        //}

        public string Name { get; set; }
        public string Value { get; set; }
        public ParameterType ParameterType { get; set; }
    }
}