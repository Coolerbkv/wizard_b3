using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using InsWebApp.FormsModel;

namespace wizard_b3.API.Controllers
{
    public class WizardController : ApiController
    {
        [HttpGet]
        [Route("~/api/wizard/getAllForms")]
        public object GetAllForms()
        {
            return FormStorage.Instance.GetFormSet("", "AK");
        }
    }
}