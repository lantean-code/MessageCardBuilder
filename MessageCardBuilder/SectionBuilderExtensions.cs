using MessageCard.Builder.Builders;
using MessageCard.Builder.Objects;
using System;
using System.Collections.Generic;

namespace MessageCard.Builder
{
    public static class SectionBuilderExtensions
    {
        public static SectionBuilder WithTitle(this SectionBuilder builder, string title)
        {
            builder.Title = title;

            return builder;
        }

        public static SectionBuilder WithIsStartGroup(this SectionBuilder builder, bool isStartGroup)
        {
            builder.IsStartGroup = (isStartGroup);

            return builder;
        }

        public static SectionBuilder WithActivity(this SectionBuilder builder, string? title = null, string? subtitle = null, string? text = null, string? image = null)
        {
            builder.ActivityTitle = title;
            builder.ActivitySubTitle = subtitle;
            builder.ActivityText = title;
            builder.ActivityImage = image;

            return builder;
        }

        public static SectionBuilder WithHeroImage(this SectionBuilder builder, string uri, string title)
        {
            builder.HeroImage = new Image(uri, title);

            return builder;
        }

        public static SectionBuilder WithText(this SectionBuilder builder, string text)
        {
            builder.Text = text;

            return builder;
        }

        public static SectionBuilder WithFacts(this SectionBuilder builder, IEnumerable<Fact> facts)
        {
            builder.Facts = facts;

            return builder;
        }

        public static SectionBuilder WithFacts(this SectionBuilder builder, params Fact[] facts)
        {
            builder.Facts = facts;

            return builder;
        }

        public static SectionBuilder WithFacts(this SectionBuilder builder, IDictionary<string, string> facts)
        {
            builder.Facts = facts.ToFacts();

            return builder;
        }

        public static SectionBuilder WithImages(this SectionBuilder builder, IEnumerable<Image> images)
        {
            builder.Images = images;

            return builder;
        }

        public static SectionBuilder WithImages(this SectionBuilder builder, params Image[] images)
        {
            builder.Images = images;

            return builder;
        }

        public static SectionBuilder WithActions(this SectionBuilder builder, IEnumerable<IAction> actions)
        {
            builder.Actions = actions;

            return builder;
        }

        public static SectionBuilder WithActions(this SectionBuilder builder, Action<IActionsBuilder<IAction>> actionsBuilderAction)
        {
            var actionsBuilder = new ActionsBuilder<IAction>();
            actionsBuilderAction(actionsBuilder);
            var actions = actionsBuilder.Build();
            return builder.WithActions(actions);
        }
    }
}