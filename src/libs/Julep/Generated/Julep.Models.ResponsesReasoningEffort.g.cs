
#nullable enable

namespace Julep
{
    /// <summary>
    /// Constraint effort on reasoning models.
    /// </summary>
    public enum ResponsesReasoningEffort
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesReasoningEffort value)
        {
            return value switch
            {
                ResponsesReasoningEffort.High => "high",
                ResponsesReasoningEffort.Low => "low",
                ResponsesReasoningEffort.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => ResponsesReasoningEffort.High,
                "low" => ResponsesReasoningEffort.Low,
                "medium" => ResponsesReasoningEffort.Medium,
                _ => null,
            };
        }
    }
}