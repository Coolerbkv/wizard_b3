using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using InsWebApp.FormsModel;
using wizard_b3.Models;

namespace wizard_b3.API.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class WizardController : ApiController
    {
        [Route("~/api/wizard/getAllForms")]
        public List<FormModel> GetAllForms()
        {
            var formSet = FormStorage.Instance.GetFormSet("", "AK");

            var formsModelList = formSet.Forms.Values.Select(form => new FormModel()
            {
                Id = form.Id,
                Name = form.Name,
                Controls = form.Controls.Select(c => c.Value).ToList()
            }).ToList();

            return formsModelList;
        }
    }
}