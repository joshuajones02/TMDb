using System;

namespace TMDb.Client
{
    internal static class StringExtensions
    {
        internal static bool IsNullOrEmpty(this string @string) =>
            string.IsNullOrEmpty(@string);

        internal static bool HasValue(this string @string) =>
            !string.IsNullOrEmpty(@string);

        internal static bool EqualsIgnoreCase(this string @string, string value) =>
            @string.Equals(value, StringComparison.InvariantCultureIgnoreCase);
    }
}