using System.Collections.Generic;

namespace MessageCard.Builder.Objects
{
    /// <summary>
    /// <a href="https://docs.microsoft.com/en-us/outlook/actionable-messages/message-card-reference#using-sections">https://docs.microsoft.com/en-us/outlook/actionable-messages/message-card-reference#using-sections</a>
    /// 
    /// <a href="https://docs.microsoft.com/en-us/outlook/actionable-messages/message-card-reference#section-fields">https://docs.microsoft.com/en-us/outlook/actionable-messages/message-card-reference#section-fields</a>
    /// </summary>
    public class Section
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Section"/> class.
        /// </summary>
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
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("title")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("title")]
#endif
        public string? Title { get; internal set; }

        /// <summary>
        /// When set to true, the startGroup property marks the start of a logical group of information. Typically, sections with startGroup set to true will be visually separated from previous card elements. For example, Outlook uses a subtle horizontal separation line.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("startGroup")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("startGroup")]
#endif
        public bool IsStartGroup { get; internal set; } = false;

        /// <summary>
        /// The title of the activity. This is usually displayed at the top of the activity.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("activityTitle")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("activityTitle")]
#endif
        public string? ActivityTitle { get; internal set; }

        /// <summary>
        /// The subtitle of the activity. This is usually displayed under the title.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("activitySubtitle")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("activitySubtitle")]
#endif
        public string? ActivitySubtitle { get; internal set; }

        /// <summary>
        /// The text of the activity. This is usually displayed under the subtitle or title if subtitle is not present.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("activityText")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("activityText")]
#endif
        public string? ActivityText { get; internal set; }

        /// <summary>
        /// The image of the activity. This is usually displayed to the left of the activity title, subtitle and text.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("activityImage")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("activityImage")]
#endif
        public string? ActivityImage { get; internal set; }

        /// <summary>
        /// Use heroImage to make an image the centerpiece of your card. For example, a tweet that contains an image will want to put that image front and center:
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("heroImage")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("heroImage")]
#endif
        public Image? HeroImage { get; internal set; }

        /// <summary>
        /// The section's text property is very similar to the text property of the card. It can be used for the same purpose.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("text")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("text")]
#endif
        public string? Text { get; internal set; }

        /// <summary>
        /// Facts are a very important component of a section. They often contain the information that really matters to the user.
        /// Facts are displayed in such a way that they can be read quickly and efficiently.For example, in Outlook on the Web, facts are presented in a two-column layout, with fact names rendered in a slightly more prominent font:
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("facts")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("facts")]
#endif
        public IEnumerable<Fact>? Facts { get; internal set; }

        /// <summary>
        /// The images property allows for the inclusion of a photo gallery inside a section. That photo gallery will always be displayed in a way that is easy to consume regardless of the form factor of the device it is being viewed on. For instance, in Outlook on the Web, images might be displayed as a horizontal strip of thumbnails with controls allowing to scroll through the collection if it doesn't all fit on the screen. On mobile, images might be displayed as a single thumbnail, with the user able to swipe through the collection with their finger.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("images")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("images")]
#endif
        public IEnumerable<Image>? Images { get; internal set; }

        /// <summary>
        /// A collection of actions that can be invoked on this section.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("potentialAction")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("potentialAction")]
#endif
        public IEnumerable<IAction>? Actions { get; internal set; }
    }
}