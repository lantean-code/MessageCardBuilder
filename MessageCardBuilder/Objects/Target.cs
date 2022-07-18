using System.Text.Json.Serialization;

namespace MessageCard.Builder.Objects
{
    /// <summary>
    /// 
    /// </summary>
    public class Target
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Target"/> class.
        /// </summary>
        /// <param name="operatingSystem">The operating system for which the target is designed.</param>
        /// <param name="uri">The uri to open.</param>
        public Target(TargetOs operatingSystem, string uri)
        {
            OperatingSystem = operatingSystem;
            Uri = uri;
        }

        /// <summary>
        /// The operating system for which the target is designed.
        /// </summary>
        [JsonPropertyName("os")]
        public TargetOs OperatingSystem { get; }

        /// <summary>
        /// The uri to open.
        /// </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; }

        public static Target ForDefault(string uri)
        {
            return new Target(TargetOs.Default, uri);
        }

        public static Target ForAndroid(string uri)
        {
            return new Target(TargetOs.Android, uri);
        }

        public static Target ForiOS(string uri)
        {
            return new Target(TargetOs.iOS, uri);
        }

        public static Target ForWindows(string uri)
        {
            return new Target(TargetOs.Windows, uri);
        }
    }
}
