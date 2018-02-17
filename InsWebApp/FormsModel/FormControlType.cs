using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsWebApp.FormsModel
{
    public enum FormControlType
    {
        Unknown = 0,
       
        String = 1,
        Checkbox = 2,
        Selectable = 3,
        Date = 4,
        Time = 5,

        SpaceLine = 6,
        BrLine = 7,
        Subtitle = 8 
    }
}
