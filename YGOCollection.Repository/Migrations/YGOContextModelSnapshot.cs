﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YGOCollection.Repository.DataModels;

namespace YGOCollection.Repository.Migrations
{
    [DbContext(typeof(YGOContext))]
    partial class YGOContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("YGOCollection.Repository.DataModels.CardInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CardPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CardSeriesId")
                        .HasColumnType("int");

                    b.Property<int>("CardTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeriesNum")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CardSeriesId");

                    b.HasIndex("CardTypeId");

                    b.ToTable("CardInfos");
                });

            modelBuilder.Entity("YGOCollection.Repository.DataModels.CardSeries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("SeriesCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeriesName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CardSeries");
                });

            modelBuilder.Entity("YGOCollection.Repository.DataModels.CardType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CardTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDelete = false,
                            TypeName = "怪獸卡"
                        },
                        new
                        {
                            Id = 2,
                            IsDelete = false,
                            TypeName = "魔法卡"
                        },
                        new
                        {
                            Id = 3,
                            IsDelete = false,
                            TypeName = "陷阱卡"
                        });
                });

            modelBuilder.Entity("YGOCollection.Repository.DataModels.CardInfo", b =>
                {
                    b.HasOne("YGOCollection.Repository.DataModels.CardSeries", "CardSeries")
                        .WithMany()
                        .HasForeignKey("CardSeriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YGOCollection.Repository.DataModels.CardType", "CardType")
                        .WithMany()
                        .HasForeignKey("CardTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CardSeries");

                    b.Navigation("CardType");
                });
#pragma warning restore 612, 618
        }
    }
}
