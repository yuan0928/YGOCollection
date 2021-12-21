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
    public class CardInfoRepository : IGenericRepository<CardInfo>
    {
        private readonly YGOContext _ygoContext;
        private DbSet<CardInfo> _dbSet;
        public CardInfoRepository(YGOContext context) 
        {
            _ygoContext = context;
            _dbSet = context.Set<CardInfo>();
        }
        public async Task Add(CardInfo entity)
        {
            _dbSet.Add(entity);
            await _ygoContext.SaveChangesAsync();
        }

        public async Task Delete(CardInfo entity)
        {
            if (_ygoContext.Entry(entity).State == EntityState.Deleted) 
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
            await _ygoContext.SaveChangesAsync();
        }
        public async Task SoftDelete(CardInfo entity)
        {

            _dbSet.Attach(entity);
            _ygoContext.Entry(entity).State = EntityState.Modified;
            await _ygoContext.SaveChangesAsync();
        }

        public async Task<CardInfo> GetById(object id)
        {
            return await _dbSet.Include(c => c.CardSeries).Include(c => c.CardType).FirstOrDefaultAsync(m => m.Id == (int)id);
        }

        public async Task<IEnumerable<CardInfo>> GetList()
        {
            return await _dbSet.Include(c => c.CardSeries).Include(c => c.CardType).ToListAsync();
        }

        public async Task Update(CardInfo entity)
        {
            _dbSet.Attach(entity);
            _ygoContext.Entry(entity).State = EntityState.Modified;
            await _ygoContext.SaveChangesAsync();
        }
    }
}
