using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Domain.Factories;
using Domain.Settings;
using Domain.Version;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using VievModel.Windows;

namespace VievModel.VievModels.MainVievModel
{
    public partial class MainVievModel : WindowVievModel<IMainWindowMementoWrapper>, IMainVievModel
    {

        private IMainWindowMementoWrapper _windowMementoWrapper;
        private IAplicationVersionProvider _aplicationVersionProvider;

        public MainVievModel(IMainWindowMementoWrapper mainWindowMementoWrapper,IAplicationVersionProvider aplicationVersionProvider)
             : base(mainWindowMementoWrapper)
        {
           
            _windowMementoWrapper = mainWindowMementoWrapper;
            _aplicationVersionProvider = aplicationVersionProvider;
        }
        public string Version => $"Version {_aplicationVersionProvider.Version.ToString(3)}";
        public string Title => "MainWindowTITLE";

        public override void WindowClosing()
        {
        }

        public void Dispose()
        {
        }
    }
}
