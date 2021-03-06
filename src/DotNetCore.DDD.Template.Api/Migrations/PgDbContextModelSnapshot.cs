﻿// <auto-generated />
using System;
using DotNetCore.DDD.Template.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DotNetCore.DDD.Template.Api.Migrations
{
    [DbContext(typeof(PgDbContext))]
    partial class PgDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DotNetCore.DDD.Template.Domain.TestBlobAggregation.TestBlob", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<byte[]>("Content")
                        .HasColumnType("bytea");

                    b.HasKey("Id");

                    b.ToTable("test_blob","test_platform");
                });

            modelBuilder.Entity("DotNetCore.DDD.Template.Domain.TestCaseAggregate.TestCase", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CodeContent")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(32)")
                        .HasMaxLength(32);

                    b.Property<string>("OperCode")
                        .HasColumnType("character varying(16)")
                        .HasMaxLength(16);

                    b.Property<DateTimeOffset>("OperTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<short>("Sort")
                        .HasColumnType("smallint");

                    b.Property<long>("TestCaseGroupId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("TestCaseGroupId");

                    b.ToTable("test_case","test_platform");
                });

            modelBuilder.Entity("DotNetCore.DDD.Template.Domain.TestCaseAggregate.TestCaseDetail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long?>("CallBackFormId")
                        .HasColumnType("bigint");

                    b.Property<string>("EditorName")
                        .HasColumnType("character varying(32)")
                        .HasMaxLength(32);

                    b.Property<bool>("IsCallBack")
                        .HasColumnType("boolean");

                    b.Property<string>("OperCode")
                        .HasColumnType("character varying(16)")
                        .HasMaxLength(16);

                    b.Property<DateTimeOffset>("OperTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string[]>("Params")
                        .HasColumnType("text[]")
                        .HasMaxLength(16);

                    b.Property<string>("Result")
                        .HasColumnType("text");

                    b.Property<short>("Sort")
                        .HasColumnType("smallint");

                    b.Property<long>("TestCaseId")
                        .HasColumnType("bigint");

                    b.Property<string[]>("Variables")
                        .HasColumnType("text[]")
                        .HasMaxLength(16);

                    b.HasKey("Id");

                    b.HasIndex("TestCaseId");

                    b.ToTable("test_case_detail","test_platform");
                });

            modelBuilder.Entity("DotNetCore.DDD.Template.Domain.TestCaseAggregate.TestCaseGroup", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(32)")
                        .HasMaxLength(32);

                    b.Property<string>("OperCode")
                        .HasColumnType("character varying(16)")
                        .HasMaxLength(16);

                    b.Property<DateTimeOffset>("OperTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<short>("Sort")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("test_case_group","test_platform");
                });

            modelBuilder.Entity("DotNetCore.DDD.Template.Domain.TestCaseAggregate.TestCase", b =>
                {
                    b.HasOne("DotNetCore.DDD.Template.Domain.TestCaseAggregate.TestCaseGroup", "TargetTestCaseGroup")
                        .WithMany("TestCases")
                        .HasForeignKey("TestCaseGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("DotNetCore.DDD.Template.Domain.TestCaseAggregate.TestCaseValueObject", "TestCaseValueObject", b1 =>
                        {
                            b1.Property<long>("TestCaseId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("bigint")
                                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                            b1.Property<string>("Feild1")
                                .HasColumnType("text");

                            b1.Property<bool>("Feild2")
                                .HasColumnType("boolean");

                            b1.HasKey("TestCaseId");

                            b1.ToTable("test_case");

                            b1.WithOwner()
                                .HasForeignKey("TestCaseId");
                        });
                });

            modelBuilder.Entity("DotNetCore.DDD.Template.Domain.TestCaseAggregate.TestCaseDetail", b =>
                {
                    b.HasOne("DotNetCore.DDD.Template.Domain.TestCaseAggregate.TestCase", "TargetTestCase")
                        .WithMany("TestCaseDetails")
                        .HasForeignKey("TestCaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
