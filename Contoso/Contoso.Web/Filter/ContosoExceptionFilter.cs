using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLog;

namespace Contoso.Web.Filter
{
    public class ContosoExceptionFilter:HandleErrorAttribute
    {
        private static Logger logger;
        public ContosoExceptionFilter()
        {
            logger = LogManager.GetCurrentClassLogger();
        }

        public override void OnException(ExceptionContext filterContext)
        {
            var controllername = (string)filterContext.RouteData.Values["Controller"];
            var Actionname = (string)filterContext.RouteData.Values["Action"];
            var model = new HandleErrorInfo(filterContext.Exception, controllername, Actionname);
            //can be passed to view to let user see some info.
            filterContext.Result = new ViewResult {
                ViewName = View,
                MasterName = Master,
                ViewData = new ViewDataDictionary<HandleErrorInfo>(model),
                TempData = filterContext.Controller.TempData
            };
            string exceptionPath = filterContext.HttpContext.Request.Path
                + filterContext.HttpContext.Request.QueryString;

            //log exception info like 
            //1.Exception ->filterContext.Exception
            //2.Inner Message
            //3.Datetime - > Datetime.now
            //4.ActionMethod Name and Controller Name
            //5.whole stack trace -> filter.exception
            //6.Exception path(URL) ->string exceptionPath
            //log above details using NLog to text files

            //NLog and Log4Net will help us to create the log
            logger.Log(LogLevel.Info, filterContext.Exception);
            logger.Log(LogLevel.Info, filterContext.Exception.InnerException);
            logger.Log(LogLevel.Info, filterContext.Exception.StackTrace);
            logger.Log(LogLevel.Info, DateTime.Now);
            logger.Log(LogLevel.Info, controllername);
            logger.Log(LogLevel.Info, Actionname);
            logger.Log(LogLevel.Info, exceptionPath);

            filterContext.ExceptionHandled = true;
            filterContext.HttpContext.Response.Clear();
            filterContext.HttpContext.Response.StatusCode = 500;


            base.OnException(filterContext);
        }
    }
}