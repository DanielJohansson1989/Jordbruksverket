﻿// <auto-generated />
using System;
using Jordbruksverket.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Jordbruksverket.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241007082252_initialcreate")]
    partial class initialcreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Jordbruksverket.Models.Owner", b =>
                {
                    b.Property<int>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OwnerId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OwnerId");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            OwnerId = 1,
                            Address = "Storgatan 31",
                            City = "Varberg",
                            Country = "Sweden",
                            FirstName = "Sixten",
                            LastName = "Svensson",
                            PhoneNumber = "1234567890",
                            PostCode = "43245"
                        });
                });

            modelBuilder.Entity("Jordbruksverket.Models.Pet", b =>
                {
                    b.Property<int>("ChipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChipId"));

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChipLoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfChip")
                        .HasColumnType("datetime2");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("PetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChipId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Pets");

                    b.HasData(
                        new
                        {
                            ChipId = 1001,
                            Breed = "Golden Retriever",
                            ChipLoc = "Left Shoulder",
                            Color = "Golden",
                            DateOfBirth = new DateTime(2019, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfChip = new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = 1,
                            PetName = "Archie",
                            Sex = "Male",
                            Species = "Dog"
                        },
                        new
                        {
                            ChipId = 1002,
                            Breed = "Siamese",
                            ChipLoc = "Right Shoulder",
                            Color = "Cream and Brown",
                            DateOfBirth = new DateTime(2018, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfChip = new DateTime(2019, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = 1,
                            PetName = "Luna",
                            Sex = "Female",
                            Species = "Cat"
                        },
                        new
                        {
                            ChipId = 1003,
                            Breed = "Beagle",
                            ChipLoc = "Neck",
                            Color = "Tricolor",
                            DateOfBirth = new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfChip = new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = 1,
                            PetName = "Charlie",
                            Sex = "Male",
                            Species = "Dog"
                        },
                        new
                        {
                            ChipId = 1004,
                            Breed = "Labrador Retriever",
                            ChipLoc = "Left Leg",
                            Color = "Black",
                            DateOfBirth = new DateTime(2017, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfChip = new DateTime(2018, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = 1,
                            PetName = "Bella",
                            Sex = "Female",
                            Species = "Dog"
                        },
                        new
                        {
                            ChipId = 1005,
                            Breed = "Maine Coon",
                            ChipLoc = "Back",
                            Color = "Gray",
                            DateOfBirth = new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfChip = new DateTime(2022, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = 1,
                            PetName = "Max",
                            Sex = "Male",
                            Species = "Cat"
                        });
                });

            modelBuilder.Entity("Jordbruksverket.Models.Pet", b =>
                {
                    b.HasOne("Jordbruksverket.Models.Owner", "Owner")
                        .WithMany("Pets")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Jordbruksverket.Models.Owner", b =>
                {
                    b.Navigation("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}
