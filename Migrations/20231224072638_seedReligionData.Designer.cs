﻿// <auto-generated />
using System;
using MatrimonyWebApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MatrimonyWebApi.Migrations
{
    [DbContext(typeof(MatrimonyDbContext))]
    [Migration("20231224072638_seedReligionData")]
    partial class seedReligionData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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
