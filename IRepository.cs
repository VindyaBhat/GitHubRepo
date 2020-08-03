using EnvironmentConfig.Model;
using System.Collections.Generic;

namespace EnvironmentConfig
{
    public interface IRepository
    {
         List<string> GetEnvironmentEnumList();

        List<OptionSettings> AddOptions(List<string> ListOfKeys);

        void SaveChangesToIniFile();
    }
}
