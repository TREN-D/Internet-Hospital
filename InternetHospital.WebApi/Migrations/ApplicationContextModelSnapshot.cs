﻿// <auto-generated />
using System;
using InternetHospital.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InternetHospital.WebApi.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InternetHospital.DataAccess.Entities.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int>("DoctorId");

                    b.Property<DateTime>("EndTime");

                    b.Property<DateTime>("StartTime");

                    b.Property<int>("StatusId");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("InternetHospital.DataAccess.Entities.AppointmentStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("AppointmentStatuses");

                    b.HasData(
                        new { Id = 1, Description = "Appointment is created. No one signed up", Name = "Open" },
                        new { Id = 2, Description = "Patient signed up for appointment", Name = "Reserved" },
                        new { Id = 3, Description = "Doctor canceled an appointment", Name = "Canceled" },
                        new { Id = 4, Description = "Patient has been accepted", Name = "Finished" },
                        new { Id = 5, Description = "Appointment is missed by patient", Name = "Missed" }
                    );
                });

            modelBuilder.Entity("InternetHospital.DataAccess.Entities.Diploma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiplomaURL");

                    b.Property<int>("DoctorId");

                    b.Property<bool?>("IsValid");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("Diplomas");
                });

            modelBuilder.Entity("InternetHospital.DataAccess.Entities.Doctor", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("Address");

                    b.Property<string>("DoctorsInfo");

                    b.Property<bool?>("IsApproved")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("LicenseURL");

                    b.Property<int?>("SpecializationId");

                    b.HasKey("UserId");

                    b.HasIndex("SpecializationId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("InternetHospital.DataAccess.Entities.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Specializations");

                    b.HasData(
                        new { Id = 1, Description = "Conducts the diagnosis and treatment of allergic conditions.", Name = "Allergist" },
                        new { Id = 2, Description = "Treats chronic pain syndromes; administers anesthesia and monitors the patient during surgery.", Name = "Anesthesiologist" },
                        new { Id = 3, Description = "Diagnoses and treats the study of the changes in body tissues and organs which cause or are caused by disease.", Name = "Pathologist" },
                        new { Id = 4, Description = "Treats heart disease.", Name = "Cardiologist" },
                        new { Id = 5, Description = "Dealing with the endocrine system, its diseases, and its specific secretions known as hormones.", Name = "Endocrinologist" },
                        new { Id = 6, Description = "Treats stomach disorders.", Name = "Gastroenterologist" },
                        new { Id = 7, Description = "Treats skin diseases, including some skin cancers.", Name = "Dermatologist" },
                        new { Id = 8, Description = "Treats diseases of the blood and blood-forming tissues (oncology including cancer and other tumors).", Name = "Hematologist/Oncologist" },
                        new { Id = 9, Description = "Treats diseases and disorders of internal structures of the body.", Name = "Internal Medicine Physician" },
                        new { Id = 10, Description = "Treats kidney diseases.", Name = "Nephrologist" },
                        new { Id = 11, Description = "Treats diseases and disorders of the nervous system.", Name = "Neurologist" },
                        new { Id = 12, Description = "Conducts surgery of the nervous system.", Name = "Neurosurgeon" },
                        new { Id = 13, Description = "Treats women during pregnancy and childbirth.", Name = "Obstetrician" },
                        new { Id = 14, Description = "Treats diseases of the female reproductive system and genital tract.", Name = "Gynecologist" },
                        new { Id = 15, Description = "Diagnoses and treats work-related disease or injury.", Name = "Occupational Medicine Physician" },
                        new { Id = 16, Description = "Treats eye defects, injuries, and diseases.", Name = "Ophthalmologist" },
                        new { Id = 17, Description = "Surgically treats diseases, injuries, and defects of the hard and soft tissues of the face, mouth, and jaws.", Name = "Oral and Maxillofacial Surgeon" },
                        new { Id = 18, Description = "Preserves and restores the function of the musculoskeletal system.", Name = "Orthopaedic Surgeon" },
                        new { Id = 19, Description = "Treats diseases of the ear, nose, and throat,and some diseases of the head and neck, including facial plastic surgery.", Name = "Otolaryngologist" },
                        new { Id = 20, Description = "Treats infants, toddlers, children and teenagers.", Name = "Pediatrician" },
                        new { Id = 21, Description = "Restores, reconstructs, corrects or improves in the shape and appearance of damaged body structures, especially the face.", Name = "Plastic Surgeon" },
                        new { Id = 22, Description = "Provides medical and surgical treatment of the foot.", Name = "Podiatrist" },
                        new { Id = 23, Description = "Treats patients with mental and emotional disorders.", Name = "Psychiatrist" },
                        new { Id = 24, Description = "Diagnoses and treats lung disorders.", Name = "Pulmonary Medicine Physician" },
                        new { Id = 25, Description = "Treats rheumatic diseases, or conditions characterized by inflammation, soreness and stiffness of muscles, and pain in joints and associated structures.", Name = "Rheumatologist" },
                        new { Id = 26, Description = "Diagnoses and treats the male and female urinary tract and the male reproductive system.", Name = "Urologist" },
                        new { Id = 27, Description = "Branch of medicine and surgery (both methods are used) that deals with the anatomy, physiology and diseases of the eyeball and orbit.", Name = "Ophthalmologist" },
                        new { Id = 28, Description = "Is a surgeon who specializes in dentistry, the diagnosis, prevention, and treatment of diseases and conditions of the oral cavity.", Name = "Dentist" },
                        new { Id = 29, Description = "Is a subspecialty of pediatrics that consists of the medical care of newborn infants, especially the ill or premature newborn.", Name = "Neonatologist" },
                        new { Id = 30, Description = "Is a medical speciality that deals with diseases involving the respiratory tract.", Name = "Pulmonologist" },
                        new { Id = 31, Description = "Is the medical specialty that uses medical imaging to diagnose and treat diseases within the body.", Name = "Radiologist" },
                        new { Id = 32, Description = "Is a surgical specialty that focuses on abdominal contents including esophagus, stomach, small bowel, colon, liver, pancreas, gallbladder, appendix and bile ducts, and often the thyroid gland.", Name = "General Surgeon" },
                        new { Id = 33, Description = "Is a surgical subspecialty in which diseases of the vascular system, or arteries, veins and lymphatic circulation, are managed by medical therapy, minimally-invasive catheter procedures, and surgical reconstruction.", Name = "Vascular Surgeon" }
                    );
                });

            modelBuilder.Entity("InternetHospital.DataAccess.Entities.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Statuses");

                    b.HasData(
                        new { Id = 1, Description = "Banned user who has violated our rules", Name = "Banned" },
                        new { Id = 2, Description = "New user registered in our system", Name = "New" },
                        new { Id = 3, Description = "Approved user with checked data", Name = "Approved" },
                        new { Id = 4, Description = "Not approved, because user`s data was invalid", Name = "Not approved" },
                        new { Id = 5, Description = "Deleted user by Admin or Moderator", Name = "Deleted" }
                    );
                });

            modelBuilder.Entity("InternetHospital.DataAccess.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("AvatarURL");

                    b.Property<DateTime?>("BirthDate");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<DateTime>("LastStatusChangeTime");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PassportURL");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecondName");

                    b.Property<string>("SecurityStamp");

                    b.Property<DateTime>("SignUpTime");

                    b.Property<int>("StatusId");

                    b.Property<string>("ThirdName");

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

                    b.HasIndex("StatusId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("InternetHospital.DataAccess.Entities.Appointment", b =>
                {
                    b.HasOne("InternetHospital.DataAccess.Entities.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("InternetHospital.DataAccess.Entities.AppointmentStatus", "Status")
                        .WithMany("Appointments")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("InternetHospital.DataAccess.Entities.User", "User")
                        .WithMany("Appointments")
                        .HasForeignKey("UserId");
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
                    b.HasOne("InternetHospital.DataAccess.Entities.Specialization", "Specialization")
                        .WithMany("Doctors")
                        .HasForeignKey("SpecializationId");

                    b.HasOne("InternetHospital.DataAccess.Entities.User", "User")
                        .WithOne("Doctor")
                        .HasForeignKey("InternetHospital.DataAccess.Entities.Doctor", "UserId")
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
