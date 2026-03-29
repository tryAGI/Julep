
#nullable enable

namespace Julep
{
    /// <summary>
    /// A summary of the reasoning performed by the model. This can be useful for debugging and understanding the model's reasoning process. One of `concise` or `detailed`.
    /// </summary>
    public enum ResponsesReasoningGenerateSummary
    {
        /// <summary>
        /// 
        /// </summary>
        Concise,
        /// <summary>
        /// 
        /// </summary>
        Detailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesReasoningGenerateSummaryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesReasoningGenerateSummary value)
        {
            return value switch
            {
                ResponsesReasoningGenerateSummary.Concise => "concise",
                ResponsesReasoningGenerateSummary.Detailed => "detailed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesReasoningGenerateSummary? ToEnum(string value)
        {
            return value switch
            {
                "concise" => ResponsesReasoningGenerateSummary.Concise,
                "detailed" => ResponsesReasoningGenerateSummary.Detailed,
                _ => null,
            };
        }
    }
}