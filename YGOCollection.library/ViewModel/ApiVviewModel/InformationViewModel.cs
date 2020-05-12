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
        /// <summary>
        /// 流水號
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// 主旨
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// 內容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 閱覽數
        /// </summary>
        public int ReadCount { get; set; }
        /// <summary>
        /// 上架時間
        /// </summary>
        public DateTime StartTime { get; set; }
    }
}
