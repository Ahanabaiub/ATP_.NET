using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.DTO
{
    public class OrderDetailDto
    {
        public int id { get; set; }
        public int order_id { get; set; }
        public int service_id { get; set; }
        public double unit_price { get; set; }
        public int quantity { get; set; }

        public virtual ServiceDto Service { get; set; }
        public virtual EmployeeDto Employee { get; set; }
    }
}
