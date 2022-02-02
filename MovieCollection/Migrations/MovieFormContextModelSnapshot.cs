﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieCollection.Models;

namespace MovieCollection.Migrations
{
    [DbContext(typeof(MovieFormContext))]
    partial class MovieFormContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("MovieCollection.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Miscellaneous"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "VHS"
                        });
                });

            modelBuilder.Entity("MovieCollection.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<int>("RatingId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<short>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("RatingId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = 3,
                            Director = "Boaz Yakin",
                            Edited = false,
                            LentTo = "",
                            Notes = "Conner's Favs #1",
                            RatingId = 2,
                            Title = "Remember the Titans",
                            Year = (short)2000
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryId = 6,
                            Director = "Michael Gracey",
                            Edited = false,
                            LentTo = "",
                            Notes = "Conner's Favs #2",
                            RatingId = 2,
                            Title = "Greatest Showman, The",
                            Year = (short)2017
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryId = 4,
                            Director = "Dan Scanlon",
                            Edited = false,
                            LentTo = "",
                            Notes = "Conner's Favs #3",
                            RatingId = 2,
                            Title = "Onward",
                            Year = (short)2000
                        });
                });

            modelBuilder.Entity("MovieCollection.Models.Rating", b =>
                {
                    b.Property<int>("RatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("RatingName")
                        .HasColumnType("TEXT");

                    b.HasKey("RatingId");

                    b.ToTable("Rating");

                    b.HasData(
                        new
                        {
                            RatingId = 1,
                            RatingName = "G"
                        },
                        new
                        {
                            RatingId = 2,
                            RatingName = "PG"
                        },
                        new
                        {
                            RatingId = 3,
                            RatingName = "PG-13"
                        },
                        new
                        {
                            RatingId = 4,
                            RatingName = "R"
                        },
                        new
                        {
                            RatingId = 5,
                            RatingName = "UR"
                        },
                        new
                        {
                            RatingId = 6,
                            RatingName = "NR"
                        },
                        new
                        {
                            RatingId = 7,
                            RatingName = "TV-14"
                        },
                        new
                        {
                            RatingId = 8,
                            RatingName = "TV-PG"
                        },
                        new
                        {
                            RatingId = 9,
                            RatingName = "TV-Y7"
                        });
                });

            modelBuilder.Entity("MovieCollection.Models.Movie", b =>
                {
                    b.HasOne("MovieCollection.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieCollection.Models.Rating", "Rating")
                        .WithMany()
                        .HasForeignKey("RatingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
