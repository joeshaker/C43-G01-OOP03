using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3OOP.Enums
{
    [Flags]
    internal enum SecurityPrivileges
    {
        Guest=1,
        Developer=2,
        Secretary=4,
        DBA=8,
        SecurityOffice=15,
    }
}
