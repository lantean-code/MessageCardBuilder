using MessageCard.Builder.Objects;
using System.Collections.Generic;

namespace MessageCard.Builder.Builders
{
    public class SectionBuilder
    {
        internal string? Title { get; set; }
        internal bool? IsStartGroup { get; set; }
        internal string? ActivityTitle { get; set; }
        internal string? ActivitySubTitle { get; set; }
        internal string? ActivityText { get; set; }
        internal string? ActivityImage { get; set; }
        internal Image? HeroImage { get; set; }
        internal string? Text { get; set; }
        internal IEnumerable<Fact>? Facts { get; set; }
        internal IEnumerable<Image>? Images { get; set; }
        internal IEnumerable<IAction>? Actions { get; set; }

        internal Section Build()
        {
            return new Section(
                Title,
                IsStartGroup,
                ActivityTitle,
                ActivitySubTitle,
                ActivityText,
                ActivityImage,
                HeroImage,
                Text,
                Facts,
                Images,
                Actions);
        }
    }
}
