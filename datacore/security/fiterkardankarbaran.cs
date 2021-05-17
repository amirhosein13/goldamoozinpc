using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace datacore
{
   public class fiterkardankarbaran : AuthorizeAttribute, IAuthorizationFilter
    {
        Iuser iuser;
        string a;
        int b;
        public fiterkardankarbaran(int idrole)
        {
            b = idrole;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            iuser=(Iuser)context.HttpContext.RequestServices.GetService(typeof(Iuser));
            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                a = context.HttpContext.User.Identity.Name;
                var aa = iuser.getroleiduser(a);
                if (aa!=null)
                {
                    if (aa < b)
                    {
                        context.Result = new RedirectResult("/login");
                    }
                }
                else
                {
                     context.Result = new RedirectResult("/login");
                }
            }
            else
            {
                context.Result = new RedirectResult("/login");
            }
        }
    }
}
