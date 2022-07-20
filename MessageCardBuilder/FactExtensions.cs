using MessageCard.Builder.Objects;
using System.Collections.Generic;
using System.Linq;

namespace MessageCard.Builder
{
    /// <summary>
    /// Fact extensions.
    /// </summary>
    public static class FactExtensions
    {
        /// <summary>
        /// Converts a dictionary to facts.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IReadOnlyList<Fact> ToFacts(this IDictionary<string, string> source)
        {
            return source.Select(element => new Fact(element.Key, element.Value)).ToList().AsReadOnly();
        }
    }
}