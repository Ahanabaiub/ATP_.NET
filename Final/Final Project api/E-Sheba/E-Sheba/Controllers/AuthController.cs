using BEL.DTO;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace E_Sheba.Controllers
{
    [EnableCors("*", "*", "*")]
    public class AuthController : ApiController
    {
        [Route("api/login")]
        [HttpPost]
        public HttpResponseMessage Login(UserDto userdto)
        {
            var token = AuthService.Authenticate(userdto);

            if (token != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, token);
            }

            return Request.CreateResponse(HttpStatusCode.NotFound, "Invalid Email Or Password");
        }

        [Route("api/logout")]
        [HttpGet]
        public HttpResponseMessage Logout()
        {

             var token = Request.Headers.Authorization.ToString();

             AuthService.Logout(token);

           

            return Request.CreateResponse(HttpStatusCode.OK, "Logout Successfull.");
        }
    }
}
