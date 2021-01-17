using System;
using System.Linq;

namespace TMDb.Client
{
    internal static class ExceptionExtensions
    {
        internal static object Minify(this Exception ex) =>
            new
            {
                Type = ex?.GetType().Name,
                ex?.Message,
                ex?.StackTrace,
                InnerExceptions = ex.FromHierarchy(x => x.InnerException)
                                    .Select(x => new { Type = x?.GetType().Name, x?.Message, x?.StackTrace })
            };

        internal static string ToMinifiedString(this Exception ex) =>
            ex.Minify().ToJson();
    }
}