using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsWebApp.FormsModel
{
    public class FormSetTemplate
    {
        private Dictionary<string, Form> _forms = new Dictionary<string, Form>();
        public Dictionary<string, Form> Forms
        {
            get { return _forms; }
        }

        public FormSetTemplate()
        {
        }

        public void AddForm(Form form)
        {
            _forms.Add(form.Id, form);
        }

        public void AddForms(Dictionary<string, Form> forms)
        {
            foreach (var form in forms)
            {
                _forms.Add(form.Key, form.Value);
            }
        }
    }
}
