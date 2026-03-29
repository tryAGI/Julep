
#nullable enable

namespace Julep
{
    /// <summary>
    /// The kind of step<br/>
    /// Included only in responses
    /// </summary>
    public enum TasksSwitchStepEnumKind
    {
        /// <summary>
        /// 
        /// </summary>
        Switch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksSwitchStepEnumKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksSwitchStepEnumKind value)
        {
            return value switch
            {
                TasksSwitchStepEnumKind.Switch => "switch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksSwitchStepEnumKind? ToEnum(string value)
        {
            return value switch
            {
                "switch" => TasksSwitchStepEnumKind.Switch,
                _ => null,
            };
        }
    }
}