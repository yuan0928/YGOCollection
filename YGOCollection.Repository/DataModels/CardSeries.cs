using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGOCollection.Repository.DataModels
{
    public class CardSeries
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string SeriesName { get; set; }
        public string SeriesCode { get; set; }
        public bool IsDelete { get; set; }
    }
}
