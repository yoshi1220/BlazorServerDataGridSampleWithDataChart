﻿// <auto-generated />
using System;
using BlazorServerDataGridSampleWithDataChart.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorServerDataGridSampleWithDataChart.Migrations
{
    [DbContext(typeof(SampleDbContext))]
    [Migration("20220405135907_UserTimeStamp")]
    partial class UserTimeStamp
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorServerDataGridSampleWithDataChart.Data.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<DateTime?>("BirthDay")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("MailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            BirthDay = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MailAddress = "yamada@mai.com",
                            UserName = "山田太郎"
                        },
                        new
                        {
                            UserId = 2,
                            BirthDay = new DateTime(2009, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MailAddress = "takanashi@mail.com",
                            UserName = "小鳥遊咲"
                        },
                        new
                        {
                            UserId = 3,
                            BirthDay = new DateTime(2004, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MailAddress = "anri@mail.com",
                            UserName = "山本杏里"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
