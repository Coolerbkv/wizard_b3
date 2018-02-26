using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nationwide_Base.Sections
{
    public enum AviationType
    {
        Unknown = 0,
        Private = 1,
        Commercial = 2,
        Military = 3,
        [Description("Any type of aviation")]
        AnyType = 100,
        Other = 2147483647
    }
}
