namespace MessageCard.Builder.Objects
{
    /// <summary>
    /// Targets allow you to specify different URIs for different operating systems.
    /// </summary>
    public class Target
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Target"/> class.
        /// </summary>
        /// <param name="operatingSystem">The operating system for which the target is designed.</param>
        /// <param name="uri">The uri to open.</param>
        public Target(TargetOperatingSystem operatingSystem, string uri)
        {
            OperatingSystem = operatingSystem;
            Uri = uri;
        }

        /// <summary>
        /// The operating system for which the target is designed.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("os")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("os")]
#endif
        public TargetOperatingSystem OperatingSystem { get; }

        /// <summary>
        /// The uri to open.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("uri")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("uri")]
#endif
        public string Uri { get; }

        /// <summary>
        /// Creates a target for the default operating system.
        /// </summary>
        /// <param name="uri">The uri to open.</param>
        /// <returns></returns>
        public static Target ForDefault(string uri)
        {
            return new Target(TargetOperatingSystem.Default, uri);
        }

        /// <summary>
        /// Creates a target for the Android operating system.
        /// </summary>
        /// <param name="uri">The uri to open.</param>
        /// <returns></returns>
        public static Target ForAndroid(string uri)
        {
            return new Target(TargetOperatingSystem.Android, uri);
        }

        /// <summary>
        /// Creates a target for the iOS operating system.
        /// </summary>
        /// <param name="uri">The uri to open.</param>
        /// <returns></returns>
        public static Target ForiOS(string uri)
        {
            return new Target(TargetOperatingSystem.iOS, uri);
        }

        /// <summary>
        /// Creates a target for the Windows operating system.
        /// </summary>
        /// <param name="uri">The uri to open.</param>
        /// <returns></returns>
        public static Target ForWindows(string uri)
        {
            return new Target(TargetOperatingSystem.Windows, uri);
        }
    }
}