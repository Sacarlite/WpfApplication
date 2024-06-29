using Domain.Version;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class AplicationVersionProvider : IAplicationVersionProvider
    {
        public Version Version { get; } = new Version(1, 0, 1);
    }
}
