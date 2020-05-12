using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGOCollection.library.ViewModel
{
    public class BasicViewModel
    {
        /// <summary>
        /// Site.Id
        /// </summary>
        public int SiteId { get; set; }
        /// <summary>
        /// Node.Id
        /// </summary>
        public int NodeId { get; set; }
        /// <summary>
        /// Node.NodeId
        /// </summary>
        public int? ParentNodeId { get; set; }
        /// <summary>
        /// Module.Id
        /// </summary>
        public int ModuleId { get; set; }
        /// <summary>
        /// Module.Controller
        /// </summary>
        public string ModuleController { get; set; }
        /// <summary>
        /// Node.Sort
        /// </summary>
        public int Sort { get; set; }
        /// <summary>
        /// Node.Name
        /// </summary>
        public string NodeName { get; set; }
        public string BackToListUrl { get; set; }
        /// <summary>
        /// Node.CmsUrl
        /// </summary>
        public string CmsUrl { get; set; }
        /// <summary>
        /// Node.WebUrl
        /// </summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// Node.IsHasTab
        /// </summary>
        public bool IsHasTab { get; set; }
        /// <summary>
        /// BaseCategory.Id
        /// </summary>
        public int? BaseCategoryId { get; set; }
        /// <summary>
        /// 關鍵字
        /// </summary>
        public string SearchKey { get; set; }
        public int? Page { get; set; }
        public int PageSize { get; set; }
        public Guid GuidId { get; set; }
        public Guid orId { get; set; }
        /// <summary>
        /// 判斷是否是民眾常辦業務
        /// </summary>
        public bool IsTop { get; set; }
    }
}
