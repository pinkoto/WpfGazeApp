using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfGazeApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public Tobii.InteractionLib.Wpf.InteractionLibWpfHost IntlibWpf { get; private set; }

        protected override void OnStartup(StartupEventArgs e) => IntlibWpf = new Tobii.InteractionLib.Wpf.InteractionLibWpfHost();

        // This function is called when the application exits.
        protected override void OnExit(ExitEventArgs e)
        {
            IntlibWpf?.Dispose();

            base.OnExit(e);
        }
    }
}
