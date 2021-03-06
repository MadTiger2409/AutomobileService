﻿// <auto-generated />
using AutomobileWebService.Business_Logic.Repositories.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AutomobileWebService.Migrations
{
    [DbContext(typeof(AutomobileContext))]
    partial class AutomobileContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Automobile")
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AutomobileWebService.Business_Logic.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<bool>("Deleted");

                    b.Property<DateTime?>("EndDate");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDate");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("AutomobileWebService.Business_Logic.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrandId");

                    b.Property<string>("BrandName");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<bool>("Deleted");

                    b.Property<int>("Generation");

                    b.Property<int>("Horsepower");

                    b.Property<string>("Model");

                    b.Property<DateTime>("ProdutionDate");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("AutomobileWebService.Business_Logic.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CommentText");

                    b.Property<int>("CommenterId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<bool>("Deleted");

                    b.Property<int>("ProjectId");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("CommenterId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("AutomobileWebService.Business_Logic.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompanyAddressId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("AutomobileWebService.Business_Logic.Models.CompanyAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BuildingNumber");

                    b.Property<int>("CompanyId");

                    b.Property<string>("Country");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<bool>("Deleted");

                    b.Property<int>("FlatNumber");

                    b.Property<string>("State");

                    b.Property<string>("Street");

                    b.Property<string>("Town");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("AutomobileWebService.Business_Logic.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CarId");

                    b.Property<string>("Category");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<bool>("Deleted");

                    b.Property<string>("EngineModel");

                    b.Property<bool>("HasSupercharger");

                    b.Property<bool>("HasTurbochager");

                    b.Property<int>("Horsepower");

                    b.Property<string>("ProjectName");

                    b.Property<float>("TopSpeedInKilometers");

                    b.Property<float>("TopSpeedInMiles");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("UserId");

                    b.Property<float>("ZeroToHundreds");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("UserId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("AutomobileWebService.Business_Logic.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Email");

                    b.Property<string>("HashedPassword");

                    b.Property<string>("Login");

                    b.Property<string>("MobilePhone");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AutomobileWebService.Business_Logic.Models.Car", b =>
                {
                    b.HasOne("AutomobileWebService.Business_Logic.Models.Brand", "Brand")
                        .WithMany("Cars")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("AutomobileWebService.Business_Logic.Models.Comment", b =>
                {
                    b.HasOne("AutomobileWebService.Business_Logic.Models.User", "Commenter")
                        .WithMany("Comments")
                        .HasForeignKey("CommenterId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("AutomobileWebService.Business_Logic.Models.Project", "Project")
                        .WithMany("Comments")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("AutomobileWebService.Business_Logic.Models.CompanyAddress", b =>
                {
                    b.HasOne("AutomobileWebService.Business_Logic.Models.Company", "Company")
                        .WithOne("CompanyAddress")
                        .HasForeignKey("AutomobileWebService.Business_Logic.Models.CompanyAddress", "CompanyId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("AutomobileWebService.Business_Logic.Models.Project", b =>
                {
                    b.HasOne("AutomobileWebService.Business_Logic.Models.Car", "Car")
                        .WithMany("Projects")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("AutomobileWebService.Business_Logic.Models.User", "User")
                        .WithMany("Projects")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
