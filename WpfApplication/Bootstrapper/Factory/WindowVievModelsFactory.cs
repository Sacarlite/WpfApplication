using Autofac;
using Domain.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootstrapper.Factory
{
    public class WindowVievModelsFactory<TResult> : IWindowVievModelsFactory<TResult>
    {
        private readonly IComponentContext _componentContext;

        public WindowVievModelsFactory(IComponentContext componentContext)
        {
            _componentContext = componentContext;
        }

        public TResult Create()
        {
            var factory = _componentContext.Resolve<Func<TResult>>();
            return factory.Invoke();
        }
    }
}
