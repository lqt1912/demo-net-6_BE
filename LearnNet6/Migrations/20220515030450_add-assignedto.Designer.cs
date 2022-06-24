﻿// <auto-generated />
using System;
using LearnNet6.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LearnNet6.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220515030450_add-assignedto")]
    partial class addassignedto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LearnNet6.Data.Entity.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longtitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("LearnNet6.Data.Entity.ApplicationRole", b =>
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
                            Id = new Guid("29d150fb-c571-465a-bb6e-3793ded06421"),
                            ConcurrencyStamp = "f8236e94-25a6-473c-81f8-432149319967",
                            Name = "Owner",
                            NormalizedName = "OWNER"
                        },
                        new
                        {
                            Id = new Guid("cbb98a27-3636-4517-95a2-ba6ab41c9791"),
                            ConcurrencyStamp = "776b7b07-e222-49b6-9973-fe8f9f93ceae",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = new Guid("ebf8e452-e611-414e-851b-c3d93ff91d9f"),
                            ConcurrencyStamp = "a0f1dced-e08e-45a8-880c-bcc4dc1b9009",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = new Guid("60e50704-3ce0-4c69-896a-2904dc1f8aa1"),
                            ConcurrencyStamp = "af71d4e7-8d50-47cc-b380-d59599945ee1",
                            Name = "Editor",
                            NormalizedName = "EDITOR"
                        },
                        new
                        {
                            Id = new Guid("72e8ad05-12f4-4112-bea3-be48a7c811de"),
                            ConcurrencyStamp = "b07bf41f-6d81-4fd8-9109-03bf44d20a2b",
                            Name = "Buyer",
                            NormalizedName = "BUYER"
                        },
                        new
                        {
                            Id = new Guid("4464cd67-2bff-4f90-85c6-9cdf076ac60f"),
                            ConcurrencyStamp = "5cbd35a9-a6c6-4a8e-bc54-57e408571a4f",
                            Name = "Business",
                            NormalizedName = "BUSINESS"
                        },
                        new
                        {
                            Id = new Guid("c5d06d85-0239-4547-bce2-94865eb831d5"),
                            ConcurrencyStamp = "f425d1c1-685e-4d46-adad-58aae5cdec33",
                            Name = "Seller",
                            NormalizedName = "SELLER"
                        },
                        new
                        {
                            Id = new Guid("174cc810-d36b-42be-af56-fed163552106"),
                            ConcurrencyStamp = "d9533613-8000-4ed2-b042-52071739c415",
                            Name = "Subscriber",
                            NormalizedName = "SUBSCRIBER"
                        });
                });

            modelBuilder.Entity("LearnNet6.Data.Entity.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<Guid?>("AddressId")
                        .HasColumnType("uniqueidentifier");

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

                    b.HasIndex("AddressId");

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
                            Id = new Guid("4cde14c3-4e01-450b-b857-e1f610e6ad69"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "793a4503-f76b-403e-b028-3c3840bdaa2a",
                            Email = "thanglequoc1912@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Lê Quốc",
                            LastName = "Thắng",
                            LockoutEnabled = true,
                            NormalizedEmail = "thanglequoc1912@gmail.com",
                            NormalizedUserName = "THANGLEQUOC1912@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAoqZuAyWwiKrsIjkHq7JSjmEEXMZHFcQ3wLHkjVMZ9xTXRwxIb7xehLGAN7xAQEcA==",
                            PhoneNumber = "091234836721",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "N2AZ7AT2TAQAB5IBSPE334HYSFJVDGV7",
                            TwoFactorEnabled = false,
                            UserName = "thanglequoc1912@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("ad1b040d-58fd-4b46-9619-88092ec2d5e3"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "aaaf5630-3dda-44d2-8bd8-1b39ca36d575",
                            Email = "duyendatthang@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Nguyễn Quốc",
                            LastName = "Trung",
                            LockoutEnabled = true,
                            NormalizedEmail = "DUYENDATTHANG@gmail.com",
                            NormalizedUserName = "DUYENDATTHANG@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAoqZuAyWwiKrsIjkHq7JSjmEEXMZHFcQ3wLHkjVMZ9xTXRwxIb7xehLGAN7xAQEcA==",
                            PhoneNumber = "093478329239",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "DNZOWEXXK7I25QGATY3UPNZPF4JGGPOD",
                            TwoFactorEnabled = false,
                            UserName = "duyendatthang@gmail.com"
                        });
                });

            modelBuilder.Entity("LearnNet6.Data.Entity.Card", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AssignedTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardAuthor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EstimateValue")
                        .HasColumnType("int");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            Id = new Guid("75da8c6c-20f1-4bf1-9e29-9d3712c0ed99"),
                            Order = 0,
                            Title = "Harmless Inside",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("918ffc5f-059d-4e1c-99c1-aa3ff950bec2"),
                            Order = 1,
                            Title = "Unacceptable Figure",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("d901d349-589f-437a-bedd-745d16239902"),
                            Order = 2,
                            Title = "Brisk Reality",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("16b68534-6a02-4aff-9a70-e1c0d4ea9312"),
                            Order = 3,
                            Title = "Overlooked Instruction",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("8363d777-06da-41d5-afd0-4f9c33050d01"),
                            Order = 4,
                            Title = "Red Bend",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("11409098-1baf-4ba9-a4e3-09c74ee22d82"),
                            Order = 1,
                            Title = "Stark Drama",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("74f37c02-1c5e-41e7-b58e-161b67d5a118"),
                            Order = 2,
                            Title = "Droopy Reception",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("d7fc4c95-2b55-4bfa-9cce-02f7e4a5c498"),
                            Order = 3,
                            Title = "Firsthand Vehicle",
                            Type = 1
                        });
                });

            modelBuilder.Entity("LearnNet6.Data.Entity.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("LearnNet6.Data.Entity.RefreshToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpiredDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("RevokedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

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

            modelBuilder.Entity("LearnNet6.Data.Entity.ApplicationUser", b =>
                {
                    b.HasOne("LearnNet6.Data.Entity.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("LearnNet6.Data.Entity.Post", b =>
                {
                    b.HasOne("LearnNet6.Data.Entity.ApplicationUser", "Author")
                        .WithMany("Posts")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("LearnNet6.Data.Entity.RefreshToken", b =>
                {
                    b.HasOne("LearnNet6.Data.Entity.ApplicationUser", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("LearnNet6.Data.Entity.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("LearnNet6.Data.Entity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("LearnNet6.Data.Entity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("LearnNet6.Data.Entity.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LearnNet6.Data.Entity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("LearnNet6.Data.Entity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LearnNet6.Data.Entity.ApplicationUser", b =>
                {
                    b.Navigation("Posts");

                    b.Navigation("RefreshTokens");
                });
#pragma warning restore 612, 618
        }
    }
}
