using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public interface IOrderDetails<T,ID> : ICrud<T,ID>
    {
        List<T> OrderDetailsByOrderId(ID id);
        List<T> OrderDetailsByServiceId(ID id);
    }
}
