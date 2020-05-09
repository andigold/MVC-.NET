using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Data.SqlClient;
using UserRestaurnats3.Contacts;
using UserRestaurnats3.Database;
using UserRestaurnats3.Helpers;

namespace UserRestaurnats3.Controllers
{
    internal class AuthorizeUserAttribute : Attribute, IActionFilter
    {

        public AuthorizeUserAttribute() 
        {

        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {

            // TODO: Find a way to avoid using dynamic in the code below. It's an overhead for runtime. 
            // (Object is computed at runtime, by using insane reflections)
            // Source: https://stackoverflow.com/questions/13193799/performance-cost-of-using-dynamic-typing-in-net
            // Source 2 (VERY IMPORTANT, please read THIS one) : https://stackoverflow.com/questions/7478387/how-does-having-a-dynamic-variable-affect-performance
            dynamic controllerContext = filterContext.Controller;
            byte[] userIdentity = filterContext.HttpContext.Session.Get(ProgramParameters.Identity);
            controllerContext.Identified = controllerContext._repository.IsUserAuthenticated(userIdentity);
            //controllerContext.AuthenticateUser();

        }
    }
}