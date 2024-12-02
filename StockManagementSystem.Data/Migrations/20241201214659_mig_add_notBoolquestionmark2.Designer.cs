﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockManagementSystem.Data.Context;

#nullable disable

namespace StockManagementSystem.Data.Migrations
{
    [DbContext(typeof(StockManagementContext))]
    [Migration("20241201214659_mig_add_notBoolquestionmark2")]
    partial class mig_add_notBoolquestionmark2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StockManagementSystem.Core.Entities.CurrencyUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CurrencyUnitMoney")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CurrencyUnits");
                });

            modelBuilder.Entity("StockManagementSystem.Core.Entities.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CabinetInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CriticalQuantity")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<decimal?>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShelfInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StockClassId")
                        .HasColumnType("int");

                    b.Property<int?>("StockTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("StockUnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StockClassId");

                    b.HasIndex("StockTypeId");

                    b.HasIndex("StockUnitId");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("StockManagementSystem.Core.Entities.StockClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("StockClassName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StockClasses");
                });

            modelBuilder.Entity("StockManagementSystem.Core.Entities.StockQuantityUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("QuantityUnit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StockQuantityUnits");
                });

            modelBuilder.Entity("StockManagementSystem.Core.Entities.StockType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("StockTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StockTypes");
                });

            modelBuilder.Entity("StockManagementSystem.Core.Entities.StockUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BuyingPrice")
                        .HasColumnType("int");

                    b.Property<int?>("CurrencyUnitId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("PaperWeight")
                        .HasColumnType("int");

                    b.Property<int?>("SalePrice")
                        .HasColumnType("int");

                    b.Property<int?>("StockQuantityUnitId")
                        .HasColumnType("int");

                    b.Property<int?>("StockTypeId")
                        .HasColumnType("int");

                    b.Property<string>("StockUnitCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StockUnitName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyUnitId");

                    b.HasIndex("StockQuantityUnitId");

                    b.HasIndex("StockTypeId");

                    b.ToTable("StockUnits");
                });

            modelBuilder.Entity("StockManagementSystem.Core.Entities.Stock", b =>
                {
                    b.HasOne("StockManagementSystem.Core.Entities.StockClass", "StockClass")
                        .WithMany()
                        .HasForeignKey("StockClassId");

                    b.HasOne("StockManagementSystem.Core.Entities.StockType", "StockType")
                        .WithMany()
                        .HasForeignKey("StockTypeId");

                    b.HasOne("StockManagementSystem.Core.Entities.StockUnit", "StockUnit")
                        .WithMany()
                        .HasForeignKey("StockUnitId");

                    b.Navigation("StockClass");

                    b.Navigation("StockType");

                    b.Navigation("StockUnit");
                });

            modelBuilder.Entity("StockManagementSystem.Core.Entities.StockUnit", b =>
                {
                    b.HasOne("StockManagementSystem.Core.Entities.CurrencyUnit", "CurrencyUnit")
                        .WithMany()
                        .HasForeignKey("CurrencyUnitId");

                    b.HasOne("StockManagementSystem.Core.Entities.StockQuantityUnit", "StockQuantity")
                        .WithMany()
                        .HasForeignKey("StockQuantityUnitId");

                    b.HasOne("StockManagementSystem.Core.Entities.StockType", "StockType")
                        .WithMany()
                        .HasForeignKey("StockTypeId");

                    b.Navigation("CurrencyUnit");

                    b.Navigation("StockQuantity");

                    b.Navigation("StockType");
                });
#pragma warning restore 612, 618
        }
    }
}
