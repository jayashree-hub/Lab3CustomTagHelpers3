using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Lab3CustomTagHelpers3.TagHelper
{
    [HtmlTargetElement(Attributes = "asp-active-route")]
    public class ActiveRouteTagHelper : TagHelper
    {
        [HtmlAttributeName("asp-controller")]
        public string Controller { get; set; }

        [HtmlAttributeName("asp-action")]
        public string Action { get; set; }

        [HtmlAttributeName("asp-hide-if-active")]
        public bool HideIfActive { get; set; }


    }
   
   
    
}