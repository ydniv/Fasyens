using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasyens.Commons
{
    public interface IRepository<T> : IDisposable where T : FasyensParent
    {
        void Save(T entity);
        void Delete(long id);
        T GetById(long id);
        List<T> GetAll();
    }
}
