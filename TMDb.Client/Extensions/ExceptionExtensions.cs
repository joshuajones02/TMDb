using System;
using System.Linq;

namespace TMDb.Client.Extensions
{
    public static class ExceptionExtensions
    {
        public static object Minify(this Exception ex) => 
            new
            {
                Type            = ex?.GetType().Name,
                Message         = ex?.Message,
                StackTrace      = ex?.StackTrace,
                InnerExceptions = ex.FromHierarchy(x => x.InnerException)
                                    .Select(x => new { Type = x?.GetType().Name, x?.Message, x?.StackTrace })
            };

        public static string ToMinifiedString(this Exception ex) => 
            ex.Minify().ToJson();
    }
}