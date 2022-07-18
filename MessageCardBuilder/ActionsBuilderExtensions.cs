using MessageCard.Builder.Builders;
using MessageCard.Builder.Objects;
using System;
using System.Collections.Generic;

namespace MessageCard.Builder
{
    public static class ActionsBuilderExtensions
    {
        public static IActionsBuilder<IAction> AddActionCard(this IActionsBuilder<IAction> builder, ActionCardAction actionCard)
        {
            return builder.AddAction(actionCard);
        }

        public static IActionsBuilder<IAction> AddActionCard(this IActionsBuilder<IAction> builder, string name, IEnumerable<Input> inputs, IEnumerable<IEmbeddableAction> actions)
        {
            var actionCard = new ActionCardAction(name, inputs, actions);
            return builder.AddAction(actionCard);
        }

        public static IActionsBuilder<IAction> AddActionCard(this IActionsBuilder<IAction> builder, string name, Action<IInputsBuilder> inputsBuilderAction, Action<IActionsBuilder<IEmbeddableAction>> actionsBuilderAction)
        {
            var inputsBuilder = new InputsBuilder();
            inputsBuilderAction(inputsBuilder);
            var inputs = inputsBuilder.Build();

            var actionsBuilder = new ActionsBuilder<IEmbeddableAction>();
            actionsBuilderAction(actionsBuilder);
            var actions = actionsBuilder.Build();

            var actionCard = new ActionCardAction(name, inputs, actions);
            return builder.AddAction(actionCard);
        }

        public static IActionsBuilder<IAction> AddHttpPost(this IActionsBuilder<IAction> builder, HttpPostAction httpPostAction)
        {
            return builder.AddAction(httpPostAction);
        }

        public static IActionsBuilder<IAction> AddHttpPost(this IActionsBuilder<IAction> builder, string name, string target, string body, IEnumerable<Header>? headers = null, BodyContentType bodyContentType = BodyContentType.Json)
        {
            var httpPostAction = new HttpPostAction(name, target, body, headers, bodyContentType);
            return builder.AddHttpPost(httpPostAction);
        }

        public static IActionsBuilder<IEmbeddableAction> AddHttpPost(this IActionsBuilder<IEmbeddableAction> builder, HttpPostAction httpPostAction)
        {
            return builder.AddAction(httpPostAction);
        }

        public static IActionsBuilder<IEmbeddableAction> AddHttpPost(this IActionsBuilder<IEmbeddableAction> builder, string name, string target, string body, IEnumerable<Header>? headers = null, BodyContentType bodyContentType = BodyContentType.Json)
        {
            var httpPostAction = new HttpPostAction(name, target, body, headers, bodyContentType);
            return builder.AddHttpPost(httpPostAction);
        }

        public static IActionsBuilder<IAction> AddOpenUri(this IActionsBuilder<IAction> builder, OpenUriAction openUriAction)
        {
            return builder.AddAction(openUriAction);
        }

        public static IActionsBuilder<IAction> AddOpenUri(this IActionsBuilder<IAction> builder, string name, IEnumerable<Target> targets)
        {
            var openUriAction = new OpenUriAction(name, targets);
            return builder.AddOpenUri(openUriAction);
        }

        public static IActionsBuilder<IAction> AddOpenUri(this IActionsBuilder<IAction> builder, string name, params Target[] targets)
        {
            var openUriAction = new OpenUriAction(name, targets);
            return builder.AddOpenUri(openUriAction);
        }

        public static IActionsBuilder<IEmbeddableAction> AddOpenUri(this IActionsBuilder<IEmbeddableAction> builder, OpenUriAction openUriAction)
        {
            return builder.AddAction(openUriAction);
        }

        public static IActionsBuilder<IEmbeddableAction> AddOpenUri(this IActionsBuilder<IEmbeddableAction> builder, string name, IEnumerable<Target> targets)
        {
            var openUriAction = new OpenUriAction(name, targets);
            return builder.AddOpenUri(openUriAction);
        }

        public static IActionsBuilder<IEmbeddableAction> AddOpenUri(this IActionsBuilder<IEmbeddableAction> builder, string name, params Target[] targets)
        {
            var openUriAction = new OpenUriAction(name, targets);
            return builder.AddOpenUri(openUriAction);
        }
    }
}