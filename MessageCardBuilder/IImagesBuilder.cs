using MessageCard.Builder.Objects;

namespace MessageCard.Builder
{
    /// <summary>
    /// 
    /// </summary>
    public interface IImagesBuilder
    {
        /// <summary>
        /// Adds an image to the buidler.
        /// </summary>
        /// <param name="image">The image to add.</param>
        /// <returns></returns>
        IImagesBuilder AddImage(Image image);
    }
}