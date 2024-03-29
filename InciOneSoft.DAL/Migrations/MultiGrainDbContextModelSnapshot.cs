﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using InciOneSoft.DAL.DBContext;

namespace InciOneSoft.DAL.Migrations
{
    [DbContext(typeof(InciOneSoftDbContext))]
    partial class InciOneSoftDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("InciOneSoft.DAL.Entities.Catalog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PEOs")
                        .IsRequired();

                    b.Property<int>("SchoolYear");

                    b.HasKey("Id");

                    b.ToTable("Catalog");
                });

            modelBuilder.Entity("InciOneSoft.DAL.Entities.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<float>("Credits");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("InciOneSoft.DAL.Entities.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Person");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f4bff7c7-025f-4c8e-ac49-e9ec7ce94736"),
                            FirstName = "Sassine",
                            LastName = "Abou-Jaoude"
                        },
                        new
                        {
                            Id = new Guid("5b34aed3-2fba-4a32-9b1e-793b2de97f80"),
                            FirstName = "George",
                            LastName = "Younes"
                        });
                });

            modelBuilder.Entity("InciOneSoft.DAL.Entities.Programm", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Diploma")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("NumberOfCredits");

                    b.Property<int>("NumberOfSemesters");

                    b.HasKey("Id");

                    b.ToTable("Porgramm");
                });

            modelBuilder.Entity("InciOneSoft.DAL.Entities.University", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("University");

                    b.HasDiscriminator<string>("Discriminator").HasValue("University");

                    b.HasData(
                        new
                        {
                            Id = new Guid("252f1ecc-cfc5-41eb-95a3-b6d119c077f6"),
                            Address = "Beirut, Lebanon",
                            Name = "Université Saint Joseph"
                        });
                });

            modelBuilder.Entity("InciOneSoft.DAL.Entities.Department", b =>
                {
                    b.HasBaseType("InciOneSoft.DAL.Entities.University");

                    b.Property<Guid?>("InstitutionId");

                    b.HasIndex("InstitutionId");

                    b.ToTable("University");

                    b.HasDiscriminator().HasValue("Department");
                });

            modelBuilder.Entity("InciOneSoft.DAL.Entities.Faculty", b =>
                {
                    b.HasBaseType("InciOneSoft.DAL.Entities.University");

                    b.Property<Guid?>("UniversityId");

                    b.HasIndex("UniversityId");

                    b.ToTable("University");

                    b.HasDiscriminator().HasValue("Faculty");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a7fa09ae-08e4-43f0-9dba-81a7f0036014"),
                            Address = "Mar Roukoz, Lebanon",
                            Name = "Engineering",
                            UniversityId = new Guid("252f1ecc-cfc5-41eb-95a3-b6d119c077f6")
                        });
                });

            modelBuilder.Entity("InciOneSoft.DAL.Entities.Institution", b =>
                {
                    b.HasBaseType("InciOneSoft.DAL.Entities.University");

                    b.Property<int>("EvaluationType");

                    b.Property<Guid?>("FacultyId");

                    b.HasIndex("FacultyId");

                    b.ToTable("Institution");

                    b.HasDiscriminator().HasValue("Institution");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bef6892c-7859-4de4-b27a-94ee939421f4"),
                            Address = "Mar Roukoz, Lebanon",
                            Name = "ESIB",
                            EvaluationType = 0,
                            FacultyId = new Guid("a7fa09ae-08e4-43f0-9dba-81a7f0036014")
                        },
                        new
                        {
                            Id = new Guid("e34fa5fb-c76e-4914-8cf4-995d442aa83b"),
                            Address = "Mar Roukoz, Lebanon",
                            Name = "INCI",
                            EvaluationType = 0,
                            FacultyId = new Guid("a7fa09ae-08e4-43f0-9dba-81a7f0036014")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("InciOneSoft.DAL.Entities.Department", b =>
                {
                    b.HasOne("InciOneSoft.DAL.Entities.Institution", "Institution")
                        .WithMany("Departments")
                        .HasForeignKey("InstitutionId");
                });

            modelBuilder.Entity("InciOneSoft.DAL.Entities.Faculty", b =>
                {
                    b.HasOne("InciOneSoft.DAL.Entities.University", "University")
                        .WithMany("Faculties")
                        .HasForeignKey("UniversityId");
                });

            modelBuilder.Entity("InciOneSoft.DAL.Entities.Institution", b =>
                {
                    b.HasOne("InciOneSoft.DAL.Entities.Faculty", "Faculty")
                        .WithMany("Institutions")
                        .HasForeignKey("FacultyId");
                });
#pragma warning restore 612, 618
        }
    }
}
