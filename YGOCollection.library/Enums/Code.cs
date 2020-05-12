using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGOCollection.library.Enums
{
    public enum Code
    {
        /// <summary>
        /// 失敗
        /// </summary>
        [Display(Description = "失敗")]
        Fail = 0,
        /// <summary>
        /// 成功
        /// </summary>
        [Display(Description = "成功")]
        Success = 1
    }
}
