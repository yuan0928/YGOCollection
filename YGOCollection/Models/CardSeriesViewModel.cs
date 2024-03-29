﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace YGOCollection.Models
{
    public class CardSeriesViewModel
    {
        public int Id { get; set; }
        [DisplayName("系列名稱")]
        public string SeriesName { get; set; }
        [DisplayName("系列代號")]
        public string SeriesCode { get; set; }
        [DisplayName("張數")]
        public int Piece { get; set; }
        [DisplayName("期數")]
        public int Period { get; set; }
        public bool IsDelete { get; set; }
    }
}
