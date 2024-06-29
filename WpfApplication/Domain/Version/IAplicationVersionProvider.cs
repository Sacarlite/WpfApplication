using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Version
{
    public interface IAplicationVersionProvider
    {
        System.Version Version { get; }
    }
}
