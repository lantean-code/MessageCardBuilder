using MessageCard.Builder.Builders;
using MessageCard.Builder.Objects;
using System;
using System.Collections.Generic;

namespace MessageCard.Builder
{
    /// <summary>
    /// Fluent builder for <see cref="LegacyMessageCard"/>s.
    /// </summary>
    public static class MessageBuilderExtensions
    {
        /// <summary>
        /// Adds a section to the message card.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="section">The section.</param>
        /// <returns></returns>
        public static MessageBuilder AddSection(this MessageBuilder builder, Section section)
        {
            builder.AddSection(section);
            return builder;
        }

        /// <summary>
        /// Adds a section using a builder.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="sectionBuilderAction">The section builder action.</param>
        /// <returns></returns>
        public static MessageBuilder AddSection(this MessageBuilder builder, Action<SectionBuilder> sectionBuilderAction)
        {
            var sectionBuilder = new SectionBuilder();
            sectionBuilderAction(sectionBuilder);
            var section = sectionBuilder.Build();
            builder.AddSection(section);
            return builder;
        }

        /// <summary>
        /// Adds actions to the message card.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="actions">The actions.</param>
        /// <returns></returns>
        public static MessageBuilder WithActions(this MessageBuilder builder, IEnumerable<IAction> actions)
        {
            builder.AddActions(actions);
            return builder;
        }

        /// <summary>
        /// Adds actions to the message card.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="actions">The actions.</param>
        /// <returns></returns>
        public static MessageBuilder WithActions(this MessageBuilder builder, params IAction[] actions)
        {
            builder.AddActions(actions);
            return builder;
        }

        /// <summary>
        /// Adds actions to the message card using a builder. 
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="actionsBuilderAction">The action builder action.</param>
        /// <returns></returns>
        public static MessageBuilder WithActions(this MessageBuilder builder, Action<IActionsBuilder<IAction>> actionsBuilderAction)
        {
            var actionsBuilder = new ActionsBuilder<IAction>();
            actionsBuilderAction(actionsBuilder);
            var section = actionsBuilder.Build();
            return builder.WithActions(section);
        }

        /// <summary>
        /// Adds a correlation id to the message card.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="correlationId">The correlationId property simplifies the process of locating logs for troubleshooting issues.</param>
        /// <returns></returns>
        public static MessageBuilder WithCorrelationId(this MessageBuilder builder, Guid correlationId)
        {
            builder.CorrelationId = correlationId;

            return builder;
        }

        /// <summary>
        /// Adds expected actors to the message card.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="expectedActors">This contains a list of expected email addresses of the recipient for the action endpoint.</param>
        /// <returns></returns>
        public static MessageBuilder WithExpectedActors(this MessageBuilder builder, IEnumerable<string> expectedActors)
        {
            builder.ExpectedActors = expectedActors;

            return builder;
        }

        /// <summary>
        /// Adds originator to the message card.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="originator">Required when sent via email, not applicable when sent via connector.</param>
        /// <returns></returns>
        public static MessageBuilder WithOriginator(this MessageBuilder builder, string originator)
        {
            builder.Originator = originator;

            return builder;
        }

        /// <summary>
        /// Adds sections to the message card.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="sections">The sections.</param>
        /// <returns></returns>
        public static MessageBuilder WithSections(this MessageBuilder builder, IEnumerable<Section> sections)
        {
            builder.AddSections(sections);
            return builder;
        }

        /// <summary>
        /// Adds sections to the message card using a builder.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="sectionsBuilderAction">The sections builder action.</param>
        /// <returns></returns>
        public static MessageBuilder WithSections(this MessageBuilder builder, Action<ISectionsBuilder> sectionsBuilderAction)
        {
            var sectionBuilder = new SectionsBuilder();
            sectionsBuilderAction(sectionBuilder);
            var sections = sectionBuilder.Build();
            return builder.WithSections(sections);
        }

        /// <summary>
        /// Adds a summary to the message card.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="summary">Required if the card does not contain a text property, otherwise optional. The summary property is typically displayed in the list view in Outlook, as a way to quickly determine what the card is all about.</param>
        /// <returns></returns>
        public static MessageBuilder WithSummary(this MessageBuilder builder, string summary)
        {
            builder.Summary = summary;

            return builder;
        }

        /// <summary>
        /// Adds text to the message card.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="text">Required if the card does not contain a summary property, otherwise optional. The text property is meant to be displayed in a normal font below the card's title. Use it to display content, such as the description of the entity being referenced, or an abstract of a news article.</param>
        /// <returns></returns>
        public static MessageBuilder WithText(this MessageBuilder builder, string text)
        {
            builder.Text = text;

            return builder;
        }

        /// <summary>
        /// Adds a title to the message card.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="title">The title property is meant to be rendered in a prominent way, at the very top of the card.</param>
        /// <returns></returns>
        public static MessageBuilder WithTitle(this MessageBuilder builder, string title)
        {
            builder.Title = title;

            return builder;
        }
    }
}