﻿// <auto-generated />
using System;
using EFAssetsTracking;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFAssetsTracking.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20231117145553_SeedingDataToGadget")]
    partial class SeedingDataToGadget
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EFAssetsTracking.Electronic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Electronics");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Computer"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Mobile"
                        });
                });

            modelBuilder.Entity("EFAssetsTracking.Gadget", b =>
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

                    b.Property<int>("ElectronicId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Office")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ElectronicId");

                    b.ToTable("Gadgets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "MacBook",
                            Currency = "SEK",
                            ElectronicId = 1,
                            Model = "SD",
                            Office = "Sweden",
                            Price = 300,
                            PurchaseDate = new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Samsung",
                            Currency = "USD",
                            ElectronicId = 2,
                            Model = "SD",
                            Office = "USA",
                            Price = 100,
                            PurchaseDate = new DateTime(2022, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Motorolla",
                            Currency = "INR",
                            ElectronicId = 2,
                            Model = "HD",
                            Office = "India",
                            Price = 3300,
                            PurchaseDate = new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Asus",
                            Currency = "INR",
                            ElectronicId = 1,
                            Model = "HD",
                            Office = "India",
                            Price = 8000,
                            PurchaseDate = new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Brand = "HP",
                            Currency = "SEK",
                            ElectronicId = 1,
                            Model = "Note",
                            Office = "Sweden",
                            Price = 300,
                            PurchaseDate = new DateTime(2019, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("EFAssetsTracking.Gadget", b =>
                {
                    b.HasOne("EFAssetsTracking.Electronic", "Electronic")
                        .WithMany("Gadgets")
                        .HasForeignKey("ElectronicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Electronic");
                });

            modelBuilder.Entity("EFAssetsTracking.Electronic", b =>
                {
                    b.Navigation("Gadgets");
                });
#pragma warning restore 612, 618
        }
    }
}
