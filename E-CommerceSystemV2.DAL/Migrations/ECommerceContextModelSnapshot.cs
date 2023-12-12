﻿// <auto-generated />
using System;
using E_CommerceSystemV2.API;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E_CommerceSystemV2.DAL.Migrations
{
    [DbContext(typeof(ECommerceContext))]
    partial class ECommerceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("E_CommerceSystemV2.DAL.Data.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Electronics"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Clothing"
                        });
                });

            modelBuilder.Entity("E_CommerceSystemV2.DAL.Data.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            OrderDate = new DateTime(2023, 12, 12, 16, 18, 53, 576, DateTimeKind.Local).AddTicks(1509)
                        },
                        new
                        {
                            OrderId = 2,
                            OrderDate = new DateTime(2023, 12, 12, 16, 18, 53, 576, DateTimeKind.Local).AddTicks(1512)
                        });
                });

            modelBuilder.Entity("E_CommerceSystemV2.DAL.Data.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Name = "Laptop",
                            Price = 999.99m
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Name = "Smartphone",
                            Price = 599.99m
                        });
                });

            modelBuilder.Entity("E_CommerceSystemV2.DAL.Data.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagId"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagId");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            TagId = 1,
                            Name = "Electronics"
                        },
                        new
                        {
                            TagId = 2,
                            Name = "Clothing"
                        });
                });

            modelBuilder.Entity("E_CommerceSystemV2.DAL.Data.Models.TagProducts", b =>
                {
                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("TagId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("TagProducts");

                    b.HasData(
                        new
                        {
                            TagId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            TagId = 2,
                            ProductId = 2
                        });
                });

            modelBuilder.Entity("E_CommerceSystemV2.DAL.Data.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("E_mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHashSet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            CreationDate = new DateTime(2023, 12, 12, 16, 18, 53, 576, DateTimeKind.Local).AddTicks(1494),
                            E_mail = "john.doe@example.com",
                            PasswordHashSet = "password123"
                        },
                        new
                        {
                            UserId = 2,
                            CreationDate = new DateTime(2023, 12, 12, 16, 18, 53, 576, DateTimeKind.Local).AddTicks(1502),
                            E_mail = "jane.doe@example.com",
                            PasswordHashSet = "password123"
                        },
                        new
                        {
                            UserId = 3,
                            CreationDate = new DateTime(2023, 12, 12, 16, 18, 53, 576, DateTimeKind.Local).AddTicks(1504),
                            E_mail = "Sara.doe@example.com",
                            PasswordHashSet = "password123"
                        },
                        new
                        {
                            UserId = 4,
                            CreationDate = new DateTime(2023, 12, 12, 16, 18, 53, 576, DateTimeKind.Local).AddTicks(1506),
                            E_mail = "Sandy.Jakson@example.com",
                            PasswordHashSet = "password123"
                        });
                });

            modelBuilder.Entity("E_CommerceSystemV2.DAL.Data.Models.UserOrders", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("UserOrders");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            OrderId = 1
                        },
                        new
                        {
                            UserId = 2,
                            OrderId = 2
                        });
                });

            modelBuilder.Entity("ProductTag", b =>
                {
                    b.Property<int>("ProductsProductId")
                        .HasColumnType("int");

                    b.Property<int>("TagsTagId")
                        .HasColumnType("int");

                    b.HasKey("ProductsProductId", "TagsTagId");

                    b.HasIndex("TagsTagId");

                    b.ToTable("ProductTag");
                });

            modelBuilder.Entity("E_CommerceSystemV2.DAL.Data.Models.Product", b =>
                {
                    b.HasOne("E_CommerceSystemV2.DAL.Data.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("E_CommerceSystemV2.DAL.Data.Models.TagProducts", b =>
                {
                    b.HasOne("E_CommerceSystemV2.DAL.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_CommerceSystemV2.DAL.Data.Models.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("E_CommerceSystemV2.DAL.Data.Models.UserOrders", b =>
                {
                    b.HasOne("E_CommerceSystemV2.DAL.Data.Models.Order", "Order")
                        .WithMany("UserOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("E_CommerceSystemV2.DAL.Data.Models.User", "User")
                        .WithMany("UserOrders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProductTag", b =>
                {
                    b.HasOne("E_CommerceSystemV2.DAL.Data.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_CommerceSystemV2.DAL.Data.Models.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsTagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("E_CommerceSystemV2.DAL.Data.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("E_CommerceSystemV2.DAL.Data.Models.Order", b =>
                {
                    b.Navigation("UserOrders");
                });

            modelBuilder.Entity("E_CommerceSystemV2.DAL.Data.Models.User", b =>
                {
                    b.Navigation("UserOrders");
                });
#pragma warning restore 612, 618
        }
    }
}
