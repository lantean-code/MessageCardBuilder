using MessageCard.Builder.Objects;

namespace MessageCard.Builder
{
    /// <summary>
    /// Facts builder extensions.
    /// </summary>
    public static class FactsBuilderExtensions
    {
        /// <summary>
        /// Adds a fact.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="name">The name of the fact. Do keep fact names short. Avoid using Markdown formatting.</param>
        /// <param name="value">The value of the fact.</param>
        /// <returns></returns>
        public static IFactsBuilder AddFact(this IFactsBuilder builder, string name, string value)
        {
            builder.AddFact(new Fact(name, value));
            return builder;
        }
    }
}