using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGOCollection.library.Enums;

namespace YGOCollection.library.ViewModel.ApiVviewModel
{
    public class HomeViewModel
    {
       /// <summary>
       /// 卡片新增
       /// </summary>
       public HomeListViewModel latest { get; set; }
    }
    public class HomeListViewModel
    {
        public HomeListType Homelisttype { get; set; }
        public List<InformationViewModel> List { get; set; }
        public List<VideoViewModel> VideoList { get; set; }
        public List<BaseCategoryViewModel> VideoBaseCategoryList { get; set; }
    }
}
