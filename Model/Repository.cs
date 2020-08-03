using EnvironmentConfig.Helper;
using EnvironmentConfig.Model.Enum;
using System.Collections.Generic;
using System.Linq;

namespace EnvironmentConfig.Model
{
    public class Repository : IRepository
    {

        private static List<OptionSettings> MainList { get; set; }

        public Repository()
        {
            MainList = new List<OptionSettings>();
        }

        private List<string> ListOfEnums = new List<string>
        {
            EnvironmentOptions.EnvironmentMode.GetEnumDescription(),
            EnvironmentOptions.OperationMode.GetEnumDescription(),
            EnvironmentOptions.StationConfig.GetEnumDescription(),
            EnvironmentOptions.StationName.GetEnumDescription(),
            EnvironmentOptions.TestResult.GetEnumDescription()
        };

        private List<string> IniFileValues = new List<string>
        {
            IniFileConfigurationHandler.Instance.EnvironmentMode,
            IniFileConfigurationHandler.Instance.OperationMode,
            IniFileConfigurationHandler.Instance.StationConfig,
            IniFileConfigurationHandler.Instance.StationName,
            IniFileConfigurationHandler.Instance.TestResult,
            IniFileConfigurationHandler.Instance.ToleranceCurveView.ToString(),
            IniFileConfigurationHandler.Instance.AndonLightTower.ToString()
        };

        public List<string> GetEnvironmentEnumList()
        {
            return ListOfEnums;
        }

        public List<OptionSettings> AddOptions(List<string> ListOfKeys)
        {
            List<OptionSettings> option = new List<OptionSettings>();
            foreach (var item in ListOfKeys)
            {
                string optionvalue = IniFileValues.FirstOrDefault(y => y == item);
                if (optionvalue != null)
                {
                    var optionSetting = new OptionSettings
                    {
                        NameHolder = { Value = item },
                        IsSelectedHolder = { Value = true }
                    };
                    option.Add(optionSetting);
                    MainList.Add(optionSetting);
                }
                else
                {
                    var optionSetting = new OptionSettings
                    {
                        NameHolder = { Value = item },
                        IsSelectedHolder = { Value = false }
                    };
                    option.Add(optionSetting);
                    MainList.Add(optionSetting);
                }
            }
            return option;
        }

        public void SaveChangesToIniFile()
        {
            var subListList = MainList.Select(x => x).Where(y => y.IsSelectedHolder.Value == true).ToList();
            IniFileConfigurationHandler.Instance.EnvironmentMode = subListList[0].NameHolder.Value;
            IniFileConfigurationHandler.Instance.OperationMode = subListList[1].NameHolder.Value;
            IniFileConfigurationHandler.Instance.StationConfig = subListList[2].NameHolder.Value;
            IniFileConfigurationHandler.Instance.StationName = subListList[3].NameHolder.Value;
            IniFileConfigurationHandler.Instance.WriteToIniFile();
        }
    }
}
