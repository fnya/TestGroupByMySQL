﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Storage.Internal;
using System;
using TestGroupByMySQL.Models;

namespace TestGroupByMySQL.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20180616090454_mg01")]
    partial class mg01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("TestGroupByMySQL.Models.Result", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("Point");

                    b.Property<string>("Subj");

                    b.HasKey("Id");

                    b.ToTable("Result");
                });
#pragma warning restore 612, 618
        }
    }
}
