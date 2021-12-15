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
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<CardType>().HasData(
                 new CardType { Id = 1, TypeName = "怪獸卡" },
                 new CardType { Id = 2, TypeName = "魔法卡" },
                 new CardType { Id = 3, TypeName = "陷阱卡" }
                 );
        }
        public DbSet<CardInfo> CardInfos { get; set; }
        public DbSet<CardType> CardTypes { get; set; }
        public DbSet<CardSeries> CardSeries { get; set; }
    }
}
