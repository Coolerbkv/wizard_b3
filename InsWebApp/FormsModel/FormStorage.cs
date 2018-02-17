using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStar.Support;

namespace InsWebApp.FormsModel
{
    public sealed class FormStorage
    {
        private static object _bundles_lock_sync = new object();
        public static FormStorage Instance
        {
            get
            {
                return Singleton<FormStorage>.Instance;
            }
        }

        private CacheCollection _formSets;

        private CacheCollection FormSets
        {
            get
            {
                if (_formSets == null)
                {
                    int count;
                    //if (!int.TryParse(ProjectSettings.GetSettingValue("StatesCached"), out count))
                    count = 150;

                    _formSets = new CacheCollection(count);
                }

                return _formSets;
            }
        }

        public FormSet GetFormSet(string productId, string state)
        {
            FormSet formSet;
            lock (_bundles_lock_sync)
            {
                string fullFormSetId = (productId + "-" + state);
                formSet = (FormSet)FormSets[fullFormSetId];
                if (formSet == null)
                {
                    // try to load
                    formSet = CreateFormSet(productId, state);
                    FormSets.Add(fullFormSetId, formSet);
                }
            }
            return formSet;
        }


        private FormSet CreateFormSet(string productId, string state)
        {
            return FormSetCreator.Instance.CreateFormSet(productId, state);
        }
    }
}
