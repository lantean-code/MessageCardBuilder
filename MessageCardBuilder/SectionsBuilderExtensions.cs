using MessageCard.Builder.Builders;
using MessageCard.Builder.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MessageCard.Builder
{
    /// <summary>
    /// Sections builder extensions.
    /// </summary>
    public static class SectionsBuilderExtensions
    {
        /// <summary>
        /// Adds a new section to the card.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="title">The title property of a section is displayed in a font that stands out while not as prominent as the card's title.</param>
        /// <param name="isStartGroup">When set to true, the startGroup property marks the start of a logical group of information.</param>
        /// <param name="activityTitle">The title of the activity.</param>
        /// <param name="activitySubtitle">The subtitle of the activity.</param>
        /// <param name="activityText">The text of the activity.</param>
        /// <param name="activityImage">The image of the activity.</param>
        /// <param name="heroImage">Use heroImage to make an image the centerpiece of your card.</param>
        /// <param name="text">The section's text property is very similar to the text property of the card. It can be used for the same purpose.</param>
        /// <param name="facts">Facts are a very important component of a section. They often contain the information that really matters to the user.</param>
        /// <param name="images">The images property allows for the inclusion of a photo gallery inside a section.</param>
        /// <param name="actions">A collection of actions that can be invoked on this section.</param>
        /// <returns></returns>
        public static ISectionsBuilder AddSection(
            this ISectionsBuilder builder,
            string title,
            bool? isStartGroup = null,
            string? activityTitle = null,
            string? activitySubtitle = null,
            string? activityText = null,
            string? activityImage = null,
            Image? heroImage = null,
            string? text = null,
            IEnumerable<Fact>? facts = null,
            IEnumerable<Image>? images = null,
            IEnumerable<IAction>? actions = null)
        {
            var section = new Section(title, isStartGroup, activityTitle, activitySubtitle, activityText, activityImage, heroImage, text, facts, images, actions);

            return builder.AddSection(section);
        }

        /// <summary>
        /// Adds a new section to the card using a builder.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="sectionBuilderAction">The section buidler action.</param>
        /// <returns></returns>
        public static ISectionsBuilder AddSection(this ISectionsBuilder builder, Action<SectionBuilder> sectionBuilderAction)
        {
            var sectionBuilder = new SectionBuilder();
            sectionBuilderAction(sectionBuilder);
            var section = sectionBuilder.Build();
            return builder.AddSection(section);
        }
    }
}
