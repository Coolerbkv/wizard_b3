using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.Cors;
using AutoMapper;
using InsWebApp.FormsModel;
using wizard_b3.Models;
using wizard_b3.Models.FormSetModel;
using XStar.Support;

namespace wizard_b3.API.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class WizardController : ApiController
    {
        [Route("~/api/wizard/getAllForms")]
        public FormSetModel GetAllForms()
        {
            var formSet = FormStorage.Instance.GetFormSet("", "AK");

            var model = new FormSetModel
            {
                Forms = formSet.Forms.Values.Select(form => new FormItem()
                {
                    Id = form.Id,
                    Name = form.Name,
                    Controls =
                        Mapper.Map<List<FormControl>, List<FormControlItem>>(form.Controls.Select(c => c.Value).ToList())
                }).ToList()
            };

            model.Sections =
                GetSections(
                    formSet.Forms.Values.SelectMany(form => form.Controls.Values.Select(ctrt => ctrt.SelectableSection)));

            return model;
        }

        private Dictionary<string, List<SectionItem>> GetSections(IEnumerable<Type> sectionsTypes)
        {
            var result = new Dictionary<string, List<SectionItem>>();

            foreach (var sectionType in sectionsTypes.Distinct())
            {
                if (sectionType == null)
                    continue;

                var tmp = new List<SectionItem>();
                foreach (var item in Enum.GetValues(sectionType))
                {
                    tmp.Add(new SectionItem()
                    {
                        Id = (int) item,
                        Name = item.GetDescription(sectionType)
                    });
                }

                result.Add(sectionType.Name, tmp);
            }

            return result;
        }


    }
    public static class EnumHelper
    {
        public static string ArgumentExceptionTEnumText = "TEnum must be an enumerated type";
        
        public static string GetDescription<TEnum>(this TEnum value, Type type)
        {
            if (type == null || !type.IsEnum) throw new ArgumentException(ArgumentExceptionTEnumText);

            if (value == null)
                return String.Empty;

            FieldInfo field = type.GetField(value.ToString());

            DescriptionAttribute attribute =
                Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;

            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}