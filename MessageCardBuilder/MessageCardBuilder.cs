using MessageCard.Builder.Builders;
using MessageCard.Builder.Objects;

namespace MessageCard.Builder
{
    /// <summary>
    /// Fluent builder for <see cref="LegacyMessageCard"/>s.
    /// </summary>
    public static class MessageCardBuilder
    {
        /// <summary>
        /// Creates a new instance of the fluent message builder.
        /// </summary>
        /// <returns></returns>
        public static MessageBuilder CreateMessageCard()
        {
            return new MessageBuilder();
        }
    }
}