using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGOCollection.Service.Interface
{
    public interface IGenericService<T>
    {
        Task<IEnumerable<T>> GetList();
        Task<T> GetDataById(int? id);
        Task AddData(T model);
        Task UpdateData(T model);
        Task DeleteData(int? id);
        
    }
}
