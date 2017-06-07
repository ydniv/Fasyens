using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fasyens.Commons;
using System.Data.Entity;

namespace Fasyens.DAL
{
    public class RepoBase<T> : IRepository<T> where T : FasyensParent
    {
        protected fasyenContext context = new fasyenContext();
        protected DbSet<T> dbSet;

        public RepoBase()
        {
            dbSet = context.Set<T>();
        }
        public void Delete(long id)
        {
            var entity = GetById(id);
            dbSet.Remove(entity);
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public List<T> GetAll()
        {
            return dbSet.OrderBy(e => e.Id).ToListAsync().Result;
        }

        public T GetById(long id)
        {
            return dbSet.Find(id);
        }

        public void Save(T entity)
        {
            if (entity.Id == 0)
                dbSet.Add(entity);
            else
            {
                context.Entry(entity).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
    }
}
