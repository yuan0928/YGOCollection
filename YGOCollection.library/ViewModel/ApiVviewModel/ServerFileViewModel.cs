using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGOCollection.library.ViewModel.ApiVviewModel
{
    public class ServerFileViewModel
    {
        /// <summary>
        /// 流水號
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// 檔案原始名稱
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// 檔案顯示名稱
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// 檔案虛擬路徑
        /// </summary>
        public string FilePath { get; set; }
        /// <summary>
        /// 副檔名
        /// </summary>
        public string Extension { get; set; }
        /// <summary>
        /// 檔案大小
        /// </summary>
        public string FileSize { get; set; }
        /// <summary>
        /// 檔案描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 縮網址
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }
    }
}
