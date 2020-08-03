using EnvironmentConfig.ViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace EnvironmentConfig
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
