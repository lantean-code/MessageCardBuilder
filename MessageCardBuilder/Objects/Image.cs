using System.Text.Json.Serialization;

namespace MessageCard.Builder.Objects
{
    public class Image
    {
        public Image(string uri, string title)
        {
            Uri = uri;
            Title = title;
        }

        [JsonPropertyName("image")]
        public string Uri { get; }

        [JsonPropertyName("title")]
        public string Title { get; }
    }
}
