﻿// <auto-generated />
using System;
using MatrimonyWebApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MatrimonyWebApi.Migrations
{
    [DbContext(typeof(MatrimonyDbContext))]
    partial class MatrimonyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MatrimonyWebApi.Models.AdminMaster", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AdminMasters");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("dd467971-80d6-43a6-a1ab-8b64cd25dedd"),
                            Password = "admin",
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("MatrimonyWebApi.Models.CasteMaster", b =>
                {
                    b.Property<Guid>("CasteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CasteName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ReligionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ReligionMasterReligionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CasteId");

                    b.HasIndex("ReligionMasterReligionId");

                    b.ToTable("CasteMasters");
                });

            modelBuilder.Entity("MatrimonyWebApi.Models.CityMaster", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"));

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.Property<int>("StateMasterStateId")
                        .HasColumnType("int");

                    b.HasKey("CityId");

                    b.HasIndex("StateMasterStateId");

                    b.ToTable("CityMasters");
                });

            modelBuilder.Entity("MatrimonyWebApi.Models.Country", b =>
                {
                    b.Property<int>("CoutnryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CoutnryId"));

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CoutnryId");

                    b.ToTable("Country");

                    b.HasData(
                        new
                        {
                            CoutnryId = 1,
                            CountryName = "India"
                        });
                });

            modelBuilder.Entity("MatrimonyWebApi.Models.Donation", b =>
                {
                    b.Property<int>("DonationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DonationId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int?>("CityMasterCityId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("DonerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DonationId");

                    b.HasIndex("CityMasterCityId");

                    b.ToTable("Donations");
                });

            modelBuilder.Entity("MatrimonyWebApi.Models.GenderMaster", b =>
                {
                    b.Property<int>("GenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenderId"));

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenderId");

                    b.ToTable("GenderMasters");

                    b.HasData(
                        new
                        {
                            GenderId = 1,
                            Gender = "Male"
                        },
                        new
                        {
                            GenderId = 2,
                            Gender = "Female"
                        },
                        new
                        {
                            GenderId = 3,
                            Gender = "Other"
                        });
                });

            modelBuilder.Entity("MatrimonyWebApi.Models.InterestStatusMaster", b =>
                {
                    b.Property<int>("InterestStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InterestStatusId"));

                    b.Property<string>("InterestStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InterestStatusId");

                    b.ToTable("InterestStatusMasters");

                    b.HasData(
                        new
                        {
                            InterestStatusId = 1,
                            InterestStatus = "Open"
                        },
                        new
                        {
                            InterestStatusId = 2,
                            InterestStatus = "Accepted"
                        },
                        new
                        {
                            InterestStatusId = 3,
                            InterestStatus = "Rejected"
                        });
                });

            modelBuilder.Entity("MatrimonyWebApi.Models.MaritialStatusMaster", b =>
                {
                    b.Property<int>("MaritialStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaritialStatusId"));

                    b.Property<string>("MaritialStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaritialStatusId");

                    b.ToTable("MaritialStatusMasters");

                    b.HasData(
                        new
                        {
                            MaritialStatusId = 1,
                            MaritialStatus = "Unmarried"
                        },
                        new
                        {
                            MaritialStatusId = 2,
                            MaritialStatus = "Widow"
                        },
                        new
                        {
                            MaritialStatusId = 3,
                            MaritialStatus = "Divorced"
                        });
                });

            modelBuilder.Entity("MatrimonyWebApi.Models.ReligionMaster", b =>
                {
                    b.Property<Guid>("ReligionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ReligionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReligionId");

                    b.ToTable("ReligionMasters");

                    b.HasData(
                        new
                        {
                            ReligionId = new Guid("08c6ab3b-97df-4959-8390-e676d35b8ceb"),
                            ReligionName = "Hindu"
                        });
                });

            modelBuilder.Entity("MatrimonyWebApi.Models.StateMaster", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StateId"));

                    b.Property<int>("CountryCoutnryId")
                        .HasColumnType("int");

                    b.Property<int>("CoutnryId")
                        .HasColumnType("int");

                    b.Property<string>("StateName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StateId");

                    b.HasIndex("CountryCoutnryId");

                    b.ToTable("StateMasters");
                });

            modelBuilder.Entity("MatrimonyWebApi.Models.CasteMaster", b =>
                {
                    b.HasOne("MatrimonyWebApi.Models.ReligionMaster", "ReligionMaster")
                        .WithMany()
                        .HasForeignKey("ReligionMasterReligionId");

                    b.Navigation("ReligionMaster");
                });

            modelBuilder.Entity("MatrimonyWebApi.Models.CityMaster", b =>
                {
                    b.HasOne("MatrimonyWebApi.Models.StateMaster", "StateMaster")
                        .WithMany()
                        .HasForeignKey("StateMasterStateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StateMaster");
                });

            modelBuilder.Entity("MatrimonyWebApi.Models.Donation", b =>
                {
                    b.HasOne("MatrimonyWebApi.Models.CityMaster", "CityMaster")
                        .WithMany()
                        .HasForeignKey("CityMasterCityId");

                    b.Navigation("CityMaster");
                });

            modelBuilder.Entity("MatrimonyWebApi.Models.StateMaster", b =>
                {
                    b.HasOne("MatrimonyWebApi.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryCoutnryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });
#pragma warning restore 612, 618
        }
    }
}
