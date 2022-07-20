using MessageCard.Builder.Objects;

namespace MessageCard.Builder
{
    /// <summary>
    /// 
    /// </summary>
    public interface IInputsBuilder
    {
        /// <summary>
        /// Adds an input to the builder.
        /// </summary>
        /// <param name="input">The input to add.</param>
        /// <returns></returns>
        IInputsBuilder AddInput(Input input);
    }
}