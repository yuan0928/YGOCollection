using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGOCollection.Repository.DataModels;
using YGOCollection.Repository.Interface;

namespace YGOCollection.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly YGOContext _ygoContext;
        private DbSet<TEntity> _dbSet;
        public GenericRepository(YGOContext context) 
        {
            _ygoContext = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task Add(TEntity entity)
        {
            _dbSet.Add(entity);
            await _ygoContext.SaveChangesAsync();
        }

        public async Task Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
            await _ygoContext.SaveChangesAsync();
        }

        public async Task<TEntity> GetById(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetList()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _ygoContext.Entry(entity).State = EntityState.Modified;
            await _ygoContext.SaveChangesAsync();
        }
    }
}
