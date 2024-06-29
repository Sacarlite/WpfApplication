using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Bootstrapper.Logging
{
    class UnhendledExeptionHandler : IUnhendledExeptionHandler
    {
        private static readonly NLog.ILogger Logger = LogManager.GetLogger(nameof(UnhendledExeptionHandler));
        public void Handel(DispatcherUnhandledExceptionEventArgs e)
        {
            e.Handled = true;
            Logger.Error(e.Exception);
        }
    }
}
