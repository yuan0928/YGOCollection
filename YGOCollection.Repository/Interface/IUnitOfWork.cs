using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGOCollection.Repository.Interface
{
    public interface IUnitOfWork<T> where T : class
    {
        IGenericRepository<T> GenericRepository { get; }
        Task SaveChanges();
    }
}
