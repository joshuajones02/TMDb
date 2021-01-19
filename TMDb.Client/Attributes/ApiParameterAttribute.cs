using System;

namespace TMDb.Client.Attributes
{
    public enum ParameterType
    {
        NotSet                 =  0,
        JsonBody               =  1,
        FormUrlEncodedBody     =  2,
        XmlBody                =  3,
        Endpoint               =  5,
        Path                   = 50,
        Query                  = 60,
        Header                 = 70
    }

    public enum SerializationOption
    {
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