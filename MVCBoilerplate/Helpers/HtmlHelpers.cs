using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace MVCBoilerplate.Helpers
{
    public static class HtmlHelpers
    {
        public static IHtmlString MenuListItem(this HtmlHelper helper, string linkText, string actionName, string controllerName)
        {
            var Url = new UrlHelper(helper.ViewContext.RequestContext);
            var li = new TagBuilder("li");
            
            string currentPath = HttpContext.Current.Request.Url.AbsolutePath;
            string linkPath = Url.Action(actionName, controllerName);
            if (currentPath.Equals(linkPath, StringComparison.OrdinalIgnoreCase))
                li.AddCssClass("active");

            li.InnerHtml = helper.ActionLink(linkText, actionName, controllerName).ToHtmlString();

            return MvcHtmlString.Create(li.ToString());
        }
    }
}