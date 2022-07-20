using MessageCard.Builder.Builders;
using MessageCard.Builder.Objects;
using System;
using System.Collections.Generic;

namespace MessageCard.Builder
{
    /// <summary>
    /// Section buidler extensions.
    /// </summary>
    public static class SectionBuilderExtensions
    {
        /// <summary>
        /// Adds actions to the section.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="actions">A collection of actions that can be invoked on this section.</param>
        /// <returns></returns>
        public static SectionBuilder WithActions(this SectionBuilder builder, IEnumerable<IAction> actions)
        {
            builder.Actions = actions;

            return builder;
        }

        /// <summary>
        /// Adds actions to the section using a builder.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="actionsBuilderAction">An action builder action.</param>
        /// <returns></returns>
        public static SectionBuilder WithActions(this SectionBuilder builder, Action<IActionsBuilder<IAction>> actionsBuilderAction)
        {
            var actionsBuilder = new ActionsBuilder<IAction>();
            actionsBuilderAction(actionsBuilder);
            var actions = actionsBuilder.Build();
            return builder.WithActions(actions);
        }

        /// <summary>
        /// Adds activity details to the section.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="title">The title of the activity.</param>
        /// <param name="subtitle">The subtitle of the activity.</param>
        /// <param name="text">The text of the activity.</param>
        /// <param name="image">The image of the activity.</param>
        /// <returns></returns>
        public static SectionBuilder WithActivity(this SectionBuilder builder, string? title = null, string? subtitle = null, string? text = null, string? image = null)
        {
            builder.ActivityTitle = title;
            builder.ActivitySubTitle = subtitle;
            builder.ActivityText = text;
            builder.ActivityImage = image;

            return builder;
        }

        /// <summary>
        /// Adds facts to the section.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="facts">Facts are a very important component of a section. They often contain the information that really matters to the user.</param>
        /// <returns></returns>
        public static SectionBuilder WithFacts(this SectionBuilder builder, IEnumerable<Fact> facts)
        {
            builder.Facts = facts;

            return builder;
        }

        /// <summary>
        /// Adds facts to the section.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="facts">Facts are a very important component of a section. They often contain the information that really matters to the user.</param>
        /// <returns></returns>
        public static SectionBuilder WithFacts(this SectionBuilder builder, params Fact[] facts)
        {
            builder.Facts = facts;

            return builder;
        }

        /// <summary>
        /// Adds facts to the section.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="facts">Facts are a very important component of a section. They often contain the information that really matters to the user.</param>
        /// <returns></returns>
        public static SectionBuilder WithFacts(this SectionBuilder builder, IDictionary<string, string> facts)
        {
            return builder.WithFacts(facts.ToFacts());
        }

        /// <summary>
        /// Adds facts to the section using a builder.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="factsBuilderAction">The facts builder action.</param>
        /// <returns></returns>
        public static SectionBuilder WithFacts(this SectionBuilder builder, Action<IFactsBuilder> factsBuilderAction)
        {
            var factsBuilder = new FactsBuilder();
            factsBuilderAction(factsBuilder);
            var facts = factsBuilder.Build();

            return builder.WithFacts(facts);
        }

        /// <summary>
        /// Adds a hero image to the section.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="uri">The URL to the image.</param>
        /// <param name="title">A short description of the image.</param>
        /// <returns></returns>
        public static SectionBuilder WithHeroImage(this SectionBuilder builder, string uri, string title)
        {
            builder.HeroImage = new Image(uri, title);

            return builder;
        }

        /// <summary>
        /// Adds images to the section.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="images">The images to add to the section.</param>
        /// <returns></returns>
        public static SectionBuilder WithImages(this SectionBuilder builder, IEnumerable<Image> images)
        {
            builder.Images = images;

            return builder;
        }

        /// <summary>
        /// Adds images to the section.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="images">The images to add to the section.</param>
        /// <returns></returns>
        public static SectionBuilder WithImages(this SectionBuilder builder, params Image[] images)
        {
            builder.Images = images;

            return builder;
        }

        /// <summary>
        /// Adds images to the section using a builder.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="imagesBuilderAction">The images builder action.</param>
        /// <returns></returns>
        public static SectionBuilder WithImages(this SectionBuilder builder, Action<IImagesBuilder> imagesBuilderAction)
        {
            var imagesBuilder = new ImagesBuilder();
            imagesBuilderAction(imagesBuilder);
            var images = imagesBuilder.Build();
            return builder.WithImages(images);
        }

        /// <summary>
        /// Adds is start group to the section.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="isStartGroup">When set to true, the startGroup property marks the start of a logical group of information.</param>
        /// <returns></returns>
        public static SectionBuilder WithIsStartGroup(this SectionBuilder builder, bool isStartGroup)
        {
            builder.IsStartGroup = isStartGroup;

            return builder;
        }

        /// <summary>
        /// Adds text to the section.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="text">The section's text property is very similar to the text property of the card. It can be used for the same purpose.</param>
        /// <returns></returns>
        public static SectionBuilder WithText(this SectionBuilder builder, string text)
        {
            builder.Text = text;

            return builder;
        }

        /// <summary>
        /// Adds a title to the section.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="title">The title property of a section is displayed in a font that stands out while not as prominent as the card's title.</param>
        /// <returns></returns>
        public static SectionBuilder WithTitle(this SectionBuilder builder, string title)
        {
            builder.Title = title;

            return builder;
        }
    }
}