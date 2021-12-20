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
    public class CustomerService
    {
        public static List<CustomerDto> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Customer, CustomerDto>();
                c.CreateMap<Order, OrderDto>();
                
                c.CreateMap<Order_Details, OrderDetailDto>();
                c.CreateMap<Service, ServiceDto>();
                c.CreateMap<User, UserDto>();
                c.CreateMap<Employee, EmployeeDto>();
                //c.CreateMap<Department, DepartmentModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.CustomerDataAcees();
            var data = mapper.Map<List<CustomerDto>>(da.Get());
            return data;
        }

        public static int CustomerCount()
        {
            return Get().Count();
        }
    }
}
