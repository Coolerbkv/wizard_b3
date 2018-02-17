using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsWebApp.ProductFormsModel;

namespace Nationwide_Base
{
    public class ProductFormsGetterNationwide : ProductFormsGetter
    {
        public override ProductFormsBase GetAllForms(string productId)
        {
            return new PartBForms();
        }
    }
}
