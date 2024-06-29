using System.Configuration;
using System.Data;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Threading;
using Bootstrapper;

namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private IApplication? _application;
        private ApplicationBootstrapper? _bootstrapper;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            _bootstrapper = new ApplicationBootstrapper();
            _application = _bootstrapper.CreateApplication();
            MainWindow = _application.Run();
        }

        

        protected override void OnExit(ExitEventArgs e)
        {
            if (_bootstrapper != null)
            {
                _bootstrapper.Dispose();
            }
            base.OnExit(e);
        }
    }

}
