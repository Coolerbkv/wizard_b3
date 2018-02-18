using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InsWebApp.FormsModel;

namespace wizard_b3.Models
{
    public class FormModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<FormControl> Controls = new List<FormControl>(); 
    }
}