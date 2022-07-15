using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGOCollection.Repository.DataModels
{
    public class CardInfo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int CardTypeId { get; set; }
        public int CardSeriesId { get; set; }
        public string SeriesNum { get; set; }
        public string CardPassword { get; set; }
        public string ImagePath { get; set; }
        public bool IsDelete { get; set; }
        public virtual CardType CardType { get; set; }
        public virtual CardSeries CardSeries { get; set; }
    }
}
