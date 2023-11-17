﻿// <auto-generated />
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
    [Migration("20231117114858_SeedingElectronicData")]
    partial class SeedingElectronicData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFAssetsTracking.Electronic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.HasKey("Id");

                    b.HasIndex("ElectronicId");

                    b.ToTable("Gadgets");
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
