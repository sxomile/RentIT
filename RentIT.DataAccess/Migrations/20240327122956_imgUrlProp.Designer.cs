﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentIT.DataAccess.Data;

#nullable disable

namespace RentIT.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240327122956_imgUrlProp")]
    partial class imgUrlProp
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RentIT.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsGift")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RentTime")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Fudbalska lopta koju ne koristim vise",
                            ImageUrl = "",
                            IsGift = false,
                            Name = "Lopta",
                            RentTime = 10
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            ImageUrl = "",
                            IsGift = false,
                            Name = "Set knjiga Hari Poter",
                            RentTime = 60
                        },
                        new
                        {
                            Id = 3,
                            Description = "Trouglasta Lara Kroft, pozajmica ko zeli da igra",
                            ImageUrl = "",
                            IsGift = false,
                            Name = "Tomb Raider PS1",
                            RentTime = 20
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
