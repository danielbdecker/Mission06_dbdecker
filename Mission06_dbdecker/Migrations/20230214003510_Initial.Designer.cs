﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_dbdecker.Models;

namespace Mission06_dbdecker.Migrations
{
    [DbContext(typeof(MoviesContext))]
    [Migration("20230214003510_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission06_dbdecker.Models.MovieResponse", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Edited")
                        .HasColumnType("TEXT");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            Category = "Horror",
                            Director = "Charles Martin Smith",
                            Notes = "A masterpiece",
                            Rating = "PG",
                            Title = "Air Bud",
                            Year = 1997
                        },
                        new
                        {
                            MovieID = 2,
                            Category = "Horror",
                            Director = "Richard Martin",
                            Notes = "Another masterpiece",
                            Rating = "G",
                            Title = "Air Bud: Golden Receiver",
                            Year = 1998
                        },
                        new
                        {
                            MovieID = 3,
                            Category = "Horror",
                            Director = "Bill Bannerman",
                            Notes = "Yet another masterpiece",
                            Rating = "G",
                            Title = "Air Bud: World Pup",
                            Year = 2000
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
