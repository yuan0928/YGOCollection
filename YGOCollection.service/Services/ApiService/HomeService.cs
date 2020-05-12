using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGOCollection.library.Enums;
using YGOCollection.library.ViewModel;
using YGOCollection.library.ViewModel.ApiVviewModel;

namespace YGOCollection.service.Services.ApiService
{
    
    
    /*
    /// <summary>
    /// 首頁
    /// </summary>
    public class HomeService : BaseService
    {
        /// <summary>
        /// 取得中文版首頁資料
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public HomeViewModel GetData(HomeSearchViewModel model)
        {
            var result = new HomeViewModel();
 
            result.cardinfo = GetCardInfo(new BasicViewModel { NodeId = model.AddCardNodeId });
            
            return result;
        }
        /// <summary>
        /// 最新消息
        /// </summary>
        /// <returns></returns>
        public HomeListViewModel GetCardInfo(BasicViewModel model)
        {
            var nowdate = DateTime.Now;
            var result = new HomeListViewModel()
            {
                homelisttype = HomeListType.cardinfo,
                List = (from i in Db.Information
                          
                        select new InformationViewModel
                        {
                            Id = i.ID,
                            Subject = i.subject,
                            Content = i.content,
                            StartTime = i.update_at,
                        }).OrderBy(x => x.Sort).ThenByDescending(x => x.StartTime).Take(8).ToList()
            };

            return result;
        }
        
    }
    */
}
