
#nullable enable

namespace Julep
{
    /// <summary>
    /// Default Value: switch<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksSwitchStepKind
    {
        /// <summary>
        /// 
        /// </summary>
        Switch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksSwitchStepKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksSwitchStepKind value)
        {
            return value switch
            {
                TasksSwitchStepKind.Switch => "switch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksSwitchStepKind? ToEnum(string value)
        {
            return value switch
            {
                "switch" => TasksSwitchStepKind.Switch,
                _ => null,
            };
        }
    }
}