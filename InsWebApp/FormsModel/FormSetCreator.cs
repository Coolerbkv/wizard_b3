using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStar.Support;

namespace InsWebApp.FormsModel
{
    internal class FormSetCreator
    {
        public static FormSetCreator Instance
        {
            get
            {
                return Singleton<FormSetCreator>.Instance;
            }
        }

        public FormSet CreateFormSet(string activeProductClass, string productId, string state)
        {
            var fs = new FormSet();
            var insForm = new Form();
            //insForm.AddControl(new Form(), );
            fs.AddForm("insured", new Form());
            fs.AddForm("health_history_part1", new Form());
            return fs;
        }
    }
}
