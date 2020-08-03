using EnvironmentConfig.Common;
using EnvironmentConfig.Helper;
using EnvironmentConfig.Model;
using System.Collections.ObjectModel;

namespace EnvironmentConfig.ViewModels
{
    public class EnvironmentOptionsViewModel : ViewModelBase
    {
        public EnvironmentOptionsViewModel()
        {
            this.InitializePropertyHolders();
            Items = new ObservableCollection<string>();
            ListOfOptions = new ObservableCollection<OptionSettings>();
            DataRepository = new Repository();
            InitializeOptions();
            SelectedEnvironmentOptionHolder.RegisterCallback(GetListOfOptions);
        }

        public ObservableCollection<string> Items { get; set; }

        public PropertyHolder<string> SelectedEnvironmentOptionHolder { get; set; }

        public ObservableCollection<OptionSettings> ListOfOptions { get; set; }
       

        public Repository DataRepository { get; set; }

        

        private void InitializeOptions()
        {
            IniFileConfigurationHandler.Instance.ReadFromIniFile();
            foreach (var item1 in DataRepository.GetEnvironmentEnumList())
            {
                Items.Add(item1);
            }
        }

        private void GetListOfOptions(string selectedOption)
        {
            if(ListOfOptions != null)
            {
                ListOfOptions?.Clear();
            }
            var test = Options.GetOptions(selectedOption);
            var fullList = DataRepository.AddOptions(test);
            foreach(var item in fullList)
            {
                ListOfOptions.Add(item);
            }
        }

        public void SaveChanges()
        {
            DataRepository.SaveChangesToIniFile();
        }

        public void Cancel()
        {
           
        }
    }
}
