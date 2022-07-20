using MessageCard.Builder.Objects;

namespace MessageCard.Builder
{
    /// <summary>
    /// 
    /// </summary>
    public interface IFactsBuilder
    {
        /// <summary>
        /// Adds a fact to the builder.
        /// </summary>
        /// <param name="fact">The fact</param>
        /// <returns></returns>
        IFactsBuilder AddFact(Fact fact);
    }
}