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

        [Route("api/Category/get/{id}")]
        [HttpGet]
        public CategoryModel Get(int id)
        {
            return CategoryService.Get(id);
        }

        [Route("api/Student/Create")]
        [HttpPost]
        public void Add(CategoryModel s)
        {
            CategoryService.Add(s);
        }
    }
}
