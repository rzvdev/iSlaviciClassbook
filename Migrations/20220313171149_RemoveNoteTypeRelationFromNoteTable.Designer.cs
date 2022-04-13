﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using iSlavici.Connection.Models.db;

namespace iSlavici.Migrations
{
    [DbContext(typeof(SlaviciContext))]
    [Migration("20220313171149_RemoveNoteTypeRelationFromNoteTable")]
    partial class RemoveNoteTypeRelationFromNoteTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("iSlavici.Connection.Models.db.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int?>("ProfileId")
                        .HasColumnName("ProfileID")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnName("RoleID")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("Account");
                });

            modelBuilder.Entity("iSlavici.Connection.Models.db.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("NoteTypeId")
                        .HasColumnType("int");

                    b.Property<string>("NoteTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoteValue")
                        .HasColumnType("int");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<string>("SubjectName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Note");
                });

            modelBuilder.Entity("iSlavici.Connection.Models.db.NoteType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NoteType");
                });

            modelBuilder.Entity("iSlavici.Connection.Models.db.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("iSlavici.Connection.Models.db.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Years")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Profile");
                });

            modelBuilder.Entity("iSlavici.Connection.Models.db.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("iSlavici.Connection.Models.db.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abvr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseExaminationId")
                        .HasColumnType("int");

                    b.Property<string>("CourseExaminationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Credit")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<string>("ProfileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SemesterStudy")
                        .HasColumnType("int");

                    b.Property<int>("SubjectTypeId")
                        .HasColumnType("int");

                    b.Property<string>("SubjectTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearStudy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("iSlavici.Connection.Models.db.SubjectExamination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ExaminationName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SubjectExamination");
                });

            modelBuilder.Entity("iSlavici.Connection.Models.db.SubjectType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SubjectType");
                });

            modelBuilder.Entity("iSlavici.Connection.Models.db.Account", b =>
                {
                    b.HasOne("iSlavici.Connection.Models.db.Person", "Person")
                        .WithOne("Account")
                        .HasForeignKey("iSlavici.Connection.Models.db.Account", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("iSlavici.Connection.Models.db.Note", b =>
                {
                    b.HasOne("iSlavici.Connection.Models.db.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.HasOne("iSlavici.Connection.Models.db.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
