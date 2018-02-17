using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsWebApp.FormsModel
{
    public sealed class Form
    {
        private Dictionary<string, FormControl> _controls;
        public Dictionary<string, FormControl> Controls
        {
            get { return _controls ?? (_controls = new Dictionary<string, FormControl>()); }
        }

        internal Form()
        {
            
        }

        internal void AddControl(string formId, FormControl ctrl)
        {
            _controls.Add(formId, ctrl);
        }
    }
}
