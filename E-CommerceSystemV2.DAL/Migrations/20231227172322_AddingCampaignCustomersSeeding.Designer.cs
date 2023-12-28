﻿// <auto-generated />
using System;
using E_CommerceSystemV2.API;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E_CommerceSystemV2.DAL.Migrations
{
    [DbContext(typeof(ECommerceContext))]
    [Migration("20231227172322_AddingCampaignCustomersSeeding")]
    partial class AddingCampaignCustomersSeeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("E_CommerceSystemV2.DAL.Data.Models.CampaignCustomers", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CampaignCustomers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9f3d448e-9734-4d59-a780-e63ade3600e7"),
                            Email = "marwaghonem29@gmail.com",
                            Name = "Marwa"
                        },
                        new
                        {
                            Id = new Guid("349b906f-8f29-4412-a594-4796edd397bf"),
                            Email = "Jamal_Ali@outlook.com",
                            Name = "Jamal"
                        });
                });

            modelBuilder.Entity("E_CommerceSystemV2.DAL.Data.Models.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("29bfa61d-84eb-4c61-ae2e-0d5a68286042"),
                            Name = "Clothing"
                        },
                        new
                        {
                            CategoryId = new Guid("c6b3d01c-c24a-43d5-927f-10810e131c7f"),
                            Name = "Electronics"
                        },
                        new
                        {
                            CategoryId = new Guid("efe957dc-252d-49e9-b1a0-f65c3a181388"),
                            Name = "Mobiles"
                        },
                        new
                        {
                            CategoryId = new Guid("673cc6f5-7784-4cd0-ac93-fd79bb6742e2"),
                            Name = "Tablets"
                        },
                        new
                        {
                            CategoryId = new Guid("f5dbea74-8d31-4825-87c6-63bb4b4e8dc5"),
                            Name = "Fashion"
                        },
                        new
                        {
                            CategoryId = new Guid("f0ed63d2-39c5-44ff-9322-8d0817b9a050"),
                            Name = "Appliances"
                        },
                        new
                        {
                            CategoryId = new Guid("821920b1-0f52-4035-bf04-b7fb05659252"),
                            Name = "SmartDevices"
                        },
                        new
                        {
                            CategoryId = new Guid("19c1f306-3959-472e-865c-5ed14b24d2df"),
                            Name = "Gaming"
                        });
                });

            modelBuilder.Entity("E_CommerceSystemV2.DAL.Data.Models.Order", b =>
                {
                    b.Property<Guid>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = new Guid("05dfada3-f0af-4155-a517-ce80bcc0dc67"),
                            OrderDate = new DateTime(2023, 12, 27, 20, 23, 21, 638, DateTimeKind.Local).AddTicks(634),
                            UserId = "4c16ac30-078f-450c-abcb-75d434cb5e83"
                        },
                        new
                        {
                            OrderId = new Guid("687f65d7-ea8a-45ed-9ffd-44b347769eb3"),
                            OrderDate = new DateTime(2023, 12, 27, 20, 23, 21, 638, DateTimeKind.Local).AddTicks(640),
                            UserId = "7d66e6e8-9fd9-4375-bd6f-83f0e4f9e792"
                        },
                        new
                        {
                            OrderId = new Guid("8e246e43-2327-4f3b-a819-37b64716851b"),
                            OrderDate = new DateTime(2023, 12, 27, 20, 23, 21, 638, DateTimeKind.Local).AddTicks(643),
                            UserId = "4c16ac30-078f-450c-abcb-75d434cb5e83"
                        },
                        new
                        {
                            OrderId = new Guid("876a7ad1-ab14-4323-a235-48df92efd880"),
                            OrderDate = new DateTime(2023, 12, 27, 20, 23, 21, 638, DateTimeKind.Local).AddTicks(645),
                            UserId = "6caab355-b595-4915-9432-4aa53e2d3eb1"
                        },
                        new
                        {
                            OrderId = new Guid("9033cf11-fa84-44e4-9730-1ffaa7f23756"),
                            OrderDate = new DateTime(2023, 12, 27, 20, 23, 21, 638, DateTimeKind.Local).AddTicks(648),
                            UserId = "4c16ac30-078f-450c-abcb-75d434cb5e83"
                        },
                        new
                        {
                            OrderId = new Guid("23b4a2b6-927d-40cd-b2e9-31d97a298f26"),
                            OrderDate = new DateTime(2023, 12, 27, 20, 23, 21, 638, DateTimeKind.Local).AddTicks(658),
                            UserId = "74321f15-29aa-4057-ba32-e9243bc47560"
                        },
                        new
                        {
                            OrderId = new Guid("5df48ca5-d095-405e-bd2a-7ed28d98e3d5"),
                            OrderDate = new DateTime(2023, 12, 27, 20, 23, 21, 638, DateTimeKind.Local).AddTicks(663),
                            UserId = "6caab355-b595-4915-9432-4aa53e2d3eb1"
                        },
                        new
                        {
                            OrderId = new Guid("28d31885-acbd-4704-bd43-3701a7ebf62d"),
                            OrderDate = new DateTime(2023, 12, 27, 20, 23, 21, 638, DateTimeKind.Local).AddTicks(669),
                            UserId = "4c16ac30-078f-450c-abcb-75d434cb5e83"
                        });
                });

            modelBuilder.Entity("E_CommerceSystemV2.DAL.Data.Models.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CategoryType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("TagId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("OrderId");

                    b.HasIndex("TagId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("8bdc926b-53da-41b3-ad0c-ed6dc00b4c40"),
                            CategoryType = 2,
                            Name = "Samsung Galaxy S21",
                            OrderId = new Guid("05dfada3-f0af-4155-a517-ce80bcc0dc67"),
                            Price = 799.99m
                        },
                        new
                        {
                            ProductId = new Guid("96a86cbf-1d2c-4925-8b86-0bab35fd5c08"),
                            CategoryType = 1,
                            Name = "Sony Smart TV",
                            OrderId = new Guid("687f65d7-ea8a-45ed-9ffd-44b347769eb3"),
                            Price = 1299.99m
                        },
                        new
                        {
                            ProductId = new Guid("cb9f30a5-cf43-41c1-9b09-7c187a998504"),
                            CategoryType = 1,
                            Name = "Canon EOS Rebel T7",
                            OrderId = new Guid("8e246e43-2327-4f3b-a819-37b64716851b"),
                            Price = 499.99m
                        },
                        new
                        {
                            ProductId = new Guid("c0f557d9-699f-44cb-85ea-cef38a9248e8"),
                            CategoryType = 3,
                            Name = "Nike Running Shoes",
                            OrderId = new Guid("687f65d7-ea8a-45ed-9ffd-44b347769eb3"),
                            Price = 89.99m
                        },
                        new
                        {
                            ProductId = new Guid("83dd8132-2eed-45b8-bfef-604f0975b5f0"),
                            CategoryType = 4,
                            Name = "KitchenAid Stand Mixer",
                            OrderId = new Guid("876a7ad1-ab14-4323-a235-48df92efd880"),
                            Price = 349.99m
                        },
                        new
                        {
                            ProductId = new Guid("f2c1dac1-c987-4d16-815f-1142eb264212"),
                            CategoryType = 1,
                            Name = "HP Printer",
                            OrderId = new Guid("687f65d7-ea8a-45ed-9ffd-44b347769eb3"),
                            Price = 149.99m
                        },
                        new
                        {
                            ProductId = new Guid("d0f2cedb-2585-4354-b596-2b26ca68b760"),
                            CategoryType = 3,
                            Name = "Levi's Jeans",
                            OrderId = new Guid("687f65d7-ea8a-45ed-9ffd-44b347769eb3"),
                            Price = 59.99m
                        },
                        new
                        {
                            ProductId = new Guid("1afc6bc9-c4a9-468c-a091-bcf71876a16c"),
                            CategoryType = 1,
                            Name = "Bose Noise-Canceling Headphones",
                            OrderId = new Guid("687f65d7-ea8a-45ed-9ffd-44b347769eb3"),
                            Price = 299.99m
                        },
                        new
                        {
                            ProductId = new Guid("7845c623-9053-4bbc-b763-6a29ff33a43d"),
                            CategoryType = 6,
                            Name = "Fitbit Charge 5",
                            OrderId = new Guid("687f65d7-ea8a-45ed-9ffd-44b347769eb3"),
                            Price = 149.99m
                        },
                        new
                        {
                            ProductId = new Guid("cb8bb99f-29ee-40db-977a-fe6e63e49369"),
                            CategoryType = 4,
                            Name = "Cuisinart Coffee Maker",
                            OrderId = new Guid("05dfada3-f0af-4155-a517-ce80bcc0dc67"),
                            Price = 79.99m
                        },
                        new
                        {
                            ProductId = new Guid("d1638cc7-8622-453e-973d-320441808656"),
                            CategoryType = 3,
                            Name = "Adidas Running Shoes",
                            OrderId = new Guid("8e246e43-2327-4f3b-a819-37b64716851b"),
                            Price = 109.99m
                        },
                        new
                        {
                            ProductId = new Guid("0273038d-cb11-4f16-9830-1368dcd45a9d"),
                            CategoryType = 5,
                            Name = "Amazon Echo Dot",
                            OrderId = new Guid("687f65d7-ea8a-45ed-9ffd-44b347769eb3"),
                            Price = 39.99m
                        },
                        new
                        {
                            ProductId = new Guid("e5dcb228-8db8-4f5d-9337-21417896f046"),
                            CategoryType = 6,
                            Name = "Razer Gaming Mouse",
                            OrderId = new Guid("687f65d7-ea8a-45ed-9ffd-44b347769eb3"),
                            Price = 69.99m
                        },
                        new
                        {
                            ProductId = new Guid("a07bcdaf-81b6-4a85-a681-e617c2fe82a3"),
                            CategoryType = 3,
                            Name = "Calvin Klein Watch",
                            OrderId = new Guid("687f65d7-ea8a-45ed-9ffd-44b347769eb3"),
                            Price = 199.99m
                        },
                        new
                        {
                            ProductId = new Guid("74e37db8-5f17-40cd-b972-a2516192119d"),
                            CategoryType = 3,
                            Name = "Fossil Smartwatch",
                            OrderId = new Guid("05dfada3-f0af-4155-a517-ce80bcc0dc67"),
                            Price = 149.99m
                        });
                });

            modelBuilder.Entity("E_CommerceSystemV2.DAL.Data.Models.Tag", b =>
                {
                    b.Property<Guid>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagId");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            TagId = new Guid("87a7a403-675e-4d5c-81dc-06c886571428"),
                            Name = "Fashion 2024"
                        },
                        new
                        {
                            TagId = new Guid("925ee134-dbfb-4da2-9344-995e988190be"),
                            Name = "FlagShip Mobiles"
                        },
                        new
                        {
                            TagId = new Guid("bdf4dbb3-2547-44d9-8b1b-aad90df928e3"),
                            Name = "Tech"
                        });
                });

            modelBuilder.Entity("E_CommerceSystemV2.DAL.Data.Models.TagProducts", b =>
                {
                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TagId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("TagProducts");

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("96a86cbf-1d2c-4925-8b86-0bab35fd5c08"),
                            TagId = new Guid("925ee134-dbfb-4da2-9344-995e988190be")
                        },
                        new
                        {
                            ProductId = new Guid("cb9f30a5-cf43-41c1-9b09-7c187a998504"),
                            TagId = new Guid("bdf4dbb3-2547-44d9-8b1b-aad90df928e3")
                        },
                        new
                        {
                            ProductId = new Guid("c0f557d9-699f-44cb-85ea-cef38a9248e8"),
                            TagId = new Guid("bdf4dbb3-2547-44d9-8b1b-aad90df928e3")
                        },
                        new
                        {
                            ProductId = new Guid("83dd8132-2eed-45b8-bfef-604f0975b5f0"),
                            TagId = new Guid("bdf4dbb3-2547-44d9-8b1b-aad90df928e3")
                        },
                        new
                        {
                            ProductId = new Guid("f2c1dac1-c987-4d16-815f-1142eb264212"),
                            TagId = new Guid("bdf4dbb3-2547-44d9-8b1b-aad90df928e3")
                        },
                        new
                        {
                            ProductId = new Guid("d0f2cedb-2585-4354-b596-2b26ca68b760"),
                            TagId = new Guid("bdf4dbb3-2547-44d9-8b1b-aad90df928e3")
                        },
                        new
                        {
                            ProductId = new Guid("1afc6bc9-c4a9-468c-a091-bcf71876a16c"),
                            TagId = new Guid("bdf4dbb3-2547-44d9-8b1b-aad90df928e3")
                        });
                });

            modelBuilder.Entity("E_CommerceSystemV2.DAL.Data.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

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

                    b.HasData(
                        new
                        {
                            Id = "7d66e6e8-9fd9-4375-bd6f-83f0e4f9e792",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c2c4e98b-0d0e-4bb6-b0d9-3420b02a883d",
                            CreationDate = new DateTime(2023, 12, 27, 20, 23, 21, 638, DateTimeKind.Local).AddTicks(533),
                            Email = "john.doe@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "password123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ec38523c-9c27-4ce0-a6d6-a8fcf0a13773",
                            TwoFactorEnabled = false,
                            UserName = "john doe"
                        },
                        new
                        {
                            Id = "4c16ac30-078f-450c-abcb-75d434cb5e83",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2acfe452-7a6c-484b-b682-34a007df0b01",
                            CreationDate = new DateTime(2023, 12, 27, 20, 23, 21, 638, DateTimeKind.Local).AddTicks(561),
                            Email = "jane.doe@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "password123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c28e42dc-59e6-417d-bda8-25560bf5df8e",
                            TwoFactorEnabled = false,
                            UserName = "jane doe"
                        },
                        new
                        {
                            Id = "6caab355-b595-4915-9432-4aa53e2d3eb1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "38f20a04-991f-4f66-8a5d-92b0a961c1f6",
                            CreationDate = new DateTime(2023, 12, 27, 20, 23, 21, 638, DateTimeKind.Local).AddTicks(599),
                            Email = "Sara.doe@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "password123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f96c5044-afef-4719-80f4-bb724641dd74",
                            TwoFactorEnabled = false,
                            UserName = "Sara doe"
                        },
                        new
                        {
                            Id = "74321f15-29aa-4057-ba32-e9243bc47560",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "473fcff2-3fb2-41e5-9f5c-5954e8d8717d",
                            CreationDate = new DateTime(2023, 12, 27, 20, 23, 21, 638, DateTimeKind.Local).AddTicks(613),
                            Email = "Sandy.Jakson@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "password123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a88aa63a-27b0-4035-8bb8-d08ea0c8345b",
                            TwoFactorEnabled = false,
                            UserName = "Sandy Jakson"
                        });
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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("E_CommerceSystemV2.DAL.Data.Models.Order", b =>
                {
                    b.HasOne("E_CommerceSystemV2.DAL.Data.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("E_CommerceSystemV2.DAL.Data.Models.Product", b =>
                {
                    b.HasOne("E_CommerceSystemV2.DAL.Data.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("E_CommerceSystemV2.DAL.Data.Models.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("E_CommerceSystemV2.DAL.Data.Models.Tag", null)
                        .WithMany("Products")
                        .HasForeignKey("TagId");

                    b.Navigation("Category");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("E_CommerceSystemV2.DAL.Data.Models.TagProducts", b =>
                {
                    b.HasOne("E_CommerceSystemV2.DAL.Data.Models.Product", "Product")
                        .WithMany("TagProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_CommerceSystemV2.DAL.Data.Models.Tag", "Tag")
                        .WithMany("TagProducts")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Tag");
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
                    b.HasOne("E_CommerceSystemV2.DAL.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("E_CommerceSystemV2.DAL.Data.Models.User", null)
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

                    b.HasOne("E_CommerceSystemV2.DAL.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("E_CommerceSystemV2.DAL.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("E_CommerceSystemV2.DAL.Data.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("E_CommerceSystemV2.DAL.Data.Models.Order", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("E_CommerceSystemV2.DAL.Data.Models.Product", b =>
                {
                    b.Navigation("TagProducts");
                });

            modelBuilder.Entity("E_CommerceSystemV2.DAL.Data.Models.Tag", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("TagProducts");
                });

            modelBuilder.Entity("E_CommerceSystemV2.DAL.Data.Models.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
