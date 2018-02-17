using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsWebApp.FormsModel
{
    public sealed class Form
    {
        public readonly string Id;
        public readonly string Name;
        public readonly string Step;

        private Dictionary<string, FormControl> _controls = new Dictionary<string, FormControl>();

        public Dictionary<string, FormControl> Controls
        {
            get { return _controls; }
        }

        public Form(string id, string name) : this(id, name, string.Empty)
        {
        }

        public Form(string id, string name, string step)
        {
            Id = id;
            Name = name;
            Step = step;
        }

        public void AddControl(FormControlType type, string id, string q = "", bool req = false)
        {
            _controls.Add(id, new FormControl(type, id, q, req));
        }
    }
}
