using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class OrderDetailsRepo : IOrderDetails<Order_Details, int>
    {
        Entities db;
        public OrderDetailsRepo(Entities db)
        {
            this.db = db;
        }
        public void Add(Order_Details e)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Order_Details e)
        {
            throw new NotImplementedException();
        }

        public List<Order_Details> Get()
        {
            return db.Order_Details.ToList();
        }

        public Order_Details Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order_Details> OrderDetailsByOrderId(int id)
        {
            var orderd = (from e in db.Order_Details
                          where e.order_id == id
                          select e
                            ).ToList();
            return orderd;
        }

        public List<Order_Details> OrderDetailsByServiceId(int id)
        {
            return db.Order_Details.Where(o => o.service_id == id).ToList();
        }
    }
}
