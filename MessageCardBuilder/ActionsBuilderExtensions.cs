using MessageCard.Builder.Builders;
using MessageCard.Builder.Objects;
using System;
using System.Collections.Generic;

namespace MessageCard.Builder
{
    /// <summary>
    /// Actions builder extensions
    /// </summary>
    public static class ActionsBuilderExtensions
    {
        /// <summary>
        /// Adds an action card.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="actionCard">The action card.</param>
        /// <returns></returns>
        public static IActionsBuilder<IAction> AddActionCard(this IActionsBuilder<IAction> builder, ActionCardAction actionCard)
        {
            return builder.AddAction(actionCard);
        }

        /// <summary>
        /// Adds an action card.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="name">The name property defines the text that will be displayed on screen for the action.</param>
        /// <param name="inputs">The inputs property defines the various inputs that will be displayed in the action card's UI.</param>
        /// <param name="actions">The actions property is an array of Action objects, that can be either of type OpenUri or HttpPOST.</param>
        /// <returns></returns>
        public static IActionsBuilder<IAction> AddActionCard(this IActionsBuilder<IAction> builder, string name, IEnumerable<Input> inputs, IEnumerable<IEmbeddableAction> actions)
        {
            var actionCard = new ActionCardAction(name, inputs, actions);
            return builder.AddAction(actionCard);
        }

        /// <summary>
        /// Adds an action card using input and action builders.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="name">The name property defines the text that will be displayed on screen for the action.</param>
        /// <param name="inputsBuilderAction">An input builder action.</param>
        /// <param name="actionsBuilderAction">An action builder action.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Adds a http post action.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="httpPostAction">The http post action.</param>
        /// <returns></returns>
        public static IActionsBuilder<IAction> AddHttpPost(this IActionsBuilder<IAction> builder, HttpPostAction httpPostAction)
        {
            return builder.AddAction(httpPostAction);
        }

        /// <summary>
        /// Adds a http post action.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="name">The name property defines the text that will be displayed on screen for the action.</param>
        /// <param name="target">Defines the URL endpoint of the service that implements the action.</param>
        /// <param name="body">The body of the POST request.</param>
        /// <param name="headers">A collection of <see cref="Header"/> objects representing a set of HTTP headers that will be emitted when sending the POST request to the target URL.</param>
        /// <param name="bodyContentType">Specifies the MIME type of the body in the POST request</param>
        /// <returns></returns>
        public static IActionsBuilder<IAction> AddHttpPost(this IActionsBuilder<IAction> builder, string name, string target, string body, IEnumerable<Header>? headers = null, BodyContentType? bodyContentType = null)
        {
            var httpPostAction = new HttpPostAction(name, target, body, headers, bodyContentType);
            return builder.AddHttpPost(httpPostAction);
        }

        /// <summary>
        /// Adds a http post action.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="httpPostAction">The http post action.</param>
        /// <returns></returns>
        public static IActionsBuilder<IEmbeddableAction> AddHttpPost(this IActionsBuilder<IEmbeddableAction> builder, HttpPostAction httpPostAction)
        {
            return builder.AddAction(httpPostAction);
        }

        /// <summary>
        /// Adds a http post action.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="name">The name property defines the text that will be displayed on screen for the action.</param>
        /// <param name="target">Defines the URL endpoint of the service that implements the action.</param>
        /// <param name="body">The body of the POST request.</param>
        /// <param name="headers">A collection of <see cref="Header"/> objects representing a set of HTTP headers that will be emitted when sending the POST request to the target URL.</param>
        /// <param name="bodyContentType">Specifies the MIME type of the body in the POST request</param>
        public static IActionsBuilder<IEmbeddableAction> AddHttpPost(this IActionsBuilder<IEmbeddableAction> builder, string name, string target, string body, IEnumerable<Header>? headers = null, BodyContentType bodyContentType = BodyContentType.Json)
        {
            var httpPostAction = new HttpPostAction(name, target, body, headers, bodyContentType);
            return builder.AddHttpPost(httpPostAction);
        }

