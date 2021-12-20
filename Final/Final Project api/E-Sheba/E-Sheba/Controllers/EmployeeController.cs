using BEL.DTO;
using BLL;
using E_Sheba.Auth;
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
    [CustomAuth]
    public class EmployeeController : ApiController
    {

        [Route("api/employee/all")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            return Request.CreateResponse(HttpStatusCode.OK, EmployeeService.Get());
        }

        [Route("api/employee/count")]
        [HttpGet]
        public HttpResponseMessage GetCount()
        {
            return Request.CreateResponse(HttpStatusCode.OK, EmployeeService.EmployeeCount());
        }

    }
}
