using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsWebApp.FormsModel;
using InsWebApp.ProductFormsModel;

namespace Nationwide_Base
{
    public class PartBForms : ProductFormsBase
    {
        private FormSetTemplate BaseFormSetTemplate()
        {
            var baseTemplate = new FormSetTemplate();

            var form = new Form("insured", "Personal Information");
            form.AddControl(FormControlType.String, "insured_first_name", q: "First Name");
            form.AddControl(FormControlType.String, "sign_city", q: "City");
            form.AddControl(FormControlType.Checkbox, "seizures_symptoms_loss", q: "Loss of consciousness or blackouts");

            baseTemplate.AddForm(form);

            var examinersReport = new Form("examiner", "Examiner");
            examinersReport.AddControl(FormControlType.String, "examiner_first_name", q: "First Name");
            examinersReport.AddControl(FormControlType.String, "examiner_street", q: "Street");
            examinersReport.AddControl(FormControlType.Checkbox, "authorized_laboratory_hiv_consent", q: "HIV Consent");

            baseTemplate.AddForm(examinersReport);

            return baseTemplate;
        }

        protected override void InitForms()
        {
            AddFormSet(new FormSet("AK", BaseFormSetTemplate()));
        }
    }
}
