using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    class OrderRepo : IOrder<Order, int>
    {

        Entities db;
        public OrderRepo(Entities db)
        {
            this.db = db;
        }

        public void Add(Order e)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Order e)
        {
            throw new NotImplementedException();
        }

        public List<Order> Get()
        {
            return db.Orders.ToList();
        }

        public Order Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
