﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TACalender;

#nullable disable

namespace TACalender.Migrations
{
    [DbContext(typeof(DB))]
    [Migration("20230928063821_any_valid_description")]
    partial class any_valid_description
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("TACalender.Instructor", b =>
                {
                    b.Property<int>("InstructorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EduID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumSection")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OUEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonalEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PrefName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("InstructorID");

                    b.ToTable("Instructors");
                });
#pragma warning restore 612, 618
        }
    }
}
