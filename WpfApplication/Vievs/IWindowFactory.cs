using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VievModel.Windows;

namespace Vievs
{
    public interface IWindowFactory
    {
        IWindow Create<TWindowViewModel>(TWindowViewModel viewModel)
            where TWindowViewModel : IWindowViewModel;
    }
}
