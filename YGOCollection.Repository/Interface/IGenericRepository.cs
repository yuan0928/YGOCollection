using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGOCollection.Repository.Interface
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetList();
        Task<TEntity> GetById(object id);
        Task Add(TEntity entity);
        void Delete(TEntity entity);
        void SoftDelete(TEntity entity);
        void Update(TEntity entity);
    }
}
