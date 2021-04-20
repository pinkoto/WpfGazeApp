using System.Windows;
using Tobii.InteractionLib.Wpf;

namespace WpfGazeApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            ((App)Application.Current).IntlibWpf?.WpfBinding?.AddWindow(this);

            InitializeComponent();
        }

    }
}
