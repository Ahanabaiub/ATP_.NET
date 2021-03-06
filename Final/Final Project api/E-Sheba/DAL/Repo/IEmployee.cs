using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public interface IEmployee<T,ID> : ICrud<T,ID>
    {
        List<T> GetByServiceId(ID id);
    }
}
