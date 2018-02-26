using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wizard_b3.Models.FormSetModel
{
    public class FormItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<FormControlItem> Controls { get; set; }
    }
}