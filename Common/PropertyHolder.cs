using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentConfig.Common
{
        public class PropertyHolder<T> : INotifyPropertyChanged
        {
            private Action<T> _onValueChanged = (t) => { };

            private T _value;
            public T Value
            {
                get { return _value; }
                set
                {
                    if (object.Equals(_value, default(T)) || !_value.Equals(value))
                    {
                        ChangeValue(value);
                    }
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            private void ChangeValue(T value)
            {
                _value = value;
                FirePropertyChanged(nameof(Value));
                _onValueChanged.Invoke(_value);
            }

            public void RegisterCallback(Action<T> onValueChanged)
            {
                _onValueChanged += onValueChanged;
            }

            private void FirePropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <summary>
        ///     Invoking initialization of properties through Reflection
        /// </summary>
        public static class ViewModelPropertyHolderExtensions
        {
            public static void InitializePropertyHolders(this object propertyHoldingObject)
            {
                var holdingObjectType = propertyHoldingObject.GetType();
                var properties = holdingObjectType.GetProperties();
                foreach (var property in properties)
                {
                    if (!property.PropertyType.IsGenericType)
                    {
                        continue;
                    }

                    if (property.PropertyType.GetGenericTypeDefinition() != typeof(PropertyHolder<>))
                    {
                        continue;
                    }

                    if (!property.CanRead)
                    {
                        continue;
                    }

                    if (!property.GetGetMethod(true).IsPublic)
                    {
                        continue;
                    }

                    if (!property.CanWrite)
                    {
                        continue;
                    }

                    if (!property.GetSetMethod(true).IsPublic)
                    {
                        continue;
                    }
                    var propertyValue = property.GetValue(propertyHoldingObject);
                    if (propertyValue != null)
                    {
                        continue;
                    }
                    var defaultValueForProperty = Activator.CreateInstance(property.PropertyType);
                    property.SetValue(propertyHoldingObject, defaultValueForProperty);
                }
            }
        }
}
