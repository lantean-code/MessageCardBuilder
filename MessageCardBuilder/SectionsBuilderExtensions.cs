using MessageCard.Builder.Builders;
using MessageCard.Builder.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MessageCard.Builder
{
    public static class SectionsBuilderExtensions
    {
        public static ISectionsBuilder AddSection(
            this ISectionsBuilder builder,
            string title,
            bool? isStartGroup = null,
            string? activityTitle = null,
            string? activitySubtitle = null,
            string? activityText = null,
            string? activityImage = null,
            Image? heroImage = null,
            string? text = null,
            IEnumerable<Fact>? facts = null,
            IEnumerable<Image>? images = null,
            Action<IActionsBuilder<IAction>>? actionsBuilderAction = null)
        {
            IEnumerable<IAction>? actions = null;
            if (actionsBuilderAction is not null)
            {
                var actionsBuilder = new ActionsBuilder<IAction>();
                actionsBuilderAction(actionsBuilder);
                actions = actionsBuilder.Build();
            }

            var section = new Section(title, isStartGroup, activityTitle, activitySubtitle, activityText, activityImage, heroImage, text, facts, images, actions);

            return builder.AddSection(section);
        }

        public static ISectionsBuilder AddSection(this ISectionsBuilder builder, Action<SectionBuilder> sectionBuilderAction)
        {
            var sectionBuilder = new SectionBuilder();
            sectionBuilderAction(sectionBuilder);
            var section = sectionBuilder.Build();
            return builder.AddSection(section);
        }
    }
}
