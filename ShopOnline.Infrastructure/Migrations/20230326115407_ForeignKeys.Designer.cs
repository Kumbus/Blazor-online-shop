﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopOnline.Infrastructure.Data;

#nullable disable

namespace ShopOnline.Infrastructure.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230326115407_ForeignKeys")]
    partial class ForeignKeys
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

            modelBuilder.Entity("ShopOnline.ADomainpi.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("ProductCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6a938cd7-a277-40e9-b328-92bb5c9ab383"),
                            CategoryId = new Guid("bb89601e-1281-480f-a537-5f76b7f133ed"),
                            Description = "A kit provided by Glossier, containing skin care, hair care and makeup products",
                            ImageURL = "/Images/Beauty/Beauty1.png",
                            Name = "Glossier - Beauty Kit",
                            Price = 100m,
                            Quantity = 100
                        },
                        new
                        {
                            Id = new Guid("cd81d66c-4369-4f5d-ab72-906b5da68238"),
                            CategoryId = new Guid("bb89601e-1281-480f-a537-5f76b7f133ed"),
                            Description = "A kit provided by Curology, containing skin care products",
                            ImageURL = "/Images/Beauty/Beauty2.png",
                            Name = "Curology - Skin Care Kit",
                            Price = 50m,
                            Quantity = 45
                        },
                        new
                        {
                            Id = new Guid("c66d826c-26fe-4011-b9f6-381bde9db906"),
                            CategoryId = new Guid("bb89601e-1281-480f-a537-5f76b7f133ed"),
                            Description = "A kit provided by Curology, containing skin care products",
                            ImageURL = "/Images/Beauty/Beauty3.png",
                            Name = "Cocooil - Organic Coconut Oil",
                            Price = 20m,
                            Quantity = 30
                        },
                        new
                        {
                            Id = new Guid("aa93d2a3-c9fb-4f00-ae49-9cf50cbfa669"),
                            CategoryId = new Guid("bb89601e-1281-480f-a537-5f76b7f133ed"),
                            Description = "A kit provided by Schwarzkopf, containing skin care and hair care products",
                            ImageURL = "/Images/Beauty/Beauty4.png",
                            Name = "Schwarzkopf - Hair Care and Skin Care Kit",
                            Price = 50m,
                            Quantity = 60
                        },
                        new
                        {
                            Id = new Guid("a4f551d4-6cd7-4ba3-95ee-9e18dc248944"),
                            CategoryId = new Guid("bb89601e-1281-480f-a537-5f76b7f133ed"),
                            Description = "Skin Care Kit, containing skin care and hair care products",
                            ImageURL = "/Images/Beauty/Beauty5.png",
                            Name = "Skin Care Kit",
                            Price = 30m,
                            Quantity = 85
                        },
                        new
                        {
                            Id = new Guid("725c3357-6b3f-416d-b6bc-a56a8bab8073"),
                            CategoryId = new Guid("aba74681-d207-4312-a5dd-6e607bd95ec6"),
                            Description = "Air Pods - in-ear wireless headphones",
                            ImageURL = "/Images/Electronic/Electronics1.png",
                            Name = "Air Pods",
                            Price = 100m,
                            Quantity = 120
                        },
                        new
                        {
                            Id = new Guid("5c5f007f-eae9-4096-8719-d18c002d1d25"),
                            CategoryId = new Guid("aba74681-d207-4312-a5dd-6e607bd95ec6"),
                            Description = "On-ear Golden Headphones - these headphones are not wireless",
                            ImageURL = "/Images/Electronic/Electronics2.png",
                            Name = "On-ear Golden Headphones",
                            Price = 40m,
                            Quantity = 200
                        },
                        new
                        {
                            Id = new Guid("a7571390-c2a3-4c9a-bba7-4e3368bdff51"),
                            CategoryId = new Guid("aba74681-d207-4312-a5dd-6e607bd95ec6"),
                            Description = "On-ear Black Headphones - these headphones are not wireless",
                            ImageURL = "/Images/Electronic/Electronics3.png",
                            Name = "On-ear Black Headphones",
                            Price = 40m,
                            Quantity = 300
                        },
                        new
                        {
                            Id = new Guid("e98a8d32-0f6a-4f31-a587-0c5d15c55ceb"),
                            CategoryId = new Guid("aba74681-d207-4312-a5dd-6e607bd95ec6"),
                            Description = "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod",
                            ImageURL = "/Images/Electronic/Electronic4.png",
                            Name = "Sennheiser Digital Camera with Tripod",
                            Price = 600m,
                            Quantity = 20
                        },
                        new
                        {
                            Id = new Guid("1993d36a-7840-4625-a74e-b354d34f30e4"),
                            CategoryId = new Guid("aba74681-d207-4312-a5dd-6e607bd95ec6"),
                            Description = "Canon Digital Camera - High quality digital camera provided by Canon",
                            ImageURL = "/Images/Electronic/Electronic5.png",
                            Name = "Canon Digital Camera",
                            Price = 500m,
                            Quantity = 15
                        },
                        new
                        {
                            Id = new Guid("620e3d84-50e0-4c3d-af61-b7d67375272f"),
                            CategoryId = new Guid("aba74681-d207-4312-a5dd-6e607bd95ec6"),
                            Description = "Gameboy - Provided by Nintendo",
                            ImageURL = "/Images/Electronic/technology6.png",
                            Name = "Nintendo Gameboy",
                            Price = 100m,
                            Quantity = 60
                        },
                        new
                        {
                            Id = new Guid("2d22477b-ad4e-442e-8af4-59296621aed8"),
                            CategoryId = new Guid("720f4698-b9e2-4b3d-addf-420f6bdc8088"),
                            Description = "Very comfortable black leather office chair",
                            ImageURL = "/Images/Furniture/Furniture1.png",
                            Name = "Black Leather Office Chair",
                            Price = 50m,
                            Quantity = 212
                        },
                        new
                        {
                            Id = new Guid("719c248f-12b5-48cf-8ebc-cd224970f40f"),
                            CategoryId = new Guid("720f4698-b9e2-4b3d-addf-420f6bdc8088"),
                            Description = "Very comfortable pink leather office chair",
                            ImageURL = "/Images/Furniture/Furniture2.png",
                            Name = "Pink Leather Office Chair",
                            Price = 50m,
                            Quantity = 112
                        },
                        new
                        {
                            Id = new Guid("8e601a8b-9f92-4580-ac6d-e9dc9416ea2c"),
                            CategoryId = new Guid("720f4698-b9e2-4b3d-addf-420f6bdc8088"),
                            Description = "Very comfortable lounge chair",
                            ImageURL = "/Images/Furniture/Furniture3.png",
                            Name = "Lounge Chair",
                            Price = 70m,
                            Quantity = 90
                        },
                        new
                        {
                            Id = new Guid("5784a5a2-1704-4b1f-b2f7-e8618eaa5bca"),
                            CategoryId = new Guid("720f4698-b9e2-4b3d-addf-420f6bdc8088"),
                            Description = "Very comfortable Silver lounge chair",
                            ImageURL = "/Images/Furniture/Furniture4.png",
                            Name = "Silver Lounge Chair",
                            Price = 120m,
                            Quantity = 95
                        },
                        new
                        {
                            Id = new Guid("f57f2237-8a76-4179-ac13-13758c4c088c"),
                            CategoryId = new Guid("720f4698-b9e2-4b3d-addf-420f6bdc8088"),
                            Description = "White and blue Porcelain Table Lamp",
                            ImageURL = "/Images/Furniture/Furniture6.png",
                            Name = "Porcelain Table Lamp",
                            Price = 15m,
                            Quantity = 100
                        },
                        new
                        {
                            Id = new Guid("4ae7c9be-54e9-484f-bd6d-3bb71dabdbef"),
                            CategoryId = new Guid("720f4698-b9e2-4b3d-addf-420f6bdc8088"),
                            Description = "Office Table Lamp",
                            ImageURL = "/Images/Furniture/Furniture7.png",
                            Name = "Office Table Lamp",
                            Price = 20m,
                            Quantity = 73
                        },
                        new
                        {
                            Id = new Guid("d4e901e2-132d-4b9e-908b-7dc3108ae101"),
                            CategoryId = new Guid("ef5a969c-7c00-4e90-afee-44601d62431f"),
                            Description = "Comfortable Puma Sneakers in most sizes",
                            ImageURL = "/Images/Shoes/Shoes1.png",
                            Name = "Puma Sneakers",
                            Price = 100m,
                            Quantity = 50
                        },
                        new
                        {
                            Id = new Guid("34c65cfd-f449-4e03-b659-b1bd1bc0c185"),
                            CategoryId = new Guid("ef5a969c-7c00-4e90-afee-44601d62431f"),
                            Description = "Colorful trainsers - available in most sizes",
                            ImageURL = "/Images/Shoes/Shoes2.png",
                            Name = "Colorful Trainers",
                            Price = 150m,
                            Quantity = 60
                        },
                        new
                        {
                            Id = new Guid("555eee14-5cfa-40ba-a8da-09c633eb42d8"),
                            CategoryId = new Guid("ef5a969c-7c00-4e90-afee-44601d62431f"),
                            Description = "Blue Nike Trainers - available in most sizes",
                            ImageURL = "/Images/Shoes/Shoes3.png",
                            Name = "Blue Nike Trainers",
                            Price = 200m,
                            Quantity = 70
                        },
                        new
                        {
                            Id = new Guid("63054d6a-b714-47df-985f-dc874fb872a4"),
                            CategoryId = new Guid("ef5a969c-7c00-4e90-afee-44601d62431f"),
                            Description = "Colorful Hummel Trainers - available in most sizes",
                            ImageURL = "/Images/Shoes/Shoes4.png",
                            Name = "Colorful Hummel Trainers",
                            Price = 120m,
                            Quantity = 120
                        },
                        new
                        {
                            Id = new Guid("f8e6bc93-9aff-4857-87e1-f9bbdee8fb0c"),
                            CategoryId = new Guid("ef5a969c-7c00-4e90-afee-44601d62431f"),
                            Description = "Red Nike Trainers - available in most sizes",
                            ImageURL = "/Images/Shoes/Shoes5.png",
                            Name = "Red Nike Trainers",
                            Price = 200m,
                            Quantity = 100
                        },
                        new
                        {
                            Id = new Guid("5f3ada26-5d41-40dd-8201-cb0ab2c2a16c"),
                            CategoryId = new Guid("ef5a969c-7c00-4e90-afee-44601d62431f"),
                            Description = "Birkenstock Sandles - available in most sizes",
                            ImageURL = "/Images/Shoes/Shoes6.png",
                            Name = "Birkenstock Sandles",
                            Price = 50m,
                            Quantity = 150
                        });
                });

            modelBuilder.Entity("ShopOnline.Domain.Entities.Cart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0246a39b-d044-4b95-8fff-a336a5d534f4"),
                            UserId = new Guid("b5a069d1-f27e-4bed-9713-76e9c84bd2d6")
                        },
                        new
                        {
                            Id = new Guid("28d71a78-25eb-44e0-92dd-c4a57500c566"),
                            UserId = new Guid("ed4b8d68-5d3a-4e03-9089-df6228668b86")
                        });
                });

            modelBuilder.Entity("ShopOnline.Domain.Entities.CartItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CartId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("ShopOnline.Domain.Entities.ProductCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bb89601e-1281-480f-a537-5f76b7f133ed"),
                            Name = "Beauty"
                        },
                        new
                        {
                            Id = new Guid("720f4698-b9e2-4b3d-addf-420f6bdc8088"),
                            Name = "Furniture"
                        },
                        new
                        {
                            Id = new Guid("aba74681-d207-4312-a5dd-6e607bd95ec6"),
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = new Guid("ef5a969c-7c00-4e90-afee-44601d62431f"),
                            Name = "Shoes"
                        });
                });

            modelBuilder.Entity("ShopOnline.Domain.Entities.User", b =>
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

                    b.HasData(
                        new
                        {
                            Id = "b5a069d1-f27e-4bed-9713-76e9c84bd2d6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "717b293c-1681-4bc1-af91-c86a0f3dd64e",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "31e474b7-58a7-4297-89d6-dd2139dac87b",
                            TwoFactorEnabled = false,
                            UserName = "Bob"
                        },
                        new
                        {
                            Id = "ed4b8d68-5d3a-4e03-9089-df6228668b86",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "44b5a858-d4c2-4692-a159-136e077fa9e0",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3f16fdff-1e67-493c-a791-e30dca6ee1ee",
                            TwoFactorEnabled = false,
                            UserName = "Sarah"
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
                    b.HasOne("ShopOnline.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ShopOnline.Domain.Entities.User", null)
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

                    b.HasOne("ShopOnline.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ShopOnline.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShopOnline.ADomainpi.Entities.Product", b =>
                {
                    b.HasOne("ShopOnline.Domain.Entities.ProductCategory", null)
                        .WithMany("Products")
                        .HasForeignKey("ProductCategoryId");
                });

            modelBuilder.Entity("ShopOnline.Domain.Entities.CartItem", b =>
                {
                    b.HasOne("ShopOnline.Domain.Entities.Cart", null)
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopOnline.ADomainpi.Entities.Product", null)
                        .WithMany("CartItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShopOnline.ADomainpi.Entities.Product", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("ShopOnline.Domain.Entities.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("ShopOnline.Domain.Entities.ProductCategory", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}