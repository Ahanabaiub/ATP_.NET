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
    public class OrderDetailsService
    {

        public static List<OrderDetailDto> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Order_Details, OrderDetailDto>();
                c.CreateMap<Service, ServiceDto>();
                c.CreateMap<Employee, EmployeeDto>();
                c.CreateMap<User, UserDto>();


            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.OrderDetailsDataAcees();
            var data = mapper.Map<List<OrderDetailDto>>(da.Get());
            return data;
        }

        public static List<OrderDetailDto> GetOrderDetailsByOrderId(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Order_Details, OrderDetailDto>();
                c.CreateMap<Service, ServiceDto>();
                c.CreateMap<Employee, EmployeeDto>();
                c.CreateMap<User, UserDto>();


            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.OrderDetailsDataAcees();
            var data = mapper.Map<List<OrderDetailDto>>(da.OrderDetailsByOrderId(id));
            return data;
        }

        public static List<OrderDetailDto> GetOrderDetailsServiceId(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Order_Details, OrderDetailDto>();
                c.CreateMap<Service, ServiceDto>();
                c.CreateMap<Employee, EmployeeDto>();
                c.CreateMap<User, UserDto>();


            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.OrderDetailsDataAcees();
            var data = mapper.Map<List<OrderDetailDto>>(da.OrderDetailsByServiceId(id));
            return data;
        }

        public static void CancelOrder(int id)
        {
            DataAccessFactory.OrderDataAcees().Cancel(id);
        }
    }
}
