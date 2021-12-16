﻿// <auto-generated />
using CERAXLAN.HB.DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CERAXLAN.HB.DataAccess.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20211216164657_uintPrice")]
    partial class uintPrice
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CERAXLAN.HB.Entities.Concrete.Campaign", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<long>("Duration")
                        .HasColumnType("bigint");

                    b.Property<int>("PriceManipulationLimit")
                        .HasColumnType("int");

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("TargetSalesCount")
                        .HasColumnType("bigint");

                    b.Property<long>("TotalSales")
                        .HasColumnType("bigint");

                    b.HasKey("Name");

                    b.ToTable("Campaigns");
                });

            modelBuilder.Entity("CERAXLAN.HB.Entities.Concrete.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Quantity")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CERAXLAN.HB.Entities.Concrete.Product", b =>
                {
                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<long>("Stock")
                        .HasColumnType("bigint");

                    b.HasKey("ProductCode");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
