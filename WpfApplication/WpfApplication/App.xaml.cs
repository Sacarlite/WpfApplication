using System.Configuration;
using System.Data;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Threading;
using Bootstrapper;
using Bootstrapper.Logging;

namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private IApplication? _application;
        private ApplicationBootstrapper? _bootstrapper;
        private IUnhendledExeptionHandler? _unhendledExeptionHandler;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            _bootstrapper = new ApplicationBootstrapper();
            DispatcherUnhandledException += OnUnhandledExeptionRised;
            _application = _bootstrapper.CreateApplication();
            MainWindow = _application.Run();
        }

        private void OnUnhandledExeptionRised(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            if (_bootstrapper is not null)
            {
                _unhendledExeptionHandler = _bootstrapper.CreateUnhendledExeptionHandler();
                _unhendledExeptionHandler.Handel(e);
            }
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
