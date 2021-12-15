using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGOCollection.Repository.DataModels
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CardType>().HasData(
                new CardType { Id = 1, TypeName = "怪獸卡" },
                new CardType { Id = 2, TypeName = "魔法卡" },
                new CardType { Id = 3, TypeName = "陷阱卡" }
                );
        }
    }
}
