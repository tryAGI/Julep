
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobsJobStatus
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// When this resource was created as UTC date-time<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// When this resource was updated as UTC date-time<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Name of the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Reason for the current state of the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// Whether this Job supports progress updates<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasProgress { get; set; }

        /// <summary>
        /// Progress percentage<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Progress { get; set; }

        /// <summary>
        /// Current state of the job<br/>
        /// Default Value: pending
        /// </summary>
        /// <default>global::Julep.JobsJobState.Pending</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.JobsJobStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Julep.JobsJobState State { get; set; } = global::Julep.JobsJobState.Pending;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobsJobStatus" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the job
        /// </param>
        /// <param name="reason">
        /// Reason for the current state of the job
        /// </param>
        /// <param name="hasProgress">
        /// Whether this Job supports progress updates<br/>
        /// Default Value: false
        /// </param>
        /// <param name="progress">
        /// Progress percentage<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="state">
        /// Current state of the job<br/>
        /// Default Value: pending
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// When this resource was created as UTC date-time<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// When this resource was updated as UTC date-time<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobsJobStatus(
            string name,
            string reason,
            bool hasProgress,
            float progress,
            global::Julep.JobsJobState state,
            global::System.Guid id = default!,
            global::System.DateTime createdAt = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.HasProgress = hasProgress;
            this.Progress = progress;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobsJobStatus" /> class.
        /// </summary>
        public JobsJobStatus()
        {
        }
    }
}