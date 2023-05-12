﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyDukan.Data;

#nullable disable

namespace MyDukan.Migrations
{
    [DbContext(typeof(MyDukanDBContex))]
    partial class MyDukanDBContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MyDukan.Models.Cart", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<decimal>("Discount")
                        .HasColumnType("Decimal(18,2)");

                    b.Property<int>("MedicineID")
                        .HasColumnType("Int");

                    b.Property<int>("Quantity")
                        .HasColumnType("Int");

                    b.Property<decimal>("Totalprice")
                        .HasColumnType("Decimal(18,2)");

                    b.Property<decimal>("UnitePrice")
                        .HasColumnType("Decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("Int");

                    b.HasKey("ID");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("MyDukan.Models.Medicines", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<decimal>("Discount")
                        .HasColumnType("Decimal(18,2)");

                    b.Property<DateTime>("ExpDate")
                        .HasColumnType("DateTime");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<int>("Status")
                        .HasColumnType("Int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("Decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("Medicines");
                });

            modelBuilder.Entity("MyDukan.Models.OrderItems", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<decimal>("Discount")
                        .HasColumnType("Decimal(18,2)");

                    b.Property<int>("MedicineID")
                        .HasColumnType("Int");

                    b.Property<int>("OrderId")
                        .HasColumnType("Int");

                    b.Property<int>("Quantity")
                        .HasColumnType("Int");

                    b.Property<decimal>("Totalprice")
                        .HasColumnType("Decimal(18,2)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("Decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("MyDukan.Models.Orders", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("OrderNo")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("Decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("Int");

                    b.HasKey("ID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MyDukan.Models.Users", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("DateTime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<decimal>("Fund")
                        .HasColumnType("Decimal(18,2)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<int>("Status")
                        .HasColumnType("Int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
