﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TransitLine.Api.Authorization
{
    public class AuthenticationApi:AuthorizeAttribute,IActionFilter,IResultFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            throw new NotImplementedException();
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            throw new NotImplementedException();
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            throw new NotImplementedException();
        }
    }
}