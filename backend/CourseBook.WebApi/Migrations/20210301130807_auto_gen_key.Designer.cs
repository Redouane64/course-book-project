﻿// <auto-generated />
using System;
using CourseBook.WebApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CourseBook.WebApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210301130807_auto_gen_key")]
    partial class auto_gen_key
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("CourseBook.WebApi.Faculties.Entities.DirectionEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("FacultyId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<Guid>("faculty_id")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("faculty_id");

                    b.ToTable("directions");
                });

            modelBuilder.Entity("CourseBook.WebApi.Faculties.Entities.DisciplineEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Literatures")
                        .HasMaxLength(4096)
                        .HasColumnType("character varying(4096)");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("disciplines");
                });

            modelBuilder.Entity("CourseBook.WebApi.Faculties.Entities.FacultyEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("faculties");
                });

            modelBuilder.Entity("CourseBook.WebApi.Faculties.Entities.GroupEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("DirectionId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<Guid>("direction_id")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("direction_id");

                    b.ToTable("groups");
                });

            modelBuilder.Entity("CourseBook.WebApi.Faculties.Entities.DirectionEntity", b =>
                {
                    b.HasOne("CourseBook.WebApi.Faculties.Entities.FacultyEntity", "Faculty")
                        .WithMany("Directions")
                        .HasForeignKey("faculty_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("CourseBook.WebApi.Faculties.Entities.GroupEntity", b =>
                {
                    b.HasOne("CourseBook.WebApi.Faculties.Entities.DirectionEntity", "Direction")
                        .WithMany("Groups")
                        .HasForeignKey("direction_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Direction");
                });

            modelBuilder.Entity("CourseBook.WebApi.Faculties.Entities.DirectionEntity", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("CourseBook.WebApi.Faculties.Entities.FacultyEntity", b =>
                {
                    b.Navigation("Directions");
                });
#pragma warning restore 612, 618
        }
    }
}