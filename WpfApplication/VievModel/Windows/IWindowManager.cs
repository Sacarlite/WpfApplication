using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VievModel.Windows
{
    public interface IWindowManager
    {
        IWindow Show<TWindowVievModel>(TWindowVievModel windowVievModel)
            where TWindowVievModel : IWindowViewModel;
        void Close<TWindowVievModel>(TWindowVievModel windowVievModel)
            where TWindowVievModel : IWindowViewModel;
    }
}
