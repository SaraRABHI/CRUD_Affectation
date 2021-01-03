﻿// <auto-generated />
using System;
using CRUD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUD.Migrations
{
    [DbContext(typeof(ProjectDBContext))]
    [Migration("20210102004145_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("CRUD.Models.Affectation", b =>
                {
                    b.Property<int>("AffectationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("consultantId")
                        .HasColumnType("int");

                    b.Property<int?>("projectId")
                        .HasColumnType("int");

                    b.HasKey("AffectationId");

                    b.HasIndex("consultantId");

                    b.HasIndex("projectId");

                    b.ToTable("Affectations");
                });

            modelBuilder.Entity("CRUD.Models.Consultant", b =>
                {
                    b.Property<int>("consultantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("consultantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("tel")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("consultantId");

                    b.ToTable("Consultants");
                });

            modelBuilder.Entity("CRUD.Models.Project", b =>
                {
                    b.Property<int>("projectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("projectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("projectId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("CRUD.Models.Affectation", b =>
                {
                    b.HasOne("CRUD.Models.Consultant", "Consultant")
                        .WithMany()
                        .HasForeignKey("consultantId");

                    b.HasOne("CRUD.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("projectId");

                    b.Navigation("Consultant");

                    b.Navigation("Project");
                });
#pragma warning restore 612, 618
        }
    }
}