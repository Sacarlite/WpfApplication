using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Domain.Settings;
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
        public MainVievModel(IMainWindowMementoWrapper mainWindowMementoWrapper)
             : base(mainWindowMementoWrapper)
        {
           
            _windowMementoWrapper = mainWindowMementoWrapper;
        }

        public string Title => "OptKurs";

        public override void WindowClosing()
        {
        }

        public void Dispose()
        {
        }
    }
}
