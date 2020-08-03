using EnvironmentConfig.Common;
using System.Linq;

namespace EnvironmentConfig.Model
{
    public class OptionSettings
    {
        public OptionSettings()
        {
            this.InitializePropertyHolders();
        }
        
        public PropertyHolder<string> NameHolder { get; set; }

        public PropertyHolder<bool> IsSelectedHolder { get; set; }
    }
}
