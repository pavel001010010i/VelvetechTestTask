﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221111195803_init1")]
    partial class init1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.TodoItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("TodoItems");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7bf8bc46-a6ad-4ca8-b398-781639dc0214"),
                            IsComplete = false,
                            Name = "Купить хлебушек!"
                        },
                        new
                        {
                            Id = new Guid("863bed94-d1c9-4c51-bbfa-4e78a794eed8"),
                            IsComplete = true,
                            Name = "Проснутся, улыбнутся"
                        },
                        new
                        {
                            Id = new Guid("e9331a6f-aed4-4dfb-9095-c04704a1a1b2"),
                            IsComplete = true,
                            Name = "Делать проект!"
                        },
                        new
                        {
                            Id = new Guid("82d51728-d3f4-4626-9d55-69c6a1d7a1d3"),
                            IsComplete = false,
                            Name = "Позвонить на работу"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}