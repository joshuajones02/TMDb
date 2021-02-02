using System.ComponentModel;

namespace TMDb.Client.Enums
{
    public enum Delimeter
    {
        [Description(",")]
        And,

        [Description("|")]
        Or
    }
}