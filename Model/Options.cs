using EnvironmentConfig.Model.Enum;
using System.Collections.Generic;
using System;

namespace EnvironmentConfig.Model
{
    public static class Options
    {
        public static List<string> GetOptions(this string option)
        {
            if (option == EnvironmentOptions.EnvironmentMode.GetEnumDescription())
            {
                return GetEnvironmentModeList();
            }
            else if(option == EnvironmentOptions.OperationMode.GetEnumDescription())
            {
                return GetOperationModeList();
            }
            else if(option == EnvironmentOptions.StationConfig.GetEnumDescription())
            {
                return GetStationConfigList();
            }
            else if(option == EnvironmentOptions.StationName.GetEnumDescription())
            {
                return GetStationNameList();
            }
            else
            {
                return new List<string>();
            }
        }

        private static List<string> GetStationNameList()
        {
            List<string> ListOfOptions = new List<string>();
            ListOfOptions.Add("RF1");
            ListOfOptions.Add("RF2");
            return ListOfOptions;
        }

        private static List<string> GetEnvironmentModeList()
        {
            List<string> ListOfOptions = new List<string>();
            ListOfOptions.Add("Production");
            ListOfOptions.Add("UAT");
            ListOfOptions.Add("Development");
            return ListOfOptions;
        }

        private static List<string> GetOperationModeList()
        {
            List<string> ListOfOptions = new List<string>();
            ListOfOptions.Add("Camstar");
            ListOfOptions.Add("WOSM");
            return ListOfOptions;
        }

        private static List<string> GetStationConfigList()
        {
            List<string> ListOfOptions = new List<string>();
            ListOfOptions.Add("ITS_MODULE_TEST");
            ListOfOptions.Add("ITS_SMD_SPIPROG");
            ListOfOptions.Add("ITS_BTE_RSSI_TEST");
            return ListOfOptions;
        }
    }
}
