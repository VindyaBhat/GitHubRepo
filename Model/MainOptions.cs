using EnvironmentConfig.Common;
using System.Collections.ObjectModel;
using System;

namespace EnvironmentConfig.Model
{
    public class MainOptions
    {
        public MainOptions(string title)
        {
            this.InitializePropertyHolders();
            Title = title;
            IsExpanderExpanded.RegisterCallback(x =>
            {
                _setExpanderExpandState?.Invoke(title, IsExpanderExpanded.Value);
            });
        }

        public static Action<string, bool> _setExpanderExpandState;

        public string Title { get; set; }
        public PropertyHolder<bool> IsExpanderExpanded { get; set; }

        public ObservableCollection<SubOptions> ListItems { get; } = new ObservableCollection<SubOptions>();
        

        public void AddItemsToList(SubOptions environmentOptionsList)
        {
            ListItems.Add(environmentOptionsList);
        }
    }
}
