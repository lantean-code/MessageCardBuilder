using MessageCard.Builder.Objects;
using System;
using System.Collections.Generic;

namespace MessageCard.Builder.Builders
{
    /// <summary>
    /// A message builder.
    /// </summary>
    public class MessageBuilder
    {
        internal string? Title { get; set; }
        internal string? Text { get; set; }
        internal string? Summary { get; set; }
        internal Guid? CorrelationId { get; set; }
        internal IEnumerable<string>? ExpectedActors { get; set; }
        internal string? Originator { get; set; }
        internal string? ThemeColor { get; set; }
        internal bool? HideOriginalBody { get; set; }

        private List<Section>? _sections;
        private List<IAction>? _actions;

        internal MessageBuilder()
        {
        }

        internal void AddSection(Section section)
        {
            _sections ??= new List<Section>();
            _sections.Add(section);
        }

        internal void AddSections(IEnumerable<Section> sections)
        {
            _sections ??= new List<Section>();
            _sections.AddRange(sections);
        }

        internal void AddActions(IEnumerable<IAction> actions)
        {
            _actions ??= new List<IAction>();
            _actions.AddRange(actions);
        }

        /// <summary>
        /// Builds a new Slack Message from the builder.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public LegacyMessageCard Build()
        {
            var messageCard = new LegacyMessageCard(Title, Text, Summary, CorrelationId, ExpectedActors, Originator, ThemeColor, HideOriginalBody, _sections, _actions);

            return messageCard;
        }
    }
}