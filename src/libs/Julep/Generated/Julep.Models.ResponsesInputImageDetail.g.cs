
#nullable enable

namespace Julep
{
    /// <summary>
    /// The detail level of the image to be sent to the model. One of `high`, `low`, or `auto`. Defaults to `auto`.<br/>
    /// Default Value: auto
    /// </summary>
    public enum ResponsesInputImageDetail
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesInputImageDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesInputImageDetail value)
        {
            return value switch
            {
                ResponsesInputImageDetail.Auto => "auto",
                ResponsesInputImageDetail.High => "high",
                ResponsesInputImageDetail.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesInputImageDetail? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResponsesInputImageDetail.Auto,
                "high" => ResponsesInputImageDetail.High,
                "low" => ResponsesInputImageDetail.Low,
                _ => null,
            };
        }
    }
}