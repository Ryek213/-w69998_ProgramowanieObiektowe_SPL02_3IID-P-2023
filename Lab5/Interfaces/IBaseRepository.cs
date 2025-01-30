using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Interfaces
{
    internal interface IBaseRepository<T, TEntity> where T : IEntity<TEntity>
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll();
        T Get(T entity);
    }
}
