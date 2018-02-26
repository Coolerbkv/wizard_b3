using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsWebApp.FormsModel
{
    [Flags]
    public enum FormControlSelectableType
    {
        Unknown = 0,

        Radio = 1,
        DropDown = 2,
        Boolean = 4,
        CheckBoxList = 8
    }
}
