using AutoMapper;
using BEL.DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicesService
    {
        public static List<ServiceDto> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Service, ServiceDto>();
               
                //c.CreateMap<Department, DepartmentModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.ServiceDataAcees();
            var data = mapper.Map<List<ServiceDto>>(da.Get());
            return data;
        }

        public static int ServiceCount()
        {
            return Get().Count();
        }
    }
}
