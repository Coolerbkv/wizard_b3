using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsWebApp.FormsModel
{
    public sealed class FormControl
    {
        public readonly FormControlTypes Type;

        internal FormControl(FormControlTypes type)
        {
            Type = type;
        }
    }
}
