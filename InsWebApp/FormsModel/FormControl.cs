using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsWebApp.FormsModel
{
    public sealed class FormControl
    {
        public FormControlType Type { get; private set; }
        public string Id { get; private set; }
        public string Question { get; private set; }
        public bool Required { get; private set; }

        public FormControlSelectableType SelectableType { get; private set; }

        public Type SelectableSection { get; private set; }

        internal FormControl(FormControlType type, string id, FormControlSelectableType selectableType,
            Type selectableSection, string q, bool req)
        {
            SelectableType = selectableType;
            SelectableSection = selectableSection;
            Type = type;
            Id = id;
            Question = q;
            Required = req;
        }
    }
}
