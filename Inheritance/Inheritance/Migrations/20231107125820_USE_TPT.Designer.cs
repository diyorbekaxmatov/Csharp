﻿// <auto-generated />
using Inheritance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Inheritance.Migrations
{
    [DbContext(typeof(DatabaseDbContext))]
    [Migration("20231107125820_USE_TPT")]
    partial class USE_TPT
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Inheritance.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ValidityTime")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Inheritance.Models.Fruits", b =>
                {
                    b.HasBaseType("Inheritance.Models.Product");

                    b.Property<double>("SaveTemperature")
                        .HasColumnType("float");

                    b.ToTable("Fruits");
                });

            modelBuilder.Entity("Inheritance.Models.Waters", b =>
                {
                    b.HasBaseType("Inheritance.Models.Product");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.ToTable("Waters");
                });

            modelBuilder.Entity("Inheritance.Models.CarbonatedWater", b =>
                {
                    b.HasBaseType("Inheritance.Models.Waters");

                    b.Property<double>("Carbonate")
                        .HasColumnType("float");

                    b.ToTable("CarbonatedWater");
                });

            modelBuilder.Entity("Inheritance.Models.StillWater", b =>
                {
                    b.HasBaseType("Inheritance.Models.Waters");

                    b.Property<double>("SaveTemprature")
                        .HasColumnType("float");

                    b.ToTable("StillWater");
                });

            modelBuilder.Entity("Inheritance.Models.Fruits", b =>
                {
                    b.HasOne("Inheritance.Models.Product", null)
                        .WithOne()
                        .HasForeignKey("Inheritance.Models.Fruits", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Inheritance.Models.Waters", b =>
                {
                    b.HasOne("Inheritance.Models.Product", null)
                        .WithOne()
                        .HasForeignKey("Inheritance.Models.Waters", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Inheritance.Models.CarbonatedWater", b =>
                {
                    b.HasOne("Inheritance.Models.Waters", null)
                        .WithOne()
                        .HasForeignKey("Inheritance.Models.CarbonatedWater", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Inheritance.Models.StillWater", b =>
                {
                    b.HasOne("Inheritance.Models.Waters", null)
                        .WithOne()
                        .HasForeignKey("Inheritance.Models.StillWater", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}