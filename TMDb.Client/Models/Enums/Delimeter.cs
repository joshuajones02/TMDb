using System.ComponentModel;

namespace TMDb.Client.Enums
{
    // TODO: Store enum/descrtion kvp in cached dictionary
    public enum Delimeter
    {
        [Description(",")]
        And,

        [Description("|")]
        Or
    }
}