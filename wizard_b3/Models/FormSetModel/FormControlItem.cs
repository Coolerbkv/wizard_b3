using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InsWebApp.FormsModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace wizard_b3.Models.FormSetModel
{
    public class FormControlItem
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public FormControlType Type;
        public string Id;
        public string Question;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Required;

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public FormControlSelectableType SelectableType;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string SelectableSection;
    }
}