using Infrastructure.Settings.DefaultMementas;
using Domain.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Common;

namespace Infrastructure.Settings.WindowWrappers
{
    internal class MainWindowMementoWrapper : WindowMementoWrapper<MainWindowMemento>, IMainWindowMementoWrapper
    {
        public MainWindowMementoWrapper(IPathService pathService) :
            base(pathService)
        {

        }
        protected override string MementoName => "MainWindowMemento";
    }
}
