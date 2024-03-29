﻿// <auto-generated />
using System;
using CarBattery_2022.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarBattery_2022.Infrastructure.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220322132327_RepairDb")]
    partial class RepairDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.Amperage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Amperages");
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.Battery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AmperageId")
                        .HasColumnType("int");

                    b.Property<int?>("BatteryCodeId")
                        .HasColumnType("int");

                    b.Property<int>("BoxTypeId")
                        .HasColumnType("int");

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("CapacityId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("HeightId")
                        .HasColumnType("int");

                    b.Property<int>("HeightPlusId")
                        .HasColumnType("int");

                    b.Property<int?>("ImageId")
                        .HasColumnType("int");

                    b.Property<int>("LengthId")
                        .HasColumnType("int");

                    b.Property<int>("PriceId")
                        .HasColumnType("int");

                    b.Property<int>("TechnologyId")
                        .HasColumnType("int");

                    b.Property<int>("TerminalsId")
                        .HasColumnType("int");

                    b.Property<int>("WeightId")
                        .HasColumnType("int");

                    b.Property<int>("WidthId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AmperageId");

                    b.HasIndex("BatteryCodeId")
                        .IsUnique()
                        .HasFilter("[BatteryCodeId] IS NOT NULL");

                    b.HasIndex("BoxTypeId");

                    b.HasIndex("BrandId");

                    b.HasIndex("CapacityId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("HeightId");

                    b.HasIndex("HeightPlusId");

                    b.HasIndex("ImageId")
                        .IsUnique()
                        .HasFilter("[ImageId] IS NOT NULL");

                    b.HasIndex("LengthId");

                    b.HasIndex("PriceId");

                    b.HasIndex("TechnologyId");

                    b.HasIndex("TerminalsId");

                    b.HasIndex("WeightId");

                    b.HasIndex("WidthId");

                    b.ToTable("Batteries");
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.BatteryCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BatteryCodeValue")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("BatteryCodes");
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.BoxType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BoxTypeCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("BoxTypes");
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.Capacity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Capacities");
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.Height", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ValueInMm")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Heights");
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.HeightPlus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ValueInMm")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("HeightsPluses");
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte[]>("ImageData")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ImageTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.Length", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ValueInMm")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Lengths");
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.Price", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("ValueInBGN")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.Technology", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Technologies");
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.Terminals", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Terminals");
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.Weight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("ValueInKg")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Weights");
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.Width", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ValueInMm")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Widths");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.Battery", b =>
                {
                    b.HasOne("CarBattery_2022.Infrastructure.Data.Models.Amperage", "Amperage")
                        .WithMany("Batteries")
                        .HasForeignKey("AmperageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarBattery_2022.Infrastructure.Data.Models.BatteryCode", "BatteryCode")
                        .WithOne("Battery")
                        .HasForeignKey("CarBattery_2022.Infrastructure.Data.Models.Battery", "BatteryCodeId");

                    b.HasOne("CarBattery_2022.Infrastructure.Data.Models.BoxType", "BoxType")
                        .WithMany("Batteries")
                        .HasForeignKey("BoxTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarBattery_2022.Infrastructure.Data.Models.Brand", "Brand")
                        .WithMany("Batteries")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarBattery_2022.Infrastructure.Data.Models.Capacity", "Capacity")
                        .WithMany("Batteries")
                        .HasForeignKey("CapacityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarBattery_2022.Infrastructure.Data.Models.Category", "Category")
                        .WithMany("Batteries")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarBattery_2022.Infrastructure.Data.Models.Height", "Height")
                        .WithMany("Batteries")
                        .HasForeignKey("HeightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarBattery_2022.Infrastructure.Data.Models.HeightPlus", "HeightPlus")
                        .WithMany("Batteries")
                        .HasForeignKey("HeightPlusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarBattery_2022.Infrastructure.Data.Models.Image", "Image")
                        .WithOne("Battery")
                        .HasForeignKey("CarBattery_2022.Infrastructure.Data.Models.Battery", "ImageId");

                    b.HasOne("CarBattery_2022.Infrastructure.Data.Models.Length", "Length")
                        .WithMany("Batteries")
                        .HasForeignKey("LengthId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarBattery_2022.Infrastructure.Data.Models.Price", "Price")
                        .WithMany("Batteries")
                        .HasForeignKey("PriceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarBattery_2022.Infrastructure.Data.Models.Technology", "Technology")
                        .WithMany("Batteries")
                        .HasForeignKey("TechnologyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarBattery_2022.Infrastructure.Data.Models.Terminals", "Terminals")
                        .WithMany("Batteries")
                        .HasForeignKey("TerminalsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarBattery_2022.Infrastructure.Data.Models.Weight", "Weight")
                        .WithMany("Batteries")
                        .HasForeignKey("WeightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarBattery_2022.Infrastructure.Data.Models.Width", "Width")
                        .WithMany("Batteries")
                        .HasForeignKey("WidthId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Amperage");

                    b.Navigation("BatteryCode");

                    b.Navigation("BoxType");

                    b.Navigation("Brand");

                    b.Navigation("Capacity");

                    b.Navigation("Category");

                    b.Navigation("Height");

                    b.Navigation("HeightPlus");

                    b.Navigation("Image");

                    b.Navigation("Length");

                    b.Navigation("Price");

                    b.Navigation("Technology");

                    b.Navigation("Terminals");

                    b.Navigation("Weight");

                    b.Navigation("Width");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.Amperage", b =>
                {
                    b.Navigation("Batteries");
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.BatteryCode", b =>
                {
                    b.Navigation("Battery")
                        .IsRequired();
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.BoxType", b =>
                {
                    b.Navigation("Batteries");
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.Brand", b =>
                {
                    b.Navigation("Batteries");
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.Capacity", b =>
                {
                    b.Navigation("Batteries");
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.Category", b =>
                {
                    b.Navigation("Batteries");
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.Height", b =>
                {
                    b.Navigation("Batteries");
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.HeightPlus", b =>
                {
                    b.Navigation("Batteries");
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.Image", b =>
                {
                    b.Navigation("Battery")
                        .IsRequired();
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.Length", b =>
                {
                    b.Navigation("Batteries");
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.Price", b =>
                {
                    b.Navigation("Batteries");
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.Technology", b =>
                {
                    b.Navigation("Batteries");
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.Terminals", b =>
                {
                    b.Navigation("Batteries");
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.Weight", b =>
                {
                    b.Navigation("Batteries");
                });

            modelBuilder.Entity("CarBattery_2022.Infrastructure.Data.Models.Width", b =>
                {
                    b.Navigation("Batteries");
                });
#pragma warning restore 612, 618
        }
    }
}
