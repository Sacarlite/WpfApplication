using Autofac;
using Domain.Factories;
using Infrastructure;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VievModel.VievModels.MainVievModel;
using VievModel.Windows;

namespace Bootstrapper
{
    internal class Application : IApplication, IDisposable
    {
        private static readonly ILogger Logger = LogManager.GetLogger(nameof(Application));
        private readonly ILifetimeScope _applicationlifetimeScope;

        public Application(ILifetimeScope lifetimeScope)
        {
            Logger.Info("Create lifetimeScope");
            _applicationlifetimeScope = lifetimeScope.BeginLifetimeScope(RegisterDependencies);

        }


        public Window Run()
        {
            InitializeDependencies();
            _applicationlifetimeScope.Resolve<IWindowMementoWrapperInitializer>();
            var autorizationWindowVievModelFactory = _applicationlifetimeScope.Resolve<IWindowVievModelsFactory<IMainVievModel>>();
            var autorizationWindowVievModel = autorizationWindowVievModelFactory.Create();
            var windowManager = _applicationlifetimeScope.Resolve<IWindowManager>();
            var autorizationWindow = windowManager.Show(autorizationWindowVievModel);
            if (autorizationWindow is not Window window) throw new NotImplementedException();

            return window;
        }

        public void Dispose()
        {
            Logger.Info("Dispose Application");
            _applicationlifetimeScope.Dispose();
        }

        private static void RegisterDependencies(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterModule<Vievs.RegistrationModule>()
                .RegisterModule<VievModel.RegistrationModule>()
                .RegisterModule<Infrastructure.RegistrationModule>()
                .RegisterModule<RegistrationModule>();
        }

        private void InitializeDependencies()
        {
            var windowWrapperInitializer =
                _applicationlifetimeScope.Resolve<IEnumerable<IWindowMementoWrapperInitializer>>();
            foreach (var elem in windowWrapperInitializer) elem.initialize();
        }
    }

   
}
