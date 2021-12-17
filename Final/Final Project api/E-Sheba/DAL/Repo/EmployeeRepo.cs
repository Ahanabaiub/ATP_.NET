using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class EmployeeRepo : IEmployee<Employee, int>
    {

        Entities db;
        public EmployeeRepo(Entities db)
        {
            this.db = db;
        }

        public void Add(Employee e)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Employee e)
        {
            throw new NotImplementedException();
        }

        public List<Employee> Get()
        {
            return db.Employees.ToList();
        }

        public Employee Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
