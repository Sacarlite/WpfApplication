﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Bootstrapper.Logging
{
    public interface IUnhendledExeptionHandler
    {
        void Handel(DispatcherUnhandledExceptionEventArgs e);
    }
}
