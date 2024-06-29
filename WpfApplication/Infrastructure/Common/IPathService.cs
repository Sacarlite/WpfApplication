using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Common
{
    public interface IPathService
    {
        string ApplicationFolder { get; }
    }
}
