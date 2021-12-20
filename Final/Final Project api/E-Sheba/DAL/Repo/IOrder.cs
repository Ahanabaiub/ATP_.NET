using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public interface IOrder<T,ID> : ICrud<T,ID>
    {
        void Cancel(ID id);
        List<T> Search(string str);
        Dictionary<string, int> monthlyReport(string year);
    }
}
