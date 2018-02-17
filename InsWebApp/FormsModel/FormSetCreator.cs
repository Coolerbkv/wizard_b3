using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsWebApp.ProductFormsModel;
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

        public FormSet CreateFormSet(string productId, string state)
        {
            var productModel = ProductFormsGetter.Image.GetAllForms(productId);
            var formSet = productModel.GetFormSet(state);
            var fs = new FormSet(state);
            fs.AddForms(formSet.Template.Forms);
            return fs;
        }
    }
}
