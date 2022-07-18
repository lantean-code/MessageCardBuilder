using MessageCard.Builder.Objects;
using System.Collections.Generic;
using System.Linq;

namespace MessageCard.Builder
{
    public static class FactExtensions
    {
        public static IEnumerable<Fact> ToFacts(this IDictionary<string, string> source)
        {
            return source.Select(element => new Fact(element.Key, element.Value)).ToList();
        }
    }
}