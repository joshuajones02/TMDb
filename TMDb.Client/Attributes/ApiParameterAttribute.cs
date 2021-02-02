using System;

namespace TMDb.Client.Attributes
{
    public enum ParameterType
    {
        NotSet = 0,
        JsonBody = 1,
        Endpoint = 5,
        // TODO: Prepend {version} to all paths and make it a path parameter?
        Version = 50,
        Path = 55,
        Query = 60,
        Header = 70
    }

    public enum SerializationOption
    {
        NotSet = 0,
        DateOnly,
        Delimeter, 
        EnumDescription,
        NoHyphen,
        ToLower
    }

    [AttributeUsage(AttributeTargets.Property)]
    public sealed class ApiParameterAttribute : Attribute
    {
        public char Delimeter { get; set; } // TODO: remove ... we should default to and or else use delimeter location 
        public string DelimeterLocation { get; set; } // TODO: rename to delimeter once its removed
        public string Name { get; set; }
        public ParameterType ParameterType { get; set; }
        public SerializationOption Option { get; set; }
    }
}