using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGOCollection.Service.Interface
{
    public interface IGenericService<T>
    {
        /// <summary>
        /// 取得所有資料
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> GetList();
        /// <summary>
        /// 條件搜尋
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> GetListBy(int condition);
        /// <summary>
        /// 取得單一資料
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> GetDataById(int? id);
        /// <summary>
        /// 新增一筆資料
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task AddData(T model);
        /// <summary>
        /// 更新一筆資料
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task UpdateData(T model);
        /// <summary>
        /// 刪除一筆資料
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteData(int? id);
        /// <summary>
        /// 刪除一筆資料(軟更新)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task SoftDeleteData(int? id);

    }
}
