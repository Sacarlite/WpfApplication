using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VievModel.Windows
{
    public interface IWindow
    {
        void Show();
        void Close();
        bool Activate();

        event CancelEventHandler Closing;
        event EventHandler Closed;
    }
}
