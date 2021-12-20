using BEL.DTO;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace E_Sheba.Controllers
{
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
    }
}
