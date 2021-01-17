using TMDb.Client.Attributes;

namespace TMDb.Client.Models
{
    public class ApiParameter
    {
        public ApiParameter(ApiParameterAttribute @params, string value) :
            this(@params.Name, @params.ParameterType, value)
        {
        }

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