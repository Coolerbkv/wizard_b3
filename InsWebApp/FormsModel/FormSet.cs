using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsWebApp.FormsModel
{
    public sealed class FormSet : FormSetTemplate
    {
        public readonly string State;
        internal readonly FormSetTemplate Template;

        public FormSet(string state, FormSetTemplate template)
        {
            State = state;
            Template = template;
        }

        internal FormSet(string state)
        {
            State = state;
        }
    }
}
