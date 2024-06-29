using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VievModel.VievModels.MainVievModel;
using VievModel.Windows;
using Vievs;
using Vievs.Windows.MainWindow;

namespace Bootstrapper.Factory
{
    public class WindowFactory : IWindowFactory
    {
        private IComponentContext _componentContext;
        private readonly Dictionary<Type, Type> _map = new Dictionary<Type, Type>()
    {
           { typeof(IMainVievModel), typeof(IMainWindow)},
        
    };
        public WindowFactory(IComponentContext componentContext)
        {
            _componentContext = componentContext;
        }

        public IWindow Create<TWindowViewModel>(TWindowViewModel viewModel) where TWindowViewModel : IWindowViewModel
        {
            if (!_map.TryGetValue(typeof(TWindowViewModel), out var windowType))
                throw new InvalidOperationException($"There is no window registered for {typeof(TWindowViewModel)}");
            var instance = _componentContext.Resolve(windowType, TypedParameter.From(viewModel));
            return (IWindow)instance;
        }

     
    }
}
