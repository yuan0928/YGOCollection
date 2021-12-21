using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGOCollection.Repository.DataModels;
using YGOCollection.Repository.Interface;

namespace YGOCollection.Repository
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T :class
    {
        private readonly YGOContext _ygoContext;
        private readonly IGenericRepository<T> _genericRepository;
        public UnitOfWork(YGOContext ygoContext, IGenericRepository<T> genericRepository) 
        {
            _ygoContext = ygoContext;
            _genericRepository = genericRepository;
        }

        public IGenericRepository<T> GenericRepository
        {
            get
            {
                return _genericRepository;
            }
        }

        public async Task SaveChanges()
        {
            await _ygoContext.SaveChangesAsync();
        }
    }
}
