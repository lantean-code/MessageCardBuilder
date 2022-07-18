using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace MessageCard.Builder.Objects
{
    public class HttpPostAction : BaseAction, IEmbeddableAction
    {
        /// <summary>
        /// Makes a call to an external Web service.
        /// 
        /// <a href="https://docs.microsoft.com/en-us/outlook/actionable-messages/message-card-reference#httppost-action">https://docs.microsoft.com/en-us/outlook/actionable-messages/message-card-reference#httppost-action</a>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="target"></param>
        /// <param name="body"></param>
        /// <param name="headers"></param>
        /// <param name="bodyContentType"></param>
        public HttpPostAction(
            string name,
            string target,
            string body,
            IEnumerable<Header>? headers = null,
            BodyContentType bodyContentType = BodyContentType.Json) : base("HttpPOST", name)
        {
            Target = target;
            Body = body;
            Headers = headers ?? Enumerable.Empty<Header>();
            BodyContentType = bodyContentType;
        }

        /// <summary>
        /// Defines the URL endpoint of the service that implements the action.
        /// </summary>
        [JsonPropertyName("target")]
        public string Target { get; }

        /// <summary>
        /// A collection of <see cref="Header"/> objects representing a set of
        /// HTTP headers that will be emitted when sending the POST request
        /// to the target URL.
        /// </summary>
        [JsonPropertyName("headers")]
        public IEnumerable<Header> Headers { get; }

        /// <summary>
        /// The body of the POST request.
        /// </summary>
        [JsonPropertyName("body")]
        public string Body { get; }

        /// <summary>
        /// Optional and specifies the MIME type of the body in the POST request.
        /// Some services require that a content type be specified.
        /// Valid values are application/json and application/x-www-form-urlencoded.
        /// If not specified, application/json is assumed.
        /// </summary>
        [JsonPropertyName("bodyContentType")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public BodyContentType BodyContentType { get; }
    }
}
