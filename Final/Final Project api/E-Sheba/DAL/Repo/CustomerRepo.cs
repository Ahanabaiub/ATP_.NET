using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class CustomerRepo : ICustomer<Customer, int>
    {

        Entities db;
        public CustomerRepo(Entities db)
        {
            this.db = db;
        }

        void ICrud<Customer, int>.Add(Customer e)
        {
            throw new NotImplementedException();
        }

        void ICrud<Customer, int>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        void ICrud<Customer, int>.Edit(Customer e)
        {
            throw new NotImplementedException();
        }

        List<Customer> ICrud<Customer, int>.Get()
        {
            return db.Customers.ToList();
        }

        Customer ICrud<Customer, int>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
