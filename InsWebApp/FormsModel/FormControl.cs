using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsWebApp.FormsModel
{
    public sealed class FormControl
    {
        public FormControlType Type;
        public string Id;
        public string Question;
        public bool Required;


        internal FormControl(FormControlType type, string id, string q, bool req)
        {
            Type = type;
            Id = id;
            Question = q;
            Required = req;
        }
    }
}
