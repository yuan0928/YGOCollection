using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGOCollection.library.ViewModel.ApiVviewModel
{   
    /// <summary>
    /// 文字列表 模型
    /// </summary>
    public class InformationViewModel
    {
        public InformationViewModel()
        {
            Sort = 0;
        }
        /// <summary>
        /// 流水號
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// 所屬網站
        /// </summary>
        public int SiteId { get; set; }
        /// <summary>
        /// 所屬節點
        /// </summary>
        public int NodeId { get; set; }
        /// <summary>
        /// 航船布告 流水號
        /// </summary>
        public int? SerialNumber { get; set; }
        /// <summary>
        /// 發佈單位編號
        /// </summary>
        public Guid DepartmetId { get; set; }
        /// <summary>
        /// 發佈單位名稱
        /// </summary>
        public string DepartmetName { get; set; }
        /// <summary>
        /// 所屬頁籤(分類)編號
        /// </summary>
        public int? BaseCategoryId { get; set; }
        /// <summary>
        /// 所屬頁籤(分類)名稱
        /// </summary>
        public string BaseCategoryName { get; set; }
        /// <summary>
        /// 呈現方式
        /// </summary>
        public int ContentType { get; set; }
        /// <summary>
        /// 封面圖檔 ID
        /// </summary>
        public Guid? FrontCoverServerFileId { get; set; }
        /// <summary>
        /// 封面圖檔說明文字
        /// </summary>
        public string FrontCoverDescription { get; set; }
        /// <summary>
        /// 封面圖檔檔案
        /// </summary>
        public ServerFileViewModel FrontCoverImage { get; set; }
        /// <summary>
        /// 主旨
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// 內容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 單附件下載
        /// </summary>
        public Guid? ServerFileId { get; set; }
        /// <summary>
        /// 超連結
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// 上架時間
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 下架時間
        /// </summary>
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// 是否永不下架
        /// </summary>
        public bool IsNeverDown { get; set; }
        /// <summary>
        /// 是否顯示於前台首頁
        /// </summary>
        public bool IsShowOnWebHomePage { get; set; }
        /// <summary>
        /// 是否為緊急訊息
        /// </summary>
        public bool IsNotice { get; set; }
        /// <summary>
        /// 閱覽數
        /// </summary>
        public int ReadCount { get; set; }
        /// <summary>
        /// 核檢時間
        /// </summary>
        public DateTime? VerifyTime { get; set; }
        /// <summary>
        /// 核檢單位
        /// </summary>
        public Guid? VerifyUserId { get; set; }
        /// <summary>
        /// 檔案路徑
        /// </summary>
        public string FilePath { get; set; }
        /// <summary>
        /// 圖片
        /// </summary>
        public IEnumerable<ServerFileViewModel> InforImage { get; set; }
        /// <summary>
        /// 附件
        /// </summary>
        public IEnumerable<ServerFileViewModel> InforAttach { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }
        /// <summary>
        /// 建立時間
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 更新時間
        /// </summary>
        public DateTime? ModifyTime { get; set; }
        /// <summary>
        /// 網站名稱
        /// </summary>
        public string SubjectName { get; set; }
        /// <summary>
        /// 單附件下載的副檔名
        /// </summary>
        public string FileExtension { get; set; }
    }
}
