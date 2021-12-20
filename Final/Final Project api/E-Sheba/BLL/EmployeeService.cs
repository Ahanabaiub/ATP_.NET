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
    public class EmployeeService
    {
        public static List<EmployeeDto> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Employee, EmployeeDto>();
                c.CreateMap<User,UserDto>();
                //c.CreateMap<Department, DepartmentModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.EmployeeDataAcees();
            var data = mapper.Map<List<EmployeeDto>>(da.Get());
            return data;
        }

        public static List<EmployeeDto> GetByServiceId(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Employee, EmployeeDto>();
                c.CreateMap<User, UserDto>();
                //c.CreateMap<Department, DepartmentModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.EmployeeDataAcees();
            var data = mapper.Map<List<EmployeeDto>>(da.GetByServiceId(id));
            return data;
        }

        public static int EmployeeCount()
        {
            return Get().Count();
        }
    }
}
