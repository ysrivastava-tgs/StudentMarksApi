﻿// <auto-generated />
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataLayer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210419055557_second-mig")]
    partial class secondmig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.MarksModel", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Marks")
                        .HasColumnType("int");

                    b.Property<string>("StudId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subjid")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MarksModel");
                });

            modelBuilder.Entity("Models.StudentModel", b =>
                {
                    b.Property<string>("StudId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("StudName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudId");

                    b.ToTable("StudentModel");
                });

            modelBuilder.Entity("Models.SubjectModel", b =>
                {
                    b.Property<string>("SubjId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SubjName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjId");

                    b.ToTable("SubjectModel");
                });
#pragma warning restore 612, 618
        }
    }
}
