
#nullable enable

namespace Julep
{
    /// <summary>
    /// Image detail level
    /// </summary>
    public enum EntriesImageDetail
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
    public static class EntriesImageDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntriesImageDetail value)
        {
            return value switch
            {
                EntriesImageDetail.Auto => "auto",
                EntriesImageDetail.High => "high",
                EntriesImageDetail.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntriesImageDetail? ToEnum(string value)
        {
            return value switch
            {
                "auto" => EntriesImageDetail.Auto,
                "high" => EntriesImageDetail.High,
                "low" => EntriesImageDetail.Low,
                _ => null,
            };
        }
    }
}