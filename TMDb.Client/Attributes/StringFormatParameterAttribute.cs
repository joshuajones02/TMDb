using System;

namespace TMDb.Client.Attributes
{
    internal sealed class StringFormatParameterAttribute : Attribute
    {
        public StringFormatParameterAttribute(string name) =>
            Name = name;

        public string Name { get; set; }
    }
}