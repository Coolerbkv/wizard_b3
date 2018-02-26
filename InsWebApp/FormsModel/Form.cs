using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsWebApp.FormsModel.Sections;

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

        public FormControl AddStringControl(string id, string q = "", bool req = false)
        {
            return AddControlInternal(FormControlType.String, id, q, req);
        }

        public FormControl AddBooleanControl(string id, string q = "", bool req = false)
        {
            return AddSelectableControl(id, FormControlSelectableType.Boolean, typeof(BooleanSelectableType), q, req);
        }

        public FormControl AddSelectableControl(string id, FormControlSelectableType selectableType, Type enumType, string q = "", bool req = false)
        {
            return AddControlInternal(FormControlType.Selectable, id, q, req, selectableType, enumType);
        }

        public FormControl AddCheckboxControl(string id, string q = "", bool req = false)
        {
            return AddControlInternal(FormControlType.Checkbox, id, q, req);
        }

        private FormControl AddControlInternal(FormControlType type, string id, string q = "", bool req = false, FormControlSelectableType selectableType = FormControlSelectableType.Unknown, Type selectableSection = null)
        {
            var fc = new FormControl(type, id, selectableType, selectableSection, q, req);
            _controls.Add(id, fc);
            return fc;
        }
    }
}
