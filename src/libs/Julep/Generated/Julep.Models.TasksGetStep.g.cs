
#nullable enable

namespace Julep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksGetStep
    {
        /// <summary>
        /// Default Value: get<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind_")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Julep.JsonConverters.TasksGetStepKindJsonConverter))]
        public global::Julep.TasksGetStepKind Kind { get; set; } = default!;

        /// <summary>
        /// The key to get
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("get")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Get { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksGetStep" /> class.
        /// </summary>
        /// <param name="get">
        /// The key to get
        /// </param>
        /// <param name="kind">
        /// Default Value: get<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksGetStep(
            string get,
            global::Julep.TasksGetStepKind kind = default!)
        {
            this.Kind = kind;
            this.Get = get ?? throw new global::System.ArgumentNullException(nameof(get));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksGetStep" /> class.
        /// </summary>
        public TasksGetStep()
        {
        }

        /// <summary>
        /// Creates a new <see cref="TasksGetStep"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static TasksGetStep FromGet(string get)
        {
            return new TasksGetStep
            {
                Get = get,
            };
        }

    }
}