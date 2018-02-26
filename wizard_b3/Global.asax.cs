using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using InsWebApp.FormsModel;
using Newtonsoft.Json.Serialization;
using wizard_b3.App_Start;
using wizard_b3.Models.FormSetModel;

namespace wizard_b3
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            HttpConfiguration config = GlobalConfiguration.Configuration;
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            config.Formatters.JsonFormatter.UseDataContractJsonSerializer = false;

            InitAutoMapper();
        }

#warning ask questions for Ivan
        private void InitAutoMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<FormControl, FormControlItem>().ForMember(dest => dest.SelectableSection, opts => opts.MapFrom(src => FirstCharToLower(src.SelectableSection.Name)));
            }); 
        }

#warning check this govnocode, may be possible do json aat for it
        public static string FirstCharToLower(string input)
        {
            if (String.IsNullOrEmpty(input))
                return String.Empty;
            return input.First().ToString().ToLower() + input.Substring(1);
        }
    }
}
