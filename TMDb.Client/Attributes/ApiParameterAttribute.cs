using System;

namespace TMDb.Client.Attributes
{
    public enum ParameterType
    {
        JsonBody               =  1,
        FormUrlEncodedBody     =  2,
        XmlBody                =  3,
        Endpoint               =  5,
        Path                   = 50,
        Query                  = 60,
        Header                 = 70
    }

    public sealed class ApiParameterAttribute : Attribute
    {
        public ApiParameterAttribute()
        {
        }

        public ApiParameterAttribute(ParameterType type) => 
            ParameterType = type;

        public ApiParameterAttribute(ParameterType type, string name)
        {
            ParameterType = type;
            Name = name;
        }

        public ApiParameterAttribute(string name, ParameterType type)
        {
            ParameterType = type;
            Name = name;
        }

        public string Name { get; set; }
        public string Value { get; set; }
        public ParameterType ParameterType { get; set; }
    }
}