        /// <summary>
        /// Adds an open uri action.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="openUriAction">The open uri action.</param>
        /// <returns></returns>
        public static IActionsBuilder<IAction> AddOpenUri(this IActionsBuilder<IAction> builder, OpenUriAction openUriAction)
        {
            return builder.AddAction(openUriAction);
        }

        /// <summary>
        /// Adds an open uri action.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="name">The name property defines the text that will be displayed on screen for the action.</param>
        /// <param name="targets">The targets property is a collection of name/value pairs that defines one URI per target operating system.</param>
        /// <returns></returns>
        public static IActionsBuilder<IAction> AddOpenUri(this IActionsBuilder<IAction> builder, string name, IEnumerable<Target> targets)
        {
            var openUriAction = new OpenUriAction(name, targets);
            return builder.AddOpenUri(openUriAction);
        }

        /// <summary>
        /// Adds an open uri action.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="name">The name property defines the text that will be displayed on screen for the action.</param>
        /// <param name="targets">The targets property is a collection of name/value pairs that defines one URI per target operating system.</param>
        /// <returns></returns>
        public static IActionsBuilder<IAction> AddOpenUri(this IActionsBuilder<IAction> builder, string name, params Target[] targets)
        {
            var openUriAction = new OpenUriAction(name, targets);
            return builder.AddOpenUri(openUriAction);
        }

        /// <summary>
        /// Adds an open uri action.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="name">The name property defines the text that will be displayed on screen for the action.</param>
        /// <param name="defaultUri">Creates a uri for the default operating system.</param>
        /// <returns></returns>
        public static IActionsBuilder<IAction> AddOpenUri(this IActionsBuilder<IAction> builder, string name, string defaultUri)
        {
            var openUriAction = new OpenUriAction(name, new[] { Target.ForDefault(defaultUri) });
            return builder.AddOpenUri(openUriAction);
        }

        /// <summary>
        /// Adds an open uri action.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="openUriAction">The open uri action.</param>
        /// <returns></returns>
        public static IActionsBuilder<IEmbeddableAction> AddOpenUri(this IActionsBuilder<IEmbeddableAction> builder, OpenUriAction openUriAction)
        {
            return builder.AddAction(openUriAction);
        }

        /// <summary>
        /// Adds an open uri action.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="name">The name property defines the text that will be displayed on screen for the action.</param>
        /// <param name="targets">The targets property is a collection of name/value pairs that defines one URI per target operating system.</param>
        /// <returns></returns>
        public static IActionsBuilder<IEmbeddableAction> AddOpenUri(this IActionsBuilder<IEmbeddableAction> builder, string name, IEnumerable<Target> targets)
        {
            var openUriAction = new OpenUriAction(name, targets);
            return builder.AddOpenUri(openUriAction);
        }

        /// <summary>
        /// Adds an open uri action.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="name">The name property defines the text that will be displayed on screen for the action.</param>
        /// <param name="targets">The targets property is a collection of name/value pairs that defines one URI per target operating system.</param>
        /// <returns></returns>
        public static IActionsBuilder<IEmbeddableAction> AddOpenUri(this IActionsBuilder<IEmbeddableAction> builder, string name, params Target[] targets)
        {
            var openUriAction = new OpenUriAction(name, targets);
            return builder.AddOpenUri(openUriAction);
        }

        /// <summary>
        /// Adds an open uri action.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="name">The name property defines the text that will be displayed on screen for the action.</param>
        /// <param name="defaultUri">Creates a uri for the default operating system.</param>
        /// <returns></returns>
        public static IActionsBuilder<IEmbeddableAction> AddOpenUri(this IActionsBuilder<IEmbeddableAction> builder, string name, string defaultUri)
        {
            var openUriAction = new OpenUriAction(name, new[] { Target.ForDefault(defaultUri) });
            return builder.AddOpenUri(openUriAction);
        }

    }
}