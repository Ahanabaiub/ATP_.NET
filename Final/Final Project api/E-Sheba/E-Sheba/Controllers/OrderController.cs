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
    public class OrderController : ApiController
    {
        [Route("api/orders/all")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            return Request.CreateResponse(HttpStatusCode.OK, OrderService.Get());
        }

        [Route("api/orders/count")]
        [HttpGet]
        public HttpResponseMessage GetCount()
        {
            return Request.CreateResponse(HttpStatusCode.OK, OrderService.OrderCount());
        }
    }
}
