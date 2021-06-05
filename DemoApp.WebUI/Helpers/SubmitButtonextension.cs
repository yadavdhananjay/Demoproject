using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppValidation.Helpers
{
    public static class SubmitButtonextension
    {
        public static IHtmlContent SubmitButton(this IHtmlHelper htmlHelper, string name, string value)

        {
            string button=$"<input type='submit' value='{value}' name='{name}'>";
            return new HtmlString(button);
        }
    }
}
