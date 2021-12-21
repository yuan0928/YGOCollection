using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace YGOCollection.Models
{
    public class CardTypeViewModel
    {
        public int Id { get; set; }
        [DisplayName("卡片類型")]
        public string TypeName { get; set; }
        public bool IsDelete { get; set; }
    }
}
