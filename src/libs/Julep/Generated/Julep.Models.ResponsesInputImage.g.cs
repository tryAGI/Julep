
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesInputImage
    {
        /// <summary>
        /// The type of the input item. Always `input_image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesInputImageTypeJsonConverter))]
        public global::Julep.ResponsesInputImageType Type { get; set; }

        /// <summary>
        /// The URL of the image to be sent to the model. A fully qualified URL or base64 encoded image in a data URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// The ID of the file to be sent to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// The detail level of the image to be sent to the model. One of `high`, `low`, or `auto`. Defaults to `auto`.<br/>
        /// Default Value: auto
        /// </summary>
        /// <default>global::Julep.ResponsesInputImageDetail.Auto</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ResponsesInputImageDetailJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.ResponsesInputImageDetail Detail { get; set; } = global::Julep.ResponsesInputImageDetail.Auto;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesInputImage" /> class.
        /// </summary>
        /// <param name="detail">
        /// The detail level of the image to be sent to the model. One of `high`, `low`, or `auto`. Defaults to `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="type">
        /// The type of the input item. Always `input_image`.
        /// </param>
        /// <param name="imageUrl">
        /// The URL of the image to be sent to the model. A fully qualified URL or base64 encoded image in a data URL.
        /// </param>
        /// <param name="fileId">
        /// The ID of the file to be sent to the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesInputImage(
            global::Julep.ResponsesInputImageDetail detail,
            global::Julep.ResponsesInputImageType type,
            string? imageUrl,
            string? fileId)
        {
            this.Type = type;
            this.ImageUrl = imageUrl;
            this.FileId = fileId;
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesInputImage" /> class.
        /// </summary>
        public ResponsesInputImage()
        {
        }

    }
}