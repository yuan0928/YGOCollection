using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGOCollection.library.ViewModel.ApiVviewModel
{
    public class VideoViewModel
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Site.Id
        /// </summary>
        public int SiteId { get; set; }
        /// <summary>
        /// Node.Id
        /// </summary>
        public int NodeId { get; set; }
        /// <summary>
        /// 發佈單位
        /// </summary>
        public Guid DepartmentId { get; set; }
        /// <summary>
        /// 分類
        /// </summary>
        public int? BaseCategoryId { get; set; }
        /// <summary>
        /// 圖檔
        /// </summary>
        public Guid ServerFileId { get; set; }
        /// <summary>
        /// 影音來源
        /// Youtube代碼 = 1,連結 = 3
        /// </summary>
        public int VideoType { get; set; }
        /// <summary>
        /// 主題
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 連結
        /// </summary>
        public string Link { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }
        /// <summary>
        /// 點選數
        /// </summary>
        public decimal ViewCount { get; set; }
        /// <summary>
        /// 建立時間
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 圖片路徑
        /// </summary>
        public string FilePath { get; set; }
    }
}
