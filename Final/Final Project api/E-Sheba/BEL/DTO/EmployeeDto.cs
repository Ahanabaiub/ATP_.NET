using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.DTO
{
    public class EmployeeDto
    {
        public int id { get; set; }
        public int userid { get; set; }
        public double salary { get; set; }
        public int service_id { get; set; }
        public string work_area { get; set; }
        public string work_status { get; set; }

        public virtual UserDto User { get; set; }
    }
}
