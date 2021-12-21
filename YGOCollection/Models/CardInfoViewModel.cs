using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace YGOCollection.Models
{
    public class CardInfoViewModel
    {
        public int Id { get; set; }
        [DisplayName("卡片名稱")]
        public string Name { get; set; }
        [DisplayName("卡片類型")]
        public int CardTypeId { get; set; }
        [DisplayName("卡片系列")]
        public int CardSeriesId { get; set; }
        [DisplayName("編號")]
        public string SeriesNum { get; set; }
        [DisplayName("卡片密碼")]
        public string CardPassword { get; set; }
        public CardTypeViewModel CardType { get; set; }
        public CardSeriesViewModel CardSeries { get; set; }
    }
}
