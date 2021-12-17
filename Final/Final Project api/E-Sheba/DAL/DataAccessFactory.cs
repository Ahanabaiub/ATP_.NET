using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static Entities db;
        static DataAccessFactory()
        {
            db = new Entities();
        }

        public static ICustomer<Customer, int> CustomerDataAcees()
        {
            return new CustomerRepo(db);
        }

        public static IOrder<Order, int> OrderDataAcees()
        {
            return new OrderRepo(db);
        }

        public static IEmployee<Employee, int> EmployeeDataAcees()
        {
            return new EmployeeRepo(db);
        }

        public static IService<Service, int> ServiceDataAcees()
        {
            return new ServiceRepo(db);
        }
    }
}
