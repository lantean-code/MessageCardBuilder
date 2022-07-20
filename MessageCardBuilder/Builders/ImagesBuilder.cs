using MessageCard.Builder.Objects;
using System.Collections.Generic;

namespace MessageCard.Builder.Builders
{
    internal class ImagesBuilder : IImagesBuilder
    {
        private readonly List<Image> _inputs = new List<Image>();

        internal IReadOnlyList<Image> Build()
        {
            return _inputs.AsReadOnly();
        }

        public IImagesBuilder AddImage(Image image)
        {
            _inputs.Add(image);
            return this;
        }
    }
}