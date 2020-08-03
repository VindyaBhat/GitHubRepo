using System.ComponentModel;

namespace EnvironmentConfig.Model.Enum
{
    public enum EnvironmentOptions
    {
        [Description("Environment Mode")]
        EnvironmentMode,

        [Description("Operation Mode")]
        OperationMode,

        [Description ("Station Config")]
        StationConfig,

        [Description("Station Name")]
        StationName,

        [Description("Test Result")]
        TestResult
    }
}
