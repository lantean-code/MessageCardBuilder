using MessageCard.Builder.Objects;
using System.Collections.Generic;

namespace MessageCard.Builder.Builders
{
    internal class FactsBuilder : IFactsBuilder
    {
        private readonly List<Fact> _inputs = new List<Fact>();

        internal IReadOnlyList<Fact> Build()
        {
            return _inputs.AsReadOnly();
        }

        public IFactsBuilder AddFact(Fact fact)
        {
            _inputs.Add(fact);
            return this;
        }
    }
}