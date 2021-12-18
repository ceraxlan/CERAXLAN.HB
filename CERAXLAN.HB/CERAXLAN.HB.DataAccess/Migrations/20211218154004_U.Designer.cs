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
    [Migration("20211218154004_U")]
    partial class U
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

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("PriceManipulationLimit")
                        .HasColumnType("int");

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TargetSalesCount")
                        .HasColumnType("int");

                    b.Property<int>("TotalPayment")
                        .HasColumnType("int");

                    b.Property<int>("TotalSales")
                        .HasColumnType("int");

                    b.Property<int>("Turnover")
                        .HasColumnType("int");

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

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CERAXLAN.HB.Entities.Concrete.Product", b =>
                {
                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("FirstPrice")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<bool>("ProductDiscount")
                        .HasColumnType("bit");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("ProductCode");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}