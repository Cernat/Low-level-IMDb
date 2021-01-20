﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviesWebApp.Data;

namespace MoviesWebApp.Migrations
{
    [DbContext(typeof(UserDbContext))]
    [Migration("20210114224335_ManyToMany")]
    partial class ManyToMany
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("MoviesWebApp.Entities.CommentOfList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ListOfMoviesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ListOfMoviesId")
                        .IsUnique();

                    b.ToTable("CommentOfList");
                });

            modelBuilder.Entity("MoviesWebApp.Entities.ListAndMovies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ListOfMoviesId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ListOfMoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("ListAndMovies");
                });

            modelBuilder.Entity("MoviesWebApp.Entities.ListOfMovies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ListOfMovies");
                });

            modelBuilder.Entity("MoviesWebApp.Entities.Movies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Genres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MoviesWebApp.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MoviesWebApp.Entities.CommentOfList", b =>
                {
                    b.HasOne("MoviesWebApp.Entities.ListOfMovies", "ListOfMovies")
                        .WithOne("CommentOfList")
                        .HasForeignKey("MoviesWebApp.Entities.CommentOfList", "ListOfMoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ListOfMovies");
                });

            modelBuilder.Entity("MoviesWebApp.Entities.ListAndMovies", b =>
                {
                    b.HasOne("MoviesWebApp.Entities.ListOfMovies", "ListOfMovies")
                        .WithMany("ListAndMovies")
                        .HasForeignKey("ListOfMoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MoviesWebApp.Entities.Movies", "Movies")
                        .WithMany("ListAndMovies")
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ListOfMovies");

                    b.Navigation("Movies");
                });

            modelBuilder.Entity("MoviesWebApp.Entities.ListOfMovies", b =>
                {
                    b.HasOne("MoviesWebApp.Entities.User", "User")
                        .WithMany("ListOfMovies")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MoviesWebApp.Entities.ListOfMovies", b =>
                {
                    b.Navigation("CommentOfList");

                    b.Navigation("ListAndMovies");
                });

            modelBuilder.Entity("MoviesWebApp.Entities.Movies", b =>
                {
                    b.Navigation("ListAndMovies");
                });

            modelBuilder.Entity("MoviesWebApp.Entities.User", b =>
                {
                    b.Navigation("ListOfMovies");
                });
#pragma warning restore 612, 618
        }
    }
}