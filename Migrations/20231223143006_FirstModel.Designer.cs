﻿// <auto-generated />
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
    [Migration("20231223143006_FirstModel")]
    partial class FirstModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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
                });
#pragma warning restore 612, 618
        }
    }
}
