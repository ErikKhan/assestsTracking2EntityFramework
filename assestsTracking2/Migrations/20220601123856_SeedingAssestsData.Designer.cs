﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using assestsTracking2;

#nullable disable

namespace assestsTracking2.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20220601123856_SeedingAssestsData")]
    partial class SeedingAssestsData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("assestsTracking2.Assests", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Office")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Assests");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            Brand = "Samsung",
                            Currency = "EUR",
                            Model = "S5",
                            Office = "Norway",
                            Price = 500f,
                            PurchaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2008),
                            Type = "Phone"
                        },
                        new
                        {
                            Id = 5,
                            Brand = "MAc",
                            Currency = "EUR",
                            Model = "i7",
                            Office = "Sweden",
                            Price = 500f,
                            PurchaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1995),
                            Type = "Laptop"
                        },
                        new
                        {
                            Id = 6,
                            Brand = "Nokia",
                            Currency = "EUR",
                            Model = "3310",
                            Office = "Germany",
                            Price = 500f,
                            PurchaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2009),
                            Type = "Phone"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}