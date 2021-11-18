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
    public class NewsService
    {
        public static List<NewsModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<News, NewsModel>();
                c.CreateMap<CategoryModel, Category>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.NewsDataAccess();
            var data = mapper.Map<List<NewsModel>>(da.Get());
            return data;
        }

        public static NewsModel Get(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<News, NewsModel>();
                c.CreateMap<CategoryModel, Category>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.NewsDataAccess();
            var data = mapper.Map<NewsModel>(da.Get(id));
            return data;
        }

        public static void Add(NewsModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<NewsModel, News>();
       
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<News>(s);
            DataAccessFactory.NewsDataAccess().Add(data);
        }
    }
}
