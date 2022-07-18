using MessageCard.Builder.Objects;
using System;
using System.Collections.Generic;

namespace MessageCard.Builder.Builders
{
    public class SectionsBuilder : ISectionsBuilder
    {
        private readonly List<Section> _sections = new List<Section>();

        internal IReadOnlyList<Section> Build()
        {
            return _sections.AsReadOnly();
        }

        public ISectionsBuilder AddSection(Section section)
        {
            _sections.Add(section);
            return this;
        }
    }
}