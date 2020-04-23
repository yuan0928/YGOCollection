using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGOCollection.library.Enums
{
    public enum HomeListType
    {
        /// <summary>
        /// 卡片新增
        /// </summary>
        [Display(Name = "卡片新增", Description = "卡片新增")]
        cardinfo,
        /// <summary>
        /// 功能新增
        /// </summary>
        [Display(Name = "功能新增", Description = "功能新增")]
        features,
        /// <summary>
        /// 其他事項
        /// </summary>
        [Display(Name = "其他事項", Description = "其他事項")]
        other,
        /// <summary>
        /// Notice to Mariners
        /// </summary>
        [Display(Name = "Notice to Mariners", Description = "Notice to Mariners")]
        noticetomariners,
    }
}
