﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcMovie.Data;

#nullable disable

namespace BaithiLTH0255.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    partial class MvcMovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("BaithiLTH0255.Models.LTHCau3", b =>
                {
                    b.Property<string>("Masinhvien")
                        .HasColumnType("TEXT");

                    b.Property<string>("Hoten")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Malop")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Masinhvien");

                    b.ToTable("LTHCau3");
                });
#pragma warning restore 612, 618
        }
    }
}