using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppValidation.Helpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement(Attributes ="asp-active-route")]
    public class ActiveRouteTagHelper : TagHelper
    {
        [HtmlAttributeNotBound]
       [ViewContext]
        public ViewContext viewcontext { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string controller = viewcontext.RouteData.Values["Controller"].ToString();
            string action = viewcontext.RouteData.Values["Action"].ToString();

            string tagcontroller = context.AllAttributes.FirstOrDefault(m => m.Name == "asp-controller").Value.ToString();
            string tagaction = context.AllAttributes.FirstOrDefault(m => m.Name == "asp-action").Value.ToString();
            if(controller == tagcontroller && action == tagaction)
            { 
            string activeclass = context.AllAttributes.FirstOrDefault(m => m.Name == "asp-active-route").Value.ToString();
            string cssclasses = context.AllAttributes.FirstOrDefault(m => m.Name == "class").Value.ToString();
                output.Attributes.SetAttribute("class", cssclasses + " " + activeclass);
            }
        }
    }
}
