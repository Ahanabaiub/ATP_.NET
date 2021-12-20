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
    public class ServiceController : ApiController
    {

        [Route("api/service/all")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, ServicesService.Get());
        }

        [Route("api/service/count")]
        [HttpGet]
        public HttpResponseMessage GetCount()
        {
            return Request.CreateResponse(HttpStatusCode.OK,
                ServicesService.ServiceCount().ToString());
        }

        [Route("api/service/service-order-data")]
        [HttpGet]
        public HttpResponseMessage GetOrderServiceData()
        {
            return Request.CreateResponse(HttpStatusCode.OK, ServicesService.ServiceWiseOrder());
        }

        [Route("api/service/service-employee-data")]
        [HttpGet]
        public HttpResponseMessage GetEmployeeServiceData()
        {
            return Request.CreateResponse(HttpStatusCode.OK, ServicesService.ServiceWiseWorker());
        }


        [Route("api/service/service-expence-data")]
        [HttpGet]
        public HttpResponseMessage GetServiceExpenceData()
        {
            return Request.CreateResponse(HttpStatusCode.OK, ServicesService.GetServiceExpence());
        }
    }
}
