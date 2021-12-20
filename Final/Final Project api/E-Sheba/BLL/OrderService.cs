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
    public class OrderService
    {
        public static List<OrderDto> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderDto>();
                c.CreateMap<Customer, CustomerDto>();
                c.CreateMap<Order_Details, OrderDetailDto>();
                c.CreateMap<Service, ServiceDto>();
                c.CreateMap<User, UserDto>();
                c.CreateMap<Employee, EmployeeDto>();
                //c.CreateMap<Department, DepartmentModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.OrderDataAcees();
            var data = mapper.Map<List<OrderDto>>(da.Get());
            return data;
        }

        public static int OrderCount()
        {
            return Get().Count();
        }

        public static List<OrderDto> Search(string str)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderDto>();
                c.CreateMap<Customer, CustomerDto>();
                c.CreateMap<Order_Details, OrderDetailDto>();
                c.CreateMap<Service, ServiceDto>();
                c.CreateMap<User, UserDto>();
                c.CreateMap<Employee, EmployeeDto>();
                //c.CreateMap<Department, DepartmentModel>();
            });

            var mapper = new Mapper(config);
            var da = DataAccessFactory.OrderDataAcees();
            var data = mapper.Map<List<OrderDto>>(da.Search(str));
            return data;

        }

        public static Dictionary<string, int> monthlyReport(string year)
        {
            var da = DataAccessFactory.OrderDataAcees();

            return da.monthlyReport(year);
        }
    }
}
