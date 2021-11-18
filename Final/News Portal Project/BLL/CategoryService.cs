using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoryService
    {
        public static List<CategoryModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Category, CategoryModel>();
               
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.CategoryDataAcees();
            var data = mapper.Map<List<CategoryModel>>(da.Get());
            return data;
        }

        public static CategoryModel Get(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Category, CategoryModel>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.CategoryDataAcees();
            var data = mapper.Map<CategoryModel>(da.Get(id));
            return data;
        }

        public static void Add(CategoryModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<CategoryModel,  Category> ();


            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Category>(s);
            DataAccessFactory.CategoryDataAcees().Add(data);
        }


    }
}
