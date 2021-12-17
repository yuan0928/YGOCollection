using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YGOCollection.Models
{
    public class CardSeriesViewModel
    {
        public int Id { get; set; }
        public string SeriesName { get; set; }
        public string SeriesCode { get; set; }
        public bool IsDelete { get; set; }
    }
}
