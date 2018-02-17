using System;
using System.Collections.Generic;
using InsWebApp.FormsModel;

namespace InsWebApp.ProductFormsModel
{
    public abstract class ProductFormsBase
    {
        private Dictionary<string, FormSet> _formSets = new Dictionary<string, FormSet>();

        protected ProductFormsBase()
        {
            
        }

        protected abstract void InitForms();

        internal FormSet GetFormSet(string state)
        {
            InitForms();

            return _formSets[state];
        }

        protected void AddFormSet(FormSet formsSet)
        {
            _formSets.Add(formsSet.State, formsSet);
        }
    }
}
