using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Data
{
    public abstract class Adapter<T>
    {
        public abstract List<T> GetAll();

        public abstract T GetOneByString(string userName);

        public abstract T Save(T entity);
    }
}
