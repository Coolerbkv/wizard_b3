using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsWebApp.FormsModel
{
    public sealed class FormSet
    {
        private Dictionary<string, Form> _forms;
        public Dictionary<string, Form> Forms
        {
            get { return _forms ?? (_forms = new Dictionary<string, Form>()); }
        }

        internal FormSet()
        {
            
        }

        internal void AddForm(string formId, Form form)
        {
            _forms.Add(formId, form);
        }
    }
}
