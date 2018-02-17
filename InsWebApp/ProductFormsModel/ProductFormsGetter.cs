using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsWebApp.FormsModel;

namespace InsWebApp.ProductFormsModel
{
    public class ProductFormsGetter
    {
        public static ProductFormsGetter Image
        {
            //[DebuggerStepThrough]
            get
            {
                string sett = "Nationwide_Base.ProductFormsGetterNationwide, Nationwide_Base";
                if (String.IsNullOrEmpty(sett))
                    throw new ArgumentException("Can't get Active.ProductClass from settings");
                Type t = Type.GetType(sett);
                if (null != t)
                    return Activator.CreateInstance(t) as ProductFormsGetter;

                throw new ArgumentException();
            }
        }

        public virtual ProductFormsBase GetAllForms(string productId)
        {
            throw new NotImplementedException();
        }
    }
}
