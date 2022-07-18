using MessageCard.Builder.Builders;
using MessageCard.Builder.Objects;
using System;
using System.Collections.Generic;

namespace MessageCard.Builder
{
    /// <summary>
    /// Fluent builder for <see cref="Objects.LegacyMessageCard"/>s.
    /// </summary>
    public static class MessageBuilderExtensions
    {
        public static MessageBuilder WithText(this MessageBuilder builder, string text)
        {
            builder.Text = text;

            return builder;
        }

        public static MessageBuilder WithTitle(this MessageBuilder builder, string title)
        {
            builder.Title = title;

            return builder;
        }

        public static MessageBuilder WithCorrelationId(this MessageBuilder builder, Guid correlationId)
        {
            builder.CorrelationId = correlationId;

            return builder;
        }

        public static MessageBuilder WithExpectedActors(this MessageBuilder builder, IEnumerable<string> expectedActors)
        {
            builder.ExpectedActors = expectedActors;

            return builder;
        }

        public static MessageBuilder WithOriginator(this MessageBuilder builder, string originator)
        {
            builder.Originator = originator;

            return builder;
        }

        public static MessageBuilder AddSection(this MessageBuilder builder, Action<SectionBuilder> sectionBuilderAction)
        {
            var sectionBuilder = new SectionBuilder();
            sectionBuilderAction(sectionBuilder);
            var section = sectionBuilder.Build();
            builder.AddSection(section);
            return builder;
        }

        public static MessageBuilder WithSections(this MessageBuilder builder, IEnumerable<Section> sections)
        {
            builder.AddSections(sections);
            return builder;
        }

        public static MessageBuilder WithSections(this MessageBuilder builder, Action<ISectionsBuilder> sectionBuilderAction)
        {
            var sectionBuilder = new SectionsBuilder();
            sectionBuilderAction(sectionBuilder);
            var sections = sectionBuilder.Build();
            return builder.WithSections(sections);
        }

        public static MessageBuilder WithActions(this MessageBuilder builder, IEnumerable<IAction> actions)
        {
            builder.AddActions(actions);
            return builder;
        }

        public static MessageBuilder WithActions(this MessageBuilder builder, Action<IActionsBuilder<IAction>> actionsBuilderAction)
        {
            var actionsBuilder = new ActionsBuilder<IAction>();
            actionsBuilderAction(actionsBuilder);
            var section = actionsBuilder.Build();
            return builder.WithActions(section);
        }
    }
}