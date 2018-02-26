using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsWebApp.FormsModel
{
    [Flags]
    public enum FormControlType
    {
        Unknown = 0,
       
        String = 1,
        Checkbox = 2,
        Selectable = 4,
        Date = 8,
        Time = 16,

        SpaceLine = 32,
        BrLine = 64,
        Subtitle = 128 
    }
}
