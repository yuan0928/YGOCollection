using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YGOCollection.Models
{
    public class CardInfoViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CardTypeId { get; set; }
        public int CardSeriesId { get; set; }
        public string SeriesNum { get; set; }
        public string CardPassword { get; set; }
        public CardTypeViewModel CardType { get; set; }
        public CardSeriesViewModel CardSeries { get; set; }
    }
}
