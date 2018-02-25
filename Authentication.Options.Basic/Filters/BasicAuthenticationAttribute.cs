using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Web;

namespace Authentication.Options.Basic.Filters
{
    public class BasicAuthenticationAttribute : System.Web.Http.Filters.ActionFilterAttribute
    {
        public override void OnActionExecuting(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
            }
            else
            {
                //string authToken = actionContext.Request.Headers.Authorization.Parameter;
                //string decodedToken = Encoding.UTF8.GetString(Convert.FromBase64String(authToken));
                //string username = decodedToken.Substring(0, decodedToken.IndexOf(":"));
                //string password = decodedToken.Substring(decodedToken.IndexOf(":") + 1);
                //IPasswordTransform transform = DependencyResolver.Current.GetService<IPasswordTransform>();
                //IRepository<User> userRepository = DependencyResolver.Current.GetService<IRepository<User>>();
                //User user = userRepository.All(u => u.Username == username && u.PasswordHash == transform.Transform(password)).SingleOrDefault();

                //if (user != null)
                //{
                //    HttpContext.Current.User = new GenericPrincipal(new ApiIdentity(user), new string[] { });
                //    base.OnActionExecuting(actionContext);
                //}
            }
        }
    }
}