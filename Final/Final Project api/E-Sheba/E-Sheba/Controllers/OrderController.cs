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

        [Route("api/orders/order-service-data")]
        [HttpGet]
        public HttpResponseMessage GetOrderServiceData()
        {
            return Request.CreateResponse(HttpStatusCode.OK, OrderService.OrderCount());
        }

        [Route("api/orders/order-detail/{id}")]
        [HttpGet]
        public HttpResponseMessage GetOrderServiceData(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, 
                OrderDetailsService.GetOrderDetailsByOrderId(id));
        }


        [Route("api/order-cancell/{id}")]
        [HttpGet]
        public HttpResponseMessage OrderCancel(int id)
        {
            OrderDetailsService.CancelOrder(id);
            return Request.CreateResponse(HttpStatusCode.OK,"");
        }


        [Route("api/order/search/{q}")]
        [HttpGet]
        public HttpResponseMessage OrderCancel(string q)
        {
           
            return Request.CreateResponse(HttpStatusCode.OK, OrderService.Search(q));
        }

        [Route("api/order/monthly/{year}")]
        [HttpGet]
        public HttpResponseMessage MnReport(string year)
        {

            return Request.CreateResponse(HttpStatusCode.OK, 
                OrderService.monthlyReport(year));
        }


    }
}
