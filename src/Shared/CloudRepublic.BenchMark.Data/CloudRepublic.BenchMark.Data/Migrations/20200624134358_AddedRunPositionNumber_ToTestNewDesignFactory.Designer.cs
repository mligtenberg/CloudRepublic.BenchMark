﻿// <auto-generated />
using System;
using CloudRepublic.BenchMark.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CloudRepublic.BenchMark.Data.Migrations
{
    [DbContext(typeof(BenchMarkDbContext))]
    [Migration("20200624134358_AddedRunPositionNumber_ToTestNewDesignFactory")]
    partial class AddedRunPositionNumber_ToTestNewDesignFactory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CloudRepublic.BenchMark.Domain.Entities.BenchMarkResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CallPositionNumber")
                        .HasColumnType("int");

                    b.Property<int>("CloudProvider")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("FunctionVersion")
                        .HasColumnType("int");

                    b.Property<int>("HostingEnvironment")
                        .HasColumnType("int");

                    b.Property<bool>("IsColdRequest")
                        .HasColumnType("bit");

                    b.Property<int>("RequestDuration")
                        .HasColumnType("int");

                    b.Property<int>("Runtime")
                        .HasColumnType("int");

                    b.Property<bool>("Success")
                        .HasColumnType("bit");

                    b.HasKey("Id")
                        .HasName("BenchMarkResults_pk");

                    b.HasIndex("CreatedAt")
                        .HasName("BenchMarkResults__CreatedAt_index");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("BenchMarkResults_Id_uindex");

                    b.ToTable("BenchMarkResult");
                });
#pragma warning restore 612, 618
        }
    }
}
