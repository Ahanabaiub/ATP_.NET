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
    public class CategoryController : ApiController
    {
        [Route("api/Category/All")]
        [HttpGet]
        public List<CategoryModel> GetAll()
        {
            return CategoryService.Get();
        }
    }
}
