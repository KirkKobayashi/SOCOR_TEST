﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TruckScale.Library.Data.DBContext;

#nullable disable

namespace TruckScale.Library.Migrations
{
    [DbContext(typeof(ScaleDbContext))]
    [Migration("20240227154045_addedDRField")]
    partial class addedDRField
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TruckScale.Library.Data.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("TruckScale.Library.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("TruckScale.Library.Data.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("TruckScale.Library.Data.Models.Truck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PlateNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TareWeight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Trucks");
                });

            modelBuilder.Entity("TruckScale.Library.Data.Models.Weigher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Weighers");
                });

            modelBuilder.Entity("TruckScale.Library.Data.Models.WeighingTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("DrNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Driver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FirstWeight")
                        .HasColumnType("int");

                    b.Property<DateTime>("FirstWeightDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Quantity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SecondWeight")
                        .HasColumnType("int");

                    b.Property<DateTime>("SecondWeightDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SupplierId")
                        .HasColumnType("int");

                    b.Property<int>("TicketNumber")
                        .HasColumnType("int");

                    b.Property<int?>("TruckId")
                        .HasColumnType("int");

                    b.Property<int?>("WeigherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SupplierId");

                    b.HasIndex("TruckId");

                    b.HasIndex("WeigherId");

                    b.ToTable("WeighingTransactions");
                });

            modelBuilder.Entity("TruckScale.Library.Data.Models.WeighingTransaction", b =>
                {
                    b.HasOne("TruckScale.Library.Data.Models.Customer", "Customer")
                        .WithMany("Transactions")
                        .HasForeignKey("CustomerId");

                    b.HasOne("TruckScale.Library.Data.Models.Product", "Product")
                        .WithMany("Transactions")
                        .HasForeignKey("ProductId");

                    b.HasOne("TruckScale.Library.Data.Models.Supplier", "Supplier")
                        .WithMany("Transactions")
                        .HasForeignKey("SupplierId");

                    b.HasOne("TruckScale.Library.Data.Models.Truck", "Truck")
                        .WithMany("Transactions")
                        .HasForeignKey("TruckId");

                    b.HasOne("TruckScale.Library.Data.Models.Weigher", "Weigher")
                        .WithMany("Transactions")
                        .HasForeignKey("WeigherId");

                    b.Navigation("Customer");

                    b.Navigation("Product");

                    b.Navigation("Supplier");

                    b.Navigation("Truck");

                    b.Navigation("Weigher");
                });

            modelBuilder.Entity("TruckScale.Library.Data.Models.Customer", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("TruckScale.Library.Data.Models.Product", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("TruckScale.Library.Data.Models.Supplier", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("TruckScale.Library.Data.Models.Truck", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("TruckScale.Library.Data.Models.Weigher", b =>
                {
                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
