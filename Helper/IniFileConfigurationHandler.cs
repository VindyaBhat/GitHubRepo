namespace EnvironmentConfig.Helper
{
    public class IniFileConfigurationHandler 
    {
        private static IniFileConfigurationHandler _instance;

        private IniFileConfigurationHandler()
        {
        }

        public static IniFileConfigurationHandler Instance =>
            _instance ?? (_instance = new IniFileConfigurationHandler());

        public string EnvironmentMode { get;  set; }
        public string OperationMode { get;  set; }
        public string StationConfig { get;  set; }
        public string StationName { get; set; }
        public string TestResult { get; set; }
        public bool ToleranceCurveView { get;  set; }
        public bool AndonLightTower { get; set; }


        public void ReadFromIniFile()
        {
            EnvironmentMode = "Development";
            OperationMode = "WOSM";
            StationConfig = "ITS_MODULE_TEST";
            StationName = "RF1";
            TestResult = "abc";
            ToleranceCurveView = true;
            AndonLightTower = false;
        }

        //Write back to IniFile

        public void WriteToIniFile()
        {

        }
    }
}
