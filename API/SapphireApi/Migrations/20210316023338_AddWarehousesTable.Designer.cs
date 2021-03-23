﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SapphireApi.Data;

namespace SapphireApi.Migrations
{
    [DbContext(typeof(Sapphire_Context))]
    [Migration("20210316023338_AddWarehousesTable")]
    partial class AddWarehousesTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(127)
                        .HasColumnType("varchar(127)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(127)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(127)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(127)
                        .HasColumnType("varchar(127)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(127)
                        .HasColumnType("varchar(127)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(127)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(127)
                        .HasColumnType("varchar(127)");

                    b.Property<string>("RoleId")
                        .HasMaxLength(127)
                        .HasColumnType("varchar(127)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(127)
                        .HasColumnType("varchar(127)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(127)
                        .HasColumnType("varchar(127)");

                    b.Property<string>("Name")
                        .HasMaxLength(127)
                        .HasColumnType("varchar(127)");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SapphireApi.Data.Adminsitration.Locations.Cities.CityModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("countryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("createdAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("createdBy")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("varchar(127)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.Property<int>("objType")
                        .HasColumnType("int");

                    b.Property<DateTime>("updatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("updatedBy")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("varchar(127)");

                    b.HasKey("id");

                    b.HasIndex("countryId");

                    b.HasIndex("createdBy");

                    b.HasIndex("objType");

                    b.HasIndex("updatedBy");

                    b.ToTable("ADM_OCST");
                });

            modelBuilder.Entity("SapphireApi.Data.Adminsitration.Locations.Country.CountryModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("createdAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("createdBy")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("varchar(127)");

                    b.Property<string>("key")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.Property<int>("objType")
                        .HasColumnType("int");

                    b.Property<DateTime>("updatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("updatedBy")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("varchar(127)");

                    b.HasKey("id");

                    b.HasIndex("createdBy");

                    b.HasIndex("key")
                        .IsUnique();

                    b.HasIndex("name")
                        .IsUnique();

                    b.HasIndex("objType");

                    b.HasIndex("updatedBy");

                    b.ToTable("ADM_OCRY");
                });

            modelBuilder.Entity("SapphireApi.Data.Adminsitration.Setup.Objects.ObjectModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("varchar(4)");

                    b.Property<DateTime>("createdAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("createdBy")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("varchar(127)");

                    b.Property<int?>("defaultSerieId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("docPrefix")
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<int>("objType")
                        .HasColumnType("int");

                    b.Property<DateTime>("updatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("updatedBy")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("varchar(127)");

                    b.HasKey("id");

                    b.HasIndex("createdBy");

                    b.HasIndex("defaultSerieId")
                        .IsUnique();

                    b.HasIndex("objType");

                    b.HasIndex("updatedBy");

                    b.ToTable("ADM_OOBJ");
                });

            modelBuilder.Entity("SapphireApi.Data.Adminsitration.Setup.Series.SerieModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("createdAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("createdBy")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("varchar(127)");

                    b.Property<int>("firstNumber")
                        .HasColumnType("int");

                    b.Property<bool>("isClosed")
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<int?>("lastNumber")
                        .HasColumnType("int");

                    b.Property<int>("nextNumber")
                        .HasColumnType("int");

                    b.Property<int>("objType")
                        .HasColumnType("int");

                    b.Property<string>("seriesName")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)");

                    b.Property<DateTime>("updatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("updatedBy")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("varchar(127)");

                    b.HasKey("id");

                    b.HasIndex("createdBy");

                    b.HasIndex("objType");

                    b.HasIndex("updatedBy");

                    b.ToTable("ADM_ONNM");
                });

            modelBuilder.Entity("SapphireApi.Data.Adminsitration.Setup.UOM.Converter.UOMConverterModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("createdAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("createdBy")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("varchar(127)");

                    b.Property<int>("fromOneId")
                        .HasColumnType("int");

                    b.Property<int>("objType")
                        .HasColumnType("int");

                    b.Property<float>("rate")
                        .HasColumnType("float");

                    b.Property<int>("toManyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("updatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("updatedBy")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("varchar(127)");

                    b.HasKey("id");

                    b.HasIndex("createdBy");

                    b.HasIndex("fromOneId");

                    b.HasIndex("objType");

                    b.HasIndex("toManyId");

                    b.HasIndex("updatedBy");

                    b.ToTable("ADM_OUGP");
                });

            modelBuilder.Entity("SapphireApi.Data.Adminsitration.Setup.UOM.UOMModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("createdAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("createdBy")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("varchar(127)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.Property<int>("objType")
                        .HasColumnType("int");

                    b.Property<int>("uomType")
                        .HasColumnType("int");

                    b.Property<DateTime>("updatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("updatedBy")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("varchar(127)");

                    b.HasKey("id");

                    b.HasIndex("createdBy");

                    b.HasIndex("objType");

                    b.HasIndex("updatedBy");

                    b.ToTable("ADM_OUOM");
                });

            modelBuilder.Entity("SapphireApi.Data.Adminsitration.SystemInitialization.Company.CompanyModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("city")
                        .HasColumnType("text");

                    b.Property<string>("companyAddress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("companyName")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.Property<int>("countryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("createdAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("createdBy")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("varchar(127)");

                    b.Property<string>("mainCur")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)");

                    b.Property<int>("objType")
                        .HasColumnType("int");

                    b.Property<string>("phone1")
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)");

                    b.Property<string>("phone2")
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)");

                    b.Property<string>("sysCur")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)");

                    b.Property<DateTime>("updatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("updatedBy")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("varchar(127)");

                    b.Property<string>("webPage")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("zipCode")
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)");

                    b.HasKey("id");

                    b.HasIndex("countryId");

                    b.HasIndex("createdBy");

                    b.HasIndex("objType");

                    b.HasIndex("updatedBy");

                    b.ToTable("ADM_OADM");
                });

            modelBuilder.Entity("SapphireApi.Data.Identity.UserModel", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(127)
                        .HasColumnType("varchar(127)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<int?>("companyId")
                        .HasColumnType("int");

                    b.Property<string>("fullName")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)")
                        .HasColumnName("FullName");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.HasIndex("companyId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("SapphireApi.Data.Inventory.Warehouses.WarehouseModel", b =>
                {
                    b.Property<string>("whsCode")
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("cityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("createdAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("createdBy")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("varchar(127)");

                    b.Property<int>("objType")
                        .HasColumnType("int");

                    b.Property<DateTime>("updatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("updatedBy")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("varchar(127)");

                    b.Property<string>("whsName")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.HasKey("whsCode");

                    b.HasIndex("cityId");

                    b.HasIndex("createdBy");

                    b.HasIndex("objType");

                    b.HasIndex("updatedBy");

                    b.ToTable("INV_OWHS");
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
                    b.HasOne("SapphireApi.Data.Identity.UserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SapphireApi.Data.Identity.UserModel", null)
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

                    b.HasOne("SapphireApi.Data.Identity.UserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SapphireApi.Data.Identity.UserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SapphireApi.Data.Adminsitration.Locations.Cities.CityModel", b =>
                {
                    b.HasOne("SapphireApi.Data.Adminsitration.Locations.Country.CountryModel", "country")
                        .WithMany("cities")
                        .HasForeignKey("countryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SapphireApi.Data.Identity.UserModel", "creatorUsr")
                        .WithMany()
                        .HasForeignKey("createdBy")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SapphireApi.Data.Adminsitration.Setup.Objects.ObjectModel", "obj")
                        .WithMany()
                        .HasForeignKey("objType")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SapphireApi.Data.Identity.UserModel", "updaterUsr")
                        .WithMany()
                        .HasForeignKey("updatedBy")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("country");

                    b.Navigation("creatorUsr");

                    b.Navigation("obj");

                    b.Navigation("updaterUsr");
                });

            modelBuilder.Entity("SapphireApi.Data.Adminsitration.Locations.Country.CountryModel", b =>
                {
                    b.HasOne("SapphireApi.Data.Identity.UserModel", "creatorUsr")
                        .WithMany()
                        .HasForeignKey("createdBy")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SapphireApi.Data.Adminsitration.Setup.Objects.ObjectModel", "obj")
                        .WithMany()
                        .HasForeignKey("objType")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SapphireApi.Data.Identity.UserModel", "updaterUsr")
                        .WithMany()
                        .HasForeignKey("updatedBy")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("creatorUsr");

                    b.Navigation("obj");

                    b.Navigation("updaterUsr");
                });

            modelBuilder.Entity("SapphireApi.Data.Adminsitration.Setup.Objects.ObjectModel", b =>
                {
                    b.HasOne("SapphireApi.Data.Identity.UserModel", "creatorUsr")
                        .WithMany()
                        .HasForeignKey("createdBy")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SapphireApi.Data.Adminsitration.Setup.Series.SerieModel", "deafultSerie")
                        .WithOne("objects")
                        .HasForeignKey("SapphireApi.Data.Adminsitration.Setup.Objects.ObjectModel", "defaultSerieId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SapphireApi.Data.Adminsitration.Setup.Objects.ObjectModel", "obj")
                        .WithMany()
                        .HasForeignKey("objType")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SapphireApi.Data.Identity.UserModel", "updaterUsr")
                        .WithMany()
                        .HasForeignKey("updatedBy")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("creatorUsr");

                    b.Navigation("deafultSerie");

                    b.Navigation("obj");

                    b.Navigation("updaterUsr");
                });

            modelBuilder.Entity("SapphireApi.Data.Adminsitration.Setup.Series.SerieModel", b =>
                {
                    b.HasOne("SapphireApi.Data.Identity.UserModel", "creatorUsr")
                        .WithMany()
                        .HasForeignKey("createdBy")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SapphireApi.Data.Adminsitration.Setup.Objects.ObjectModel", "obj")
                        .WithMany("series")
                        .HasForeignKey("objType")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SapphireApi.Data.Identity.UserModel", "updaterUsr")
                        .WithMany()
                        .HasForeignKey("updatedBy")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("creatorUsr");

                    b.Navigation("obj");

                    b.Navigation("updaterUsr");
                });

            modelBuilder.Entity("SapphireApi.Data.Adminsitration.Setup.UOM.Converter.UOMConverterModel", b =>
                {
                    b.HasOne("SapphireApi.Data.Identity.UserModel", "creatorUsr")
                        .WithMany()
                        .HasForeignKey("createdBy")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SapphireApi.Data.Adminsitration.Setup.UOM.UOMModel", "fromOne")
                        .WithMany("uomConverter_from")
                        .HasForeignKey("fromOneId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SapphireApi.Data.Adminsitration.Setup.Objects.ObjectModel", "obj")
                        .WithMany()
                        .HasForeignKey("objType")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SapphireApi.Data.Adminsitration.Setup.UOM.UOMModel", "toMany")
                        .WithMany("uomConverter_to")
                        .HasForeignKey("toManyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SapphireApi.Data.Identity.UserModel", "updaterUsr")
                        .WithMany()
                        .HasForeignKey("updatedBy")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("creatorUsr");

                    b.Navigation("fromOne");

                    b.Navigation("obj");

                    b.Navigation("toMany");

                    b.Navigation("updaterUsr");
                });

            modelBuilder.Entity("SapphireApi.Data.Adminsitration.Setup.UOM.UOMModel", b =>
                {
                    b.HasOne("SapphireApi.Data.Identity.UserModel", "creatorUsr")
                        .WithMany()
                        .HasForeignKey("createdBy")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SapphireApi.Data.Adminsitration.Setup.Objects.ObjectModel", "obj")
                        .WithMany()
                        .HasForeignKey("objType")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SapphireApi.Data.Identity.UserModel", "updaterUsr")
                        .WithMany()
                        .HasForeignKey("updatedBy")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("creatorUsr");

                    b.Navigation("obj");

                    b.Navigation("updaterUsr");
                });

            modelBuilder.Entity("SapphireApi.Data.Adminsitration.SystemInitialization.Company.CompanyModel", b =>
                {
                    b.HasOne("SapphireApi.Data.Adminsitration.Locations.Country.CountryModel", "country")
                        .WithMany("company")
                        .HasForeignKey("countryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SapphireApi.Data.Identity.UserModel", "creatorUsr")
                        .WithMany()
                        .HasForeignKey("createdBy")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SapphireApi.Data.Adminsitration.Setup.Objects.ObjectModel", "obj")
                        .WithMany()
                        .HasForeignKey("objType")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SapphireApi.Data.Identity.UserModel", "updaterUsr")
                        .WithMany()
                        .HasForeignKey("updatedBy")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("country");

                    b.Navigation("creatorUsr");

                    b.Navigation("obj");

                    b.Navigation("updaterUsr");
                });

            modelBuilder.Entity("SapphireApi.Data.Identity.UserModel", b =>
                {
                    b.HasOne("SapphireApi.Data.Adminsitration.SystemInitialization.Company.CompanyModel", "company")
                        .WithMany("users")
                        .HasForeignKey("companyId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("company");
                });

            modelBuilder.Entity("SapphireApi.Data.Inventory.Warehouses.WarehouseModel", b =>
                {
                    b.HasOne("SapphireApi.Data.Adminsitration.Locations.Cities.CityModel", "city")
                        .WithMany("warehouses")
                        .HasForeignKey("cityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SapphireApi.Data.Identity.UserModel", "creatorUsr")
                        .WithMany()
                        .HasForeignKey("createdBy")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SapphireApi.Data.Adminsitration.Setup.Objects.ObjectModel", "obj")
                        .WithMany()
                        .HasForeignKey("objType")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SapphireApi.Data.Identity.UserModel", "updaterUsr")
                        .WithMany()
                        .HasForeignKey("updatedBy")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("city");

                    b.Navigation("creatorUsr");

                    b.Navigation("obj");

                    b.Navigation("updaterUsr");
                });

            modelBuilder.Entity("SapphireApi.Data.Adminsitration.Locations.Cities.CityModel", b =>
                {
                    b.Navigation("warehouses");
                });

            modelBuilder.Entity("SapphireApi.Data.Adminsitration.Locations.Country.CountryModel", b =>
                {
                    b.Navigation("cities");

                    b.Navigation("company");
                });

            modelBuilder.Entity("SapphireApi.Data.Adminsitration.Setup.Objects.ObjectModel", b =>
                {
                    b.Navigation("series");
                });

            modelBuilder.Entity("SapphireApi.Data.Adminsitration.Setup.Series.SerieModel", b =>
                {
                    b.Navigation("objects");
                });

            modelBuilder.Entity("SapphireApi.Data.Adminsitration.Setup.UOM.UOMModel", b =>
                {
                    b.Navigation("uomConverter_from");

                    b.Navigation("uomConverter_to");
                });

            modelBuilder.Entity("SapphireApi.Data.Adminsitration.SystemInitialization.Company.CompanyModel", b =>
                {
                    b.Navigation("users");
                });
#pragma warning restore 612, 618
        }
    }
}
