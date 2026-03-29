
#nullable enable

namespace Julep
{
    /// <summary>
    /// Represents a range of values to write
    /// </summary>
    public sealed partial class ToolsGoogleSheetsValueRange
    {
        /// <summary>
        /// The A1 notation of the range
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Range { get; set; }

        /// <summary>
        /// The values for the range (2D array)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>> Values { get; set; }

        /// <summary>
        /// The major dimension of the values<br/>
        /// Default Value: ROWS
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("major_dimension")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.ToolsGoogleSheetsValueRangeMajorDimensionJsonConverter))]
        public global::Julep.ToolsGoogleSheetsValueRangeMajorDimension? MajorDimension { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsGoogleSheetsValueRange" /> class.
        /// </summary>
        /// <param name="range">
        /// The A1 notation of the range
        /// </param>
        /// <param name="values">
        /// The values for the range (2D array)
        /// </param>
        /// <param name="majorDimension">
        /// The major dimension of the values<br/>
        /// Default Value: ROWS
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsGoogleSheetsValueRange(
            string range,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>> values,
            global::Julep.ToolsGoogleSheetsValueRangeMajorDimension? majorDimension)
        {
            this.Range = range ?? throw new global::System.ArgumentNullException(nameof(range));
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
            this.MajorDimension = majorDimension;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsGoogleSheetsValueRange" /> class.
        /// </summary>
        public ToolsGoogleSheetsValueRange()
        {
        }
    }
}