﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskTranning.Models;

namespace TaskTranning.Migrations
{
    [DbContext(typeof(CodeFirstDataContext))]
    partial class CodeFirstDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TaskTranning.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName");

                    b.HasKey("Id");

                    b.ToTable("Brand");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandName = "Pro"
                        },
                        new
                        {
                            Id = 2,
                            BrandName = "XMax"
                        },
                        new
                        {
                            Id = 3,
                            BrandName = "xxx"
                        },
                        new
                        {
                            Id = 4,
                            BrandName = "S+"
                        });
                });

            modelBuilder.Entity("TaskTranning.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Iphone"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Oppo"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Samsung"
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Nokia"
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "Hawai"
                        });
                });

            modelBuilder.Entity("TaskTranning.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("Phone");

                    b.Property<string>("State");

                    b.Property<string>("Street");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Hue City",
                            Email = "customer@gmail.com",
                            FirstName = "Nguyen Van",
                            LastName = "Khanh",
                            Phone = 364606406,
                            State = "",
                            Street = "18/11 Thuy Tu",
                            ZipCode = "49000"
                        });
                });

            modelBuilder.Entity("TaskTranning.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("OrderDate");

                    b.Property<int>("OrderStatus");

                    b.Property<DateTime>("RequiredDate");

                    b.Property<DateTime>("ShippedDate");

                    b.Property<int>("StoreId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("TaskTranning.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId");

                    b.Property<int>("CategoryId");

                    b.Property<decimal>("ListPrice");

                    b.Property<int>("ModelYear");

                    b.Property<string>("Picture");

                    b.Property<string>("ProductName");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            CategoryId = 1,
                            ListPrice = 1m,
                            ModelYear = 1,
                            Picture = "logo.jpg",
                            ProductName = "Iphone 7"
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 1,
                            CategoryId = 1,
                            ListPrice = 1m,
                            ModelYear = 1,
                            Picture = "logo.jpg",
                            ProductName = "Iphone X"
                        },
                        new
                        {
                            Id = 3,
                            BrandId = 1,
                            CategoryId = 1,
                            ListPrice = 1m,
                            ModelYear = 1,
                            Picture = "logo.jpg",
                            ProductName = "Oppo S10"
                        },
                        new
                        {
                            Id = 4,
                            BrandId = 1,
                            CategoryId = 1,
                            ListPrice = 1m,
                            ModelYear = 1,
                            Picture = "logo.jpg",
                            ProductName = "Samsung S10+"
                        },
                        new
                        {
                            Id = 5,
                            BrandId = 1,
                            CategoryId = 1,
                            ListPrice = 1m,
                            ModelYear = 1,
                            Picture = "logo.jpg",
                            ProductName = "Lumia"
                        });
                });

            modelBuilder.Entity("TaskTranning.Models.Stock", b =>
                {
                    b.Property<int>("ProductId");

                    b.Property<int>("StoreId");

                    b.Property<int>("Quantity");

                    b.HasKey("ProductId", "StoreId");

                    b.HasIndex("StoreId");

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("TaskTranning.Models.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Email");

                    b.Property<int>("Phone");

                    b.Property<string>("State");

                    b.Property<string>("StoreName");

                    b.Property<string>("Street");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("Store");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Hue City",
                            Email = "khanhtmd99@gmail.com",
                            Phone = 364606406,
                            State = "",
                            StoreName = "KhanhStore",
                            Street = "18/11 Thuy Tu",
                            ZipCode = "49000"
                        },
                        new
                        {
                            Id = 2,
                            City = "Hue City",
                            Email = "Loc97@gmail.com",
                            Phone = 364606406,
                            State = "",
                            StoreName = "LocStore",
                            Street = "18/11 Thuy Tu",
                            ZipCode = "49000"
                        },
                        new
                        {
                            Id = 3,
                            City = "Hue City",
                            Email = "Huan97@gmail.com",
                            Phone = 364606406,
                            State = "",
                            StoreName = "HuanStore",
                            Street = "18/11 Thuy Tu",
                            ZipCode = "49000"
                        },
                        new
                        {
                            Id = 4,
                            City = "Hue City",
                            Email = "Tuan97@gmail.com",
                            Phone = 364606406,
                            State = "",
                            StoreName = "TuanStore",
                            Street = "18/11 Thuy Tu",
                            ZipCode = "49000"
                        });
                });

            modelBuilder.Entity("TaskTranning.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Email");

                    b.Property<string>("FullName");

                    b.Property<bool>("IsActive");

                    b.Property<string>("PassWord");

                    b.Property<int>("Phone");

                    b.Property<string>("Picture");

                    b.Property<int>("StoreId");

                    b.HasKey("Id");

                    b.HasIndex("StoreId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "18/11 Thuy Tu",
                            Email = "khanhtmd97@gmail.com",
                            FullName = "Nguyen Van Khanh",
                            IsActive = true,
                            PassWord = "10000:HhTGg7oLgnnEv9ms1t0Brh6XBaecLRHmAHn8NiV72vI6m/iv",
                            Phone = 364606406,
                            Picture = "logo.jpg",
                            StoreId = 1
                        });
                });

            modelBuilder.Entity("TaskTranning.Models.Order", b =>
                {
                    b.HasOne("TaskTranning.Models.Customer", "Customer")
                        .WithMany("Order")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TaskTranning.Models.Product", b =>
                {
                    b.HasOne("TaskTranning.Models.Brand", "Brand")
                        .WithMany("Product")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TaskTranning.Models.Category", "Category")
                        .WithMany("Product")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TaskTranning.Models.Stock", b =>
                {
                    b.HasOne("TaskTranning.Models.Product", "Product")
                        .WithMany("Stock")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TaskTranning.Models.Store", "Store")
                        .WithMany("Stock")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TaskTranning.Models.User", b =>
                {
                    b.HasOne("TaskTranning.Models.Store", "Store")
                        .WithMany("User")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
