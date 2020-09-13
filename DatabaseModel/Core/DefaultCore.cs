using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModel.Core
{
    public abstract class DefaultCore<T> where T : class, IBaseClass
    {
        protected readonly MDU_DB_Entities Context;

        public DefaultCore()
        {
            Context = new MDU_DB_Entities();
        }

        public IQueryable<T> Query
        {
            get { return (IQueryable<T>)Context.Set(typeof(T)).AsQueryable(); }
        }

        public T RetornarPorId(int Id)
        {
            return (from c in Query
                    where c.Id == Id
                    select c).FirstOrDefault();
        }

        public List<T> RetornarTodos()
        {
            return (from c in Query
                    select c).ToList();
        }
    }
}
