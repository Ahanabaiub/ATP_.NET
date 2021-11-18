using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace News_Portal_Project.Controllers
{
    public class NewsController : ApiController
    {
        [Route("api/News/All")]
        [HttpGet]
        public List<NewsModel> GetAll()
        {
            return NewsService.Get();
        }

        [Route("api/News/get/{id}")]
        [HttpGet]
        public NewsModel Get(int id)
        {
            return NewsService.Get(id);
        }

        [Route("api/News/Create")]
        [HttpPost]
        public void Add(NewsModel s)
        {
            NewsService.Add(s);
        }
    }
}
