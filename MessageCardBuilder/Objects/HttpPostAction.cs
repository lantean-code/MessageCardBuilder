using System.Collections.Generic;
using System.Linq;

namespace MessageCard.Builder.Objects
{
    /// <summary>
    /// Makes a call to an external Web service.
    /// 
    /// <a href="https://docs.microsoft.com/en-us/outlook/actionable-messages/message-card-reference#httppost-action">https://docs.microsoft.com/en-us/outlook/actionable-messages/message-card-reference#httppost-action</a>
    /// </summary>
    public class HttpPostAction : BaseAction, IEmbeddableAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpPostAction"/> class.
        /// </summary>
        /// <param name="name">The name property defines the text that will be displayed on screen for the action.</param>
        /// <param name="target">Defines the URL endpoint of the service that implements the action.</param>
        /// <param name="body">The body of the POST request.</param>
        /// <param name="headers">A collection of <see cref="Header"/> objects representing a set of HTTP headers that will be emitted when sending the POST request to the target URL.</param>
        /// <param name="bodyContentType">Specifies the MIME type of the body in the POST request</param>
        public HttpPostAction(
            string name,
            string target,
            string body,
            IEnumerable<Header>? headers = null,
            BodyContentType? bodyContentType = null) : base("HttpPOST", name)
        {
            Target = target;
            Body = body;
            Headers = headers ?? Enumerable.Empty<Header>();
            BodyContentType = bodyContentType;
        }

        /// <summary>
        /// Defines the URL endpoint of the service that implements the action.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("target")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("target")]
#endif
        public string Target { get; }

        /// <summary>
        /// A collection of <see cref="Header"/> objects representing a set of HTTP headers that will be emitted when sending the POST request to the target URL.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("headers")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("headers")]
#endif
        public IEnumerable<Header> Headers { get; }

        /// <summary>
        /// The body of the POST request.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("body")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("body")]
#endif
        public string Body { get; }

        /// <summary>
        /// The bodyContentType is optional and specifies the MIME type of the body in the POST request. Some services require that a content type be specified. Valid values are application/json and application/x-www-form-urlencoded. If not specified, application/json is assumed.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("bodyContentType")]
#elif SYSTEMTEXTJSON || DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("bodyContentType")]
#endif
        public BodyContentType? BodyContentType { get; }
    }
}