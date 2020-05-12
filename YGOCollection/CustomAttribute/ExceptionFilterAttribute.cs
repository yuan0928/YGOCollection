using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YGOCollection.library.Extension;

namespace YGOCollection.CustomAttribute
{
    public class ExceptionFilterAttribute : ActionFilterAttribute, IExceptionFilter
    {
        protected string ApiAddress => System.Configuration.ConfigurationManager.AppSettings["ApiAddress"];
        public void OnException(ExceptionContext filterContext)
        {
            WebRequestExtensions.HttpPost($"{ApiAddress}Api/Home/WebError", filterContext.Exception);
        }
    }
}