using EnvironmentConfig.Common;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace EnvironmentConfig.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private EnvironmentOptionsViewModel _environmentOptionsViewModel;
        private ViewModelBase _currentViewModel;
        private InstrumentOptionsViewModel _instrumentOptionsViewModel;
        public MainWindowViewModel()
        {
            this.InitializePropertyHolders();
            _environmentOptionsViewModel = new EnvironmentOptionsViewModel();
            _instrumentOptionsViewModel = new InstrumentOptionsViewModel();
            ListOfConfigurationSettings = new ObservableCollection<string>();
            CurrentViewModel = _environmentOptionsViewModel;
            Initializer();
            SelectedItem.Value = "Environment";
            SelectedItem.RegisterCallback(OnChangeOfSelectedItem);
            OkCommand = new RelayCommand(OnClickOfOkButton);
            CancelCommand = new RelayCommand(OnClickOfCancelButton);
        }


        public ObservableCollection<string> ListOfConfigurationSettings { get; set; }
        public PropertyHolder<string> SelectedItem { get; set; }

        public ICommand OkCommand { get; set; }

        public ICommand CancelCommand { get; set; }

        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel = value;
                OnPropertyChanged("CurrentViewModel");
            }
        }

        private void Initializer()
        {
            ListOfConfigurationSettings.Add("Environment");
            ListOfConfigurationSettings.Add("Instrument");
        }
        private void OnChangeOfSelectedItem(string selectedItem)
        {
            if (selectedItem == "Environment")
            {
                CurrentViewModel = _environmentOptionsViewModel;
            }
            else
            {
                CurrentViewModel = _instrumentOptionsViewModel;
            }
        }

        private void OnClickOfOkButton()
        {
            _environmentOptionsViewModel.SaveChanges();
        }

        private void OnClickOfCancelButton()
        {
            _environmentOptionsViewModel.Cancel();
        }
    }
}
