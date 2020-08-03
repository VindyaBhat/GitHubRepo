using System.ComponentModel;

namespace EnvironmentConfig.Model.Enum
{
    public enum InstrumentOptions
    {
        [Description("Supported Channels")]
        SupportedChannels,

        [Description("Audio Analyzer")]
        AudioAnalyzer,

        [Description("DUT Switch")]
        DUTSwicth
    }
}
