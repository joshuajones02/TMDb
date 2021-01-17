using System;
using System.Collections.Generic;

namespace TMDb.Client
{
    internal static class TSourceExtensions
    {
        internal static IEnumerable<TSource> FromHierarchy<TSource>(this TSource source,
            Func<TSource, TSource> nextItem, Func<TSource, bool> canContinue)
        {
            for (var current = source; canContinue(current); current = nextItem(current))
                yield return current;
        }

        internal static IEnumerable<TSource> FromHierarchy<TSource>(this TSource source,
            Func<TSource, TSource> nextItem) where TSource : class =>
                source.FromHierarchy(nextItem, s => s != null);
    }
}