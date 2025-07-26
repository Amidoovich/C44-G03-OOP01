using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1
{
    [Flags]
    internal enum Permissions : byte
    {
        Delete = 1,
        Excute = 2,
        Read = 4,
        write = 8
    }

}
