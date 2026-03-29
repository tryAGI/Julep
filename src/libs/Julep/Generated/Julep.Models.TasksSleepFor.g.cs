
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksSleepFor
    {
        /// <summary>
        /// The number of seconds to sleep for<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Seconds { get; set; }

        /// <summary>
        /// The number of minutes to sleep for<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Minutes { get; set; }

        /// <summary>
        /// The number of hours to sleep for<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hours")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Hours { get; set; }

        /// <summary>
        /// The number of days to sleep for<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Days { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksSleepFor" /> class.
        /// </summary>
        /// <param name="seconds">
        /// The number of seconds to sleep for<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="minutes">
        /// The number of minutes to sleep for<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="hours">
        /// The number of hours to sleep for<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="days">
        /// The number of days to sleep for<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksSleepFor(
            int seconds,
            int minutes,
            int hours,
            int days)
        {
            this.Seconds = seconds;
            this.Minutes = minutes;
            this.Hours = hours;
            this.Days = days;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksSleepFor" /> class.
        /// </summary>
        public TasksSleepFor()
        {
        }
    }
}