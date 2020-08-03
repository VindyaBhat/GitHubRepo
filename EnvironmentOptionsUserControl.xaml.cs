using EnvironmentConfig.ViewModels;
using System.Windows.Controls;

namespace EnvironmentConfig
{
    /// <summary>
    /// Interaction logic for EnvironmentOptionsUserControl.xaml
    /// </summary>
    public partial class EnvironmentOptionsUserControl : UserControl
    {
        public EnvironmentOptionsUserControl()
        {
            InitializeComponent();
            DataContext = new EnvironmentOptionsViewModel();
        }
    }
}
