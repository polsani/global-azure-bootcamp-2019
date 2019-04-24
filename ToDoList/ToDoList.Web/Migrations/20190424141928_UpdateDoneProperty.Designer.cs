﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ToDoList.Web.Data;

namespace ToDoList.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190424141928_UpdateDoneProperty")]
    partial class UpdateDoneProperty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ToDoList.Web.Models.Task", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Done")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}