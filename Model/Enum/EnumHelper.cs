using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace EnvironmentConfig.Model.Enum
{
    public static class EnumHelper
    {
        public static string GetEnumDescription(this EnvironmentOptions value)
        {
            var description = value.GetType()
                .GetMember(value.ToString())
                .FirstOrDefault()
                ?.GetCustomAttribute<DescriptionAttribute>()
                ?.Description;
            return description;
        }
    }
}
