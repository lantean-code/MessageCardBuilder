using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MessageCard.Builder.Objects
{
    public class Section
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Section"/> class.
        /// </summary>
        /// <param name="title">The title property of a section is displayed in a font that stands out while not as prominent as the card's title. It is meant to introduce the section and summarize its content, similarly to how the card's title property is meant to summarize the whole card.</param>
        /// <param name="isStartGroup">When set to true, the startGroup property marks the start of a logical group of information. Typically, sections with startGroup set to true will be visually separated from previous card elements. For example, Outlook uses a subtle horizontal separation line.</param>
        /// <param name="activityTitle"></param>
        /// <param name="activitySubtitle"></param>
        /// <param name="activityText"></param>
        /// <param name="activityImage"></param>
        /// <param name="heroImage"></param>
        /// <param name="text"></param>
        /// <param name="facts"></param>
        /// <param name="images"></param>
        /// <param name="actions"></param>
        public Section(
            string? title = null,
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
            Title = title;
            IsStartGroup = isStartGroup ?? false;
            ActivityTitle = activityTitle;
            ActivitySubtitle = activitySubtitle;
            ActivityText = activityText;
            ActivityImage = activityImage;
            HeroImage = heroImage;
            Text = text;
            Facts = facts;
            Images = images;
            Actions = actions;
        }

        /// <summary>
        /// The title property of a section is displayed in a font that stands out while not as prominent as the card's title. It is meant to introduce the section and summarize its content, similarly to how the card's title property is meant to summarize the whole card.
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; internal set; }

        /// <summary>
        /// When set to true, the startGroup property marks the start of a logical group of information. Typically, sections with startGroup set to true will be visually separated from previous card elements. For example, Outlook uses a subtle horizontal separation line.
        /// </summary>
        [JsonPropertyName("startGroup")]
        public bool IsStartGroup { get; internal set; } = false;

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("activityTitle")]
        public string? ActivityTitle { get; internal set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("activitySubtitle")]
        public string? ActivitySubtitle { get; internal set; }

        /// <summary>
        /// /
        /// </summary>
        [JsonPropertyName("activityText")]
        public string? ActivityText { get; internal set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("activityImage")]
        public string? ActivityImage { get; internal set; }

        /// <summary>
        /// Use heroImage to make an image the centerpiece of your card. For example, a tweet that contains an image will want to put that image front and center:
        /// </summary>
        [JsonPropertyName("heroImage")]
        public Image? HeroImage { get; internal set; }

        /// <summary>
        /// The section's text property is very similar to the text property of the card. It can be used for the same purpose.
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; internal set; }

        /// <summary>
        /// Facts are a very important component of a section. They often contain the information that really matters to the user.
        /// Facts are displayed in such a way that they can be read quickly and efficiently.For example, in Outlook on the Web, facts are presented in a two-column layout, with fact names rendered in a slightly more prominent font:
        /// </summary>
        [JsonPropertyName("facts")]
        public IEnumerable<Fact>? Facts { get; internal set; }

        /// <summary>
        /// The images property allows for the inclusion of a photo gallery inside a section. That photo gallery will always be displayed in a way that is easy to consume regardless of the form factor of the device it is being viewed on. For instance, in Outlook on the Web, images might be displayed as a horizontal strip of thumbnails with controls allowing to scroll through the collection if it doesn't all fit on the screen. On mobile, images might be displayed as a single thumbnail, with the user able to swipe through the collection with their finger.
        /// </summary>
        [JsonPropertyName("images")]
        public IEnumerable<Image>? Images { get; internal set; }

        /// <summary>
        /// A collection of actions that can be invoked on this section.
        /// </summary>
        [JsonPropertyName("potentialAction")]
        public IEnumerable<IAction>? Actions { get; internal set; }
    }
}
