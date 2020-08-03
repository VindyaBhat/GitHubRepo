using EnvironmentConfig.Common;
using System.Collections.ObjectModel;

namespace EnvironmentConfig.Model
{
    public class SubOptions
    {
        public SubOptions(string name, bool isOptionsChecked)
        {
            this.InitializePropertyHolders();
            OptionsName = name;
            IsOptionChecked.Value = isOptionsChecked;
        }

        public string OptionsName { get; set; }

        public PropertyHolder<bool> IsOptionChecked { get; set; }

    }
}
