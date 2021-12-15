using System;

namespace YGOCollection.DTO
{
    public class CardInfoDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CardTypeId { get; set; }
        public int CardSeriesId { get; set; }
        public string SeriesNum { get; set; }
        public string CardPassword { get; set; }
    }
}
