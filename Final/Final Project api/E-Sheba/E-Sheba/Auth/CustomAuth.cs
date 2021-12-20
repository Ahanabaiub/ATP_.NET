using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace E_Sheba.Auth
{
    public class CustomAuth : AuthorizationFilterAttribute
    {

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var token = actionContext.Request.Headers.Authorization;

            if (token == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized,"Unauthorized User! Please login first.");

            }
            else
            {
                if (AuthService.IsAuthenticated(token.ToString())){

                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized, "Session Expired. Please login again.");

                }
            }

            base.OnAuthorization(actionContext);

        }
    }
}