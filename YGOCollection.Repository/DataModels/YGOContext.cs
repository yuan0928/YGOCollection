using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGOCollection.Repository.DataModels
{
    public class YGOContext : DbContext
    {
        public YGOContext(DbContextOptions<YGOContext> options) : base(options) { }

        public DbSet<CardInfo> CardInfos { get; set; }
        public DbSet<CardType> CardTypes { get; set; }
        public DbSet<CardSeries> CardSeries { get; set; }
    }
}
