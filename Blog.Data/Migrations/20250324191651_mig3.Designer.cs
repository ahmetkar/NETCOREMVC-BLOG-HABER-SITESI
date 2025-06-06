﻿// <auto-generated />
using System;
using Blog.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blog.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250324191651_mig3")]
    partial class mig3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Blog.Entity.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryID");

                    b.HasIndex("ImageId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("12dd1d68-af34-46a5-ae46-7842d39aed20"),
                            CategoryID = new Guid("58252b86-ec84-4c93-b3df-e9b1bf39d3bf"),
                            Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedBy = "Admin test",
                            CreatedDate = new DateTime(2023, 5, 15, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries..",
                            ImageId = new Guid("17a74024-059f-4747-9849-1ea1613869cc"),
                            IsDeleted = false,
                            Title = "Deneme makale 1",
                            ViewCount = 1
                        },
                        new
                        {
                            Id = new Guid("7eb33293-d3fe-4abe-9924-41a64f0138d7"),
                            CategoryID = new Guid("80ac9637-35b9-42d1-afb7-297242e1e7c5"),
                            Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedBy = "Admin test",
                            CreatedDate = new DateTime(2023, 5, 15, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries..",
                            ImageId = new Guid("21c11c2f-b0dd-43f8-bf95-1d0c2940fa2d"),
                            IsDeleted = false,
                            Title = "Deneme makale 2",
                            ViewCount = 1
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("58252b86-ec84-4c93-b3df-e9b1bf39d3bf"),
                            CreatedBy = "Admin test",
                            CreatedDate = new DateTime(2023, 5, 15, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Asp.net"
                        },
                        new
                        {
                            Id = new Guid("80ac9637-35b9-42d1-afb7-297242e1e7c5"),
                            CreatedBy = "Admin test",
                            CreatedDate = new DateTime(2023, 5, 15, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Visual studio 2022"
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("21c11c2f-b0dd-43f8-bf95-1d0c2940fa2d"),
                            CreatedBy = "Admin test",
                            CreatedDate = new DateTime(2023, 5, 15, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            FileName = "images/deneme2",
                            FileType = "png",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("17a74024-059f-4747-9849-1ea1613869cc"),
                            CreatedBy = "Admin test",
                            CreatedDate = new DateTime(2023, 5, 15, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            FileName = "images/deneme",
                            FileType = "png",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.TRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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
                            Id = new Guid("0e4520f6-4144-4b4c-9724-c651046ee24a"),
                            ConcurrencyStamp = "9554cb71-9e59-4969-86af-34dc14dcef75",
                            Name = "Superadmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = new Guid("dddfbe14-bb8f-4c4f-af4e-c1be34ea9b88"),
                            ConcurrencyStamp = "b5abca43-fd2b-457c-9fec-bc194ae5703a",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("b20731ee-51ed-4849-8d24-82d4a998edda"),
                            ConcurrencyStamp = "09db0fff-933a-4e4e-afab-71236adc6855",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.TRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Blog.Entity.Entities.TUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

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
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

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
                            Id = new Guid("69bffe8d-6794-45d2-bd0f-48599928cdee"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fdede6e3-3341-460b-9a0a-d78883b32677",
                            Email = "ahmetkar2346@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Ahmet",
                            LastName = "Kar",
                            LockoutEnabled = false,
                            NormalizedEmail = "AHMETKAR2346@GMAIL.COM",
                            NormalizedUserName = "AHMETKAR",
                            PasswordHash = "AQAAAAIAAYagAAAAEPGt+RBZ9XaPAuuzJzgXM0apMOyOHNY/8uck+SOX7BpSUzHO04l2k0a6pFDgSGnxKg==",
                            PhoneNumber = "+905308152000",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "997dc395-441b-406b-a831-1d34860df38f",
                            TwoFactorEnabled = false,
                            UserName = "ahmetkar"
                        },
                        new
                        {
                            Id = new Guid("258794ef-c8f5-4ab5-8818-bcfd3218036a"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "99086243-6e88-43ee-bc41-fc3711d3df66",
                            Email = "ahmetkar2077@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Mehmet",
                            LastName = "Oz",
                            LockoutEnabled = false,
                            NormalizedEmail = "AHMETKAR2077@GMAIL.COM",
                            NormalizedUserName = "MEHMETOZ",
                            PasswordHash = "AQAAAAIAAYagAAAAECYKilLbVxaMBECEJGXW6qRIGwGGX0WJHwncCc9KruuFBt78dQ55WC2IRf9PZmNWmg==",
                            PhoneNumber = "+905308142441",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "09f4881d-95b7-42e3-9512-c573ad4efc98",
                            TwoFactorEnabled = false,
                            UserName = "mehmetoz"
                        },
                        new
                        {
                            Id = new Guid("070f54e2-bf16-4d50-bd52-a7f9cd87c479"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "61b11efd-670f-4617-9dd3-bff4455580f2",
                            Email = "farukdemir123@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Faruk",
                            LastName = "Demir",
                            LockoutEnabled = false,
                            NormalizedEmail = "FARUKDEMIR123@GMAIL.COM",
                            NormalizedUserName = "FARUKDEMIR",
                            PasswordHash = "AQAAAAIAAYagAAAAEOHUA0Yf3uqDlpG20RQe+B0lq9NpRhwwiZOVwrZbfCwmovPy7Awnu1qgw79+4UO5FA==",
                            PhoneNumber = "+905308132112",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f58b0047-f69f-41b0-95b0-a6f6fd9cf11f",
                            TwoFactorEnabled = false,
                            UserName = "farukdemir"
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.TUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Blog.Entity.Entities.TUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Blog.Entity.Entities.TUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("69bffe8d-6794-45d2-bd0f-48599928cdee"),
                            RoleId = new Guid("0e4520f6-4144-4b4c-9724-c651046ee24a")
                        },
                        new
                        {
                            UserId = new Guid("258794ef-c8f5-4ab5-8818-bcfd3218036a"),
                            RoleId = new Guid("dddfbe14-bb8f-4c4f-af4e-c1be34ea9b88")
                        },
                        new
                        {
                            UserId = new Guid("070f54e2-bf16-4d50-bd52-a7f9cd87c479"),
                            RoleId = new Guid("b20731ee-51ed-4849-8d24-82d4a998edda")
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.TUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Blog.Entity.Entities.Article", b =>
                {
                    b.HasOne("Blog.Entity.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blog.Entity.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("Blog.Entity.Entities.TRoleClaim", b =>
                {
                    b.HasOne("Blog.Entity.Entities.TRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog.Entity.Entities.TUserClaim", b =>
                {
                    b.HasOne("Blog.Entity.Entities.TUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog.Entity.Entities.TUserLogin", b =>
                {
                    b.HasOne("Blog.Entity.Entities.TUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog.Entity.Entities.TUserRole", b =>
                {
                    b.HasOne("Blog.Entity.Entities.TRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blog.Entity.Entities.TUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog.Entity.Entities.TUserToken", b =>
                {
                    b.HasOne("Blog.Entity.Entities.TUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog.Entity.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("Blog.Entity.Entities.Image", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
