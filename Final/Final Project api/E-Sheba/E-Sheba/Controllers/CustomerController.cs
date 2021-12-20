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
    public class CustomerController : ApiController
    {
        [Route("api/customers")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, CustomerService.Get());
        }

        [Route("api/customers/count")]
        [HttpGet]
        public HttpResponseMessage GetCount()
        {
            return Request.CreateResponse(HttpStatusCode.OK,
                CustomerService.CustomerCount().ToString());
        }
    }
}
