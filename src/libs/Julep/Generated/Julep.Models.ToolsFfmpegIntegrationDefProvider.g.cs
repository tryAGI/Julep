
#nullable enable

namespace Julep
{
    /// <summary>
    /// The provider must be "ffmpeg"<br/>
    /// Default Value: ffmpeg
    /// </summary>
    public enum ToolsFfmpegIntegrationDefProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Ffmpeg,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsFfmpegIntegrationDefProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsFfmpegIntegrationDefProvider value)
        {
            return value switch
            {
                ToolsFfmpegIntegrationDefProvider.Ffmpeg => "ffmpeg",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsFfmpegIntegrationDefProvider? ToEnum(string value)
        {
            return value switch
            {
                "ffmpeg" => ToolsFfmpegIntegrationDefProvider.Ffmpeg,
                _ => null,
            };
        }
    }
}