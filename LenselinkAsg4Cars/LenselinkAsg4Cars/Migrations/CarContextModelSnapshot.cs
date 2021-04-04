﻿// <auto-generated />
using LenselinkAsg10.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LenselinkAsg10.Migrations
{
    [DbContext(typeof(CarContext))]
    partial class CarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LenselinkAsg4Cars.Models.Car", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MakeModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mileage")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Color = "Silver",
                            MakeModel = "Nissan Sentra",
                            Mileage = 84574,
                            Price = 8995,
                            Year = 2013
                        },
                        new
                        {
                            ID = 2,
                            Color = "Blue",
                            MakeModel = "Chevrolet Spark LS",
                            Mileage = 35304,
                            Price = 8995,
                            Year = 2014
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
