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

        public void Cancel(int id)
        {
            var rs = Get(id);
           // Console.WriteLine(".....########### "+rs.delevery_address);
            rs.status = "3";


            db.SaveChanges();

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
            return db.Orders.Where(e => e.id == id).FirstOrDefault();
        }

        public List<Order> Search(string str)
        {
            var res = Get();
            List<Order> orders = new List<Order>();

            foreach (Order o in res)
            {
                if (o.order_place_date.ToShortDateString().Contains(str))
                {
                    orders.Add(o);
                }
            }

            return orders;
        }

        public Dictionary<string, int> monthlyReport(string year)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string[] months = {"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep",
                "Oct","Nov","Dec" };
            var orders = Get();

            for(int i=0; i<12; i++)
            {
                string mn = (i + 1 <= 9) ? "0" + (i + 1) : ""+(i + 1);
                string s = year+"/"+mn;
                int count = 0;
                foreach(var o in orders)
                {

                    var s2 = o.order_place_date.ToString("yyyy/MM/dd");


                    if (s2.StartsWith(s))
                    {
                        count++;
                    }

                }

                dict[months[i]] = count;
                
            }

            return dict;
        }
    }
}
