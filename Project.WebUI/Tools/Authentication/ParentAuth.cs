using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.WebUI.Tools.Authentication
{
    public class ParentAuth: AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Session["parent"] != null)
            {
                return true;
            }
            return false;
        }
    }
}