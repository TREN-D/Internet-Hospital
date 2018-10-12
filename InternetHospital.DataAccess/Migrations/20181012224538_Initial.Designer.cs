﻿// <auto-generated />
using System;
using InternetHospital.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace InternetHospital.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20181012224538_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("InternetHospital.DataAccess.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Region");

                    b.Property<string>("Street");

                    b.HasKey("Id");

                    b.ToTable("Addresses");

                    b.HasData(
                        new { Id = 1, City = "Rive", Country = "Ukraine", Region = "Rivne", Street = "Pushkina/11" },
                        new { Id = 2, City = "Rive", Country = "Ukraine", Region = "Rivne", Street = "Pushkina/22" },
                        new { Id = 3, City = "Rive", Country = "Ukraine", Region = "Rivne", Street = "Pushkina/33" }
                    );
                });

            modelBuilder.Entity("InternetHospital.DataAccess.Entities.Diploma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DiplomaURL");

                    b.Property<int>("DoctorId");

                    b.Property<bool>("IsValid")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("Diplomas");
                });

            modelBuilder.Entity("InternetHospital.DataAccess.Entities.Doctor", b =>
                {
                    b.Property<int>("PatientId");

                    b.Property<string>("DoctorsInfo");

                    b.Property<bool>("IsApproved")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("LicenseURL");

                    b.Property<int?>("SpecializationId");

                    b.Property<int?>("WorkingAddressId");

                    b.HasKey("PatientId");

                    b.HasIndex("SpecializationId");

                    b.HasIndex("WorkingAddressId")
                        .IsUnique();

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("InternetHospital.DataAccess.Entities.Patient", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("AvatarURL");

                    b.Property<DateTime?>("BirthDay");

                    b.Property<string>("FirstName");

                    b.Property<int?>("LivingAddressId");

                    b.Property<string>("PassportURL");

                    b.Property<string>("Phone");

                    b.Property<string>("SecondName");

                    b.Property<string>("ThirdName");

                    b.HasKey("UserId");

                    b.HasIndex("LivingAddressId")
                        .IsUnique();

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("InternetHospital.DataAccess.Entities.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ExpiresDate");

                    b.Property<bool>("Revoked");

                    b.Property<string>("Token");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Tokens");
                });

            modelBuilder.Entity("InternetHospital.DataAccess.Entities.Specialization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Specializations");

                    b.HasData(
                        new { Id = 1, Description = "Default doctors specialization", Name = "Terapevt" }
                    );
                });

            modelBuilder.Entity("InternetHospital.DataAccess.Entities.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Statuses");

                    b.HasData(
                        new { Id = 1, Description = "Banned user!", Name = "Banned" },
                        new { Id = 2, Description = "New user!", Name = "New" },
                        new { Id = 3, Description = "Approved user!", Name = "Approved" },
                        new { Id = 4, Description = "Not approved user!", Name = "Not Approved" }
                    );
                });

            modelBuilder.Entity("InternetHospital.DataAccess.Entities.User", b =>
                {
                    b.Property<int>("Id")
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

                    b.Property<int>("StatusId");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.HasIndex("StatusId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
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
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("InternetHospital.DataAccess.Entities.Diploma", b =>
                {
                    b.HasOne("InternetHospital.DataAccess.Entities.Doctor", "Doctor")
                        .WithMany("Diplomas")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("InternetHospital.DataAccess.Entities.Doctor", b =>
                {
                    b.HasOne("InternetHospital.DataAccess.Entities.Patient", "Patient")
                        .WithOne("Doctor")
                        .HasForeignKey("InternetHospital.DataAccess.Entities.Doctor", "PatientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("InternetHospital.DataAccess.Entities.Specialization", "Specialization")
                        .WithMany("Doctors")
                        .HasForeignKey("SpecializationId");

                    b.HasOne("InternetHospital.DataAccess.Entities.Address", "Address")
                        .WithOne("Doctor")
                        .HasForeignKey("InternetHospital.DataAccess.Entities.Doctor", "WorkingAddressId");
                });

            modelBuilder.Entity("InternetHospital.DataAccess.Entities.Patient", b =>
                {
                    b.HasOne("InternetHospital.DataAccess.Entities.Address", "Address")
                        .WithOne("Patient")
                        .HasForeignKey("InternetHospital.DataAccess.Entities.Patient", "LivingAddressId");

                    b.HasOne("InternetHospital.DataAccess.Entities.User", "User")
                        .WithOne("Patient")
                        .HasForeignKey("InternetHospital.DataAccess.Entities.Patient", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("InternetHospital.DataAccess.Entities.RefreshToken", b =>
                {
                    b.HasOne("InternetHospital.DataAccess.Entities.User", "User")
                        .WithMany("Tokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("InternetHospital.DataAccess.Entities.User", b =>
                {
                    b.HasOne("InternetHospital.DataAccess.Entities.Status", "Status")
                        .WithMany("Users")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("InternetHospital.DataAccess.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("InternetHospital.DataAccess.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("InternetHospital.DataAccess.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("InternetHospital.DataAccess.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
