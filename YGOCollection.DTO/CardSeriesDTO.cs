using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGOCollection.DTO
{
    public class CardSeriesDTO
    {
        public int Id { get; set; }
        public string SeriesName { get; set; }
        public string SeriesCode { get; set; }
        public bool IsDelete { get; set; }
    }
}
