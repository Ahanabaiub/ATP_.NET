using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.DTO
{
    public class Access_tokenDto
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public string token { get; set; }
        public System.DateTime created_at { get; set; }
        public Nullable<System.DateTime> expired_at { get; set; }
        public virtual UserDto User { get; set; }
    }
}
