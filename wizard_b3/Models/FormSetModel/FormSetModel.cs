using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace wizard_b3.Models.FormSetModel
{
    public class FormSetModel
    {
        public List<FormItem> Forms { get; set; }

        public Dictionary<string, List<SectionItem>> Sections { get; set; }
    }
}