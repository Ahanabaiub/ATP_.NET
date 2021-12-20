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
                c.CreateMap<Customer, CustomerDto>();
                c.CreateMap<Order, OrderDto>();

                c.CreateMap<Order_Details, OrderDetailDto>();
               
                c.CreateMap<User, UserDto>();
                c.CreateMap<Employee, EmployeeDto>();

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


        public static IDictionary<String, int> ServiceWiseOrder()
        {
            var orders = DataAccessFactory.OrderDetailsDataAcees().Get();

            IDictionary<String, int> dict = new Dictionary<String,int>();
            
            foreach(var o in orders)
            {
                if (dict.ContainsKey(o.Service.name.Trim()))
                {
                    dict[o.Service.name.Trim()] += o.quantity;
                }
                else
                {
                    dict[o.Service.name.Trim()] = o.quantity;
                }
            }

            return dict;

        }

        public static IDictionary<String, int> ServiceWiseWorker()
        {
            var employees = DataAccessFactory.EmployeeDataAcees().Get();

            IDictionary<String, int> dict = new Dictionary<String, int>();

            foreach (var e in employees)
            {
                if (dict.ContainsKey(e.Service.name.Trim())){
                    dict[e.Service.name.Trim()] += 1;
                }
                else
                {
                    dict[e.Service.name.Trim()] = 1;
                }
            }

            return dict;
        }

        public static List<ServiceExpenceDto> GetServiceExpence()
        {
            var services = Get();
            List<ServiceExpenceDto> res = new List<ServiceExpenceDto>();
            foreach (ServiceDto s in services)
            {

                var ods = OrderDetailsService.GetOrderDetailsServiceId(s.id);

                double totalEarning = 0;
                foreach (OrderDetailDto order_Details in ods)
                {
                    totalEarning += order_Details.unit_price * order_Details.quantity;
                }

                var empoyees = EmployeeService.GetByServiceId(s.id);

                double totalExpence = 0;

                foreach (EmployeeDto employee in empoyees)
                {
                    totalExpence += employee.salary;
                }

                ServiceExpenceDto se = new ServiceExpenceDto()
                {
                    name = s.name,
                    earning = totalEarning,
                    expence = totalExpence
                };

                res.Add(se);


            }
            return res;
        }
    }
}
