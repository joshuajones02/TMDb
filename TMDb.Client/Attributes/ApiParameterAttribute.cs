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
        DelimeterSeparatedValue,
    }

    [Obsolete("// TODO: Create startup check for all parameter types having a value")]
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class ApiParameterAttribute : Attribute
    {
        public char Delimeter { get; set; }
        public string Name { get; set; }
        public ParameterType ParameterType { get; set; }
        public SerializationOption Option { get; set; }
    }
}