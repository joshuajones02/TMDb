using System;
using TMDb.Client.Attributes;

namespace TMDb.Client.Models
{
    public class ApiParameter
    {            
        public ApiParameter(string name, ParameterType type, string value)
        {
            ParameterType = type;
            Name = name;
            Value = value;
        }

        public string Name { get; set; }
        public string Value { get; set; }
        public ParameterType ParameterType { get; set; }
    }
}