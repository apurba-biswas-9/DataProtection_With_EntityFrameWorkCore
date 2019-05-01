﻿// <auto-generated />
using System;
using DataProtection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataProtection.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190501080815_AddDataProtectionKeys")]
    partial class AddDataProtectionKeys
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("DataProtection.DataProtectionElement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Xml");

                    b.HasKey("Id");

                    b.ToTable("DataProtectionXMLElements");
                });
#pragma warning restore 612, 618
        }
    }
}
