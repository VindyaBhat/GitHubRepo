using EnvironmentConfig.ViewModels;
using System.Windows.Controls;

namespace EnvironmentConfig
{
    /// <summary>
    /// Interaction logic for InstrumentOptionsUserControl.xaml
    /// </summary>
    public partial class InstrumentOptionsUserControl : UserControl
    {
        public InstrumentOptionsUserControl()
        {
            InitializeComponent();
            DataContext = new InstrumentOptionsViewModel();
        }
    }
}
