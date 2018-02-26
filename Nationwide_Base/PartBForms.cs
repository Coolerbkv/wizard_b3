using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsWebApp.FormsModel;
using InsWebApp.ProductFormsModel;
using Nationwide_Base.Sections;

namespace Nationwide_Base
{
    public class PartBForms : ProductFormsBase
    {
        private FormSetTemplate BaseFormSetTemplate()
        {
            var baseTemplate = new FormSetTemplate();

            var form = new Form("insured", "Personal Information");
            form.AddStringControl("insured_first_name", q: "First Name", req:true);
            form.AddStringControl("sign_city", q: "City", req:true);
            form.AddCheckboxControl("seizures_symptoms_loss", q: "Loss of consciousness or blackouts");

            baseTemplate.AddForm(form);

            var examinersReport = new Form("examiner", "Examiner");
            examinersReport.AddStringControl("examiner_first_name", q: "First Name", req: true);
            examinersReport.AddStringControl("examiner_street", q: "Street", req: true);
            examinersReport.AddCheckboxControl("authorized_laboratory_hiv_consent", q: "HIV Consent");

            baseTemplate.AddForm(examinersReport);

            var lifeStyleActivity = new Form("lifestyle", "General Risk and Lifestyle Questions");
            lifeStyleActivity.AddBooleanControl("lifestyle_avocation", q: "b) Have you engaged in any form of organized motor vehicle or power boat racing, sky diving/parachuting, skin or scuba diving, hang-gliding or mountain climbing in the last 2 years?", req: true);
            lifeStyleActivity.AddBooleanControl("lifestyle_driving_intoxicated", q: "Within the last 5 years, have you been convicted of driving while intoxicated or while under the influence of a controlled substance?", req: true);

            lifeStyleActivity.AddBooleanControl("insured_tobacco_used", q: "24. Have you ever used tobacco or nicotine products in any form (including cigarettes, cigars, cigarillos, a pipe, chewing tobacco, nicotine patches or gum)?", req: true);
            lifeStyleActivity.AddSelectableControl("insured_tobacco_type", FormControlSelectableType.DropDown, typeof(TobaccoType), q: "Tobacco Type", req: true);

            lifeStyleActivity.AddSelectableControl("insured_avia_type", FormControlSelectableType.Radio, typeof(AviationType), q: "Aviation Type", req: true);

            baseTemplate.AddForm(lifeStyleActivity);

            return baseTemplate;
        }

        protected override void InitForms()
        {
            AddFormSet(new FormSet("AK", BaseFormSetTemplate()));
        }
    }
}
