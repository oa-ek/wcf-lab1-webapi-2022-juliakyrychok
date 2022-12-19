﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PuzzleShop.Core;

#nullable disable

namespace PuzzleShop.Core.Migrations
{
    [DbContext(typeof(PuzzleShopContext))]
    [Migration("20221217004147_Initial-Migration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

                    b.HasData(
                        new
                        {
                            Id = "df467946-d378-4b71-9fc6-e5b0d33516e6",
                            ConcurrencyStamp = "32327385-acee-42d2-be0d-82d1f2375dc6",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "a34e2b01-e71a-4251-a03c-9560f04e6ffd",
                            ConcurrencyStamp = "6832ad40-21c7-4356-8e84-727e11c7a13b",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "f25b4593-3002-48f9-abe3-f6faa39e84db",
                            ConcurrencyStamp = "ab676a92-79ef-4fb1-a1f7-0943b56cd8b0",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        });
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

                    b.HasData(
                        new
                        {
                            UserId = "b519530c-c711-4ba5-9967-100fd98fa58a",
                            RoleId = "df467946-d378-4b71-9fc6-e5b0d33516e6"
                        },
                        new
                        {
                            UserId = "b519530c-c711-4ba5-9967-100fd98fa58a",
                            RoleId = "a34e2b01-e71a-4251-a03c-9560f04e6ffd"
                        },
                        new
                        {
                            UserId = "b519530c-c711-4ba5-9967-100fd98fa58a",
                            RoleId = "f25b4593-3002-48f9-abe3-f6faa39e84db"
                        },
                        new
                        {
                            UserId = "c9b8973a-dfeb-4c94-87f0-cc20ac5c8880",
                            RoleId = "a34e2b01-e71a-4251-a03c-9560f04e6ffd"
                        },
                        new
                        {
                            UserId = "c9b8973a-dfeb-4c94-87f0-cc20ac5c8880",
                            RoleId = "f25b4593-3002-48f9-abe3-f6faa39e84db"
                        },
                        new
                        {
                            UserId = "34cc9d80-1862-4101-8a21-003a1de0be01",
                            RoleId = "f25b4593-3002-48f9-abe3-f6faa39e84db"
                        });
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

            modelBuilder.Entity("PuzzleShop.Core.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("PuzzleShop.Core.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("PuzzleShop.Core.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Count")
                        .HasColumnType("int");

                    b.Property<int?>("OrderListId")
                        .HasColumnType("int");

                    b.Property<int?>("PuzzleId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("OrderListId");

                    b.HasIndex("PuzzleId");

                    b.HasIndex("UserId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("PuzzleShop.Core.OrderList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsCompleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("OrderLists");
                });

            modelBuilder.Entity("PuzzleShop.Core.Puzzle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Articul")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<int?>("Count")
                        .HasColumnType("int");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<string>("VideoURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CountryId");

                    b.ToTable("Puzzles");
                });

            modelBuilder.Entity("PuzzleShop.Core.User", b =>
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

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

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

                    b.HasData(
                        new
                        {
                            Id = "c9b8973a-dfeb-4c94-87f0-cc20ac5c8880",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "78a4785c-0b5d-45b8-9c7c-72e24fcd6367",
                            Email = "manager@puzzleshop.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MANAGER@PUZZLESHOP.COM",
                            NormalizedUserName = "MANAGER@PUZZLESHOP.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEEtPd3dBgotWDtoAUy3azTW5Qr10KPv7rrB+7x6ZkM8f1NQIc6FH0Fh4iFc1pZyo7Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e1fcece5-8b87-4eea-877e-2656e14c7fa9",
                            TwoFactorEnabled = false,
                            UserName = "manager@puzzleshop.com"
                        },
                        new
                        {
                            Id = "34cc9d80-1862-4101-8a21-003a1de0be01",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ab652c8b-6112-47dc-8d1d-4467b55c514c",
                            Email = "customer@puzzleshop.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "CUSTOMER@PUZZLESHOP.COM",
                            NormalizedUserName = "CUSTOMER@PUZZLESHOP.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEI5GJOviYp07+xOjthCKiJ/r6jirZEo3s6YksJpX36DbSMoL8/LhK4RzV9g64V2koA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "95c963c6-98cb-4847-b0ea-0e1b10b383aa",
                            TwoFactorEnabled = false,
                            UserName = "customer@puzzleshop.com"
                        },
                        new
                        {
                            Id = "b519530c-c711-4ba5-9967-100fd98fa58a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e38107ab-6bce-4bcf-96cd-ceb5c5ad1727",
                            Email = "admin@puzzleshop.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@PUZZLESHOP.COM",
                            NormalizedUserName = "ADMIN@PUZZLESHOP.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPdolfZYXa81SDI7PUcA89XPA4qyEdQtNGxTRBvoEIoKf+dCM67N6bCTI9yv7lE+6w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f9b244a5-9040-4077-a88a-2a872e36906f",
                            TwoFactorEnabled = false,
                            UserName = "admin@puzzleshop.com"
                        });
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
                    b.HasOne("PuzzleShop.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PuzzleShop.Core.User", null)
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

                    b.HasOne("PuzzleShop.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PuzzleShop.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PuzzleShop.Core.OrderItem", b =>
                {
                    b.HasOne("PuzzleShop.Core.OrderList", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderListId");

                    b.HasOne("PuzzleShop.Core.Puzzle", "Puzzle")
                        .WithMany("OrderItems")
                        .HasForeignKey("PuzzleId");

                    b.HasOne("PuzzleShop.Core.User", "User")
                        .WithMany("OrderItems")
                        .HasForeignKey("UserId");

                    b.Navigation("Puzzle");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PuzzleShop.Core.Puzzle", b =>
                {
                    b.HasOne("PuzzleShop.Core.Brand", "Brand")
                        .WithMany("Puzzles")
                        .HasForeignKey("BrandId");

                    b.HasOne("PuzzleShop.Core.Country", "Country")
                        .WithMany("Puzzles")
                        .HasForeignKey("CountryId");

                    b.Navigation("Brand");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("PuzzleShop.Core.Brand", b =>
                {
                    b.Navigation("Puzzles");
                });

            modelBuilder.Entity("PuzzleShop.Core.Country", b =>
                {
                    b.Navigation("Puzzles");
                });

            modelBuilder.Entity("PuzzleShop.Core.OrderList", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("PuzzleShop.Core.Puzzle", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("PuzzleShop.Core.User", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}