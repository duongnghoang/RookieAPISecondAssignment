﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonAPI.Persistence.Data;

#nullable disable

namespace PersonAPI.Persistence.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250408082445_Fix_Gender_Length")]
    partial class Fix_Gender_Length
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PersonAPI.Domain.Entities.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BirthPlace")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a1b2c3d4-e5f6-7890-abcd-ef1234567890"),
                            BirthPlace = "New York",
                            DateOfBirth = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "John",
                            Gender = "Male",
                            LastName = "Doe"
                        },
                        new
                        {
                            Id = new Guid("b2c3d4e5-f678-9012-bcde-f12345678901"),
                            BirthPlace = "Los Angeles",
                            DateOfBirth = new DateTime(1992, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jane",
                            Gender = "Female",
                            LastName = "Doe"
                        },
                        new
                        {
                            Id = new Guid("c3d4e5f6-7890-1234-cdef-123456789012"),
                            BirthPlace = "Chicago",
                            DateOfBirth = new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Alice",
                            Gender = "Female",
                            LastName = "Smith"
                        },
                        new
                        {
                            Id = new Guid("d4e5f678-9012-3456-def1-234567890123"),
                            BirthPlace = "Houston",
                            DateOfBirth = new DateTime(1978, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Bob",
                            Gender = "Male",
                            LastName = "Johnson"
                        },
                        new
                        {
                            Id = new Guid("e5f67890-1234-5678-ef12-345678901234"),
                            BirthPlace = "Seattle",
                            DateOfBirth = new DateTime(1995, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Emma",
                            Gender = "Female",
                            LastName = "Brown"
                        },
                        new
                        {
                            Id = new Guid("f6789012-3456-7890-f123-456789012345"),
                            BirthPlace = "Boston",
                            DateOfBirth = new DateTime(1988, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Michael",
                            Gender = "Other",
                            LastName = "Lee"
                        },
                        new
                        {
                            Id = new Guid("78901234-5678-9012-3456-567890123456"),
                            BirthPlace = "Miami",
                            DateOfBirth = new DateTime(1993, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Anthony",
                            Gender = "Male",
                            LastName = "Davis"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
