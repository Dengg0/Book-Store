﻿// <auto-generated />
using System;
using Assignment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220817071103_new")]
    partial class @new
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Assignment.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "United Kingdom",
                            Name = "J.K. Rowling"
                        },
                        new
                        {
                            Id = 2,
                            Country = "United States",
                            Name = "J.R.R. Tolkien"
                        },
                        new
                        {
                            Id = 3,
                            Country = "United States",
                            Name = "Stephen King"
                        },
                        new
                        {
                            Id = 4,
                            Country = "United States",
                            Name = "George R.R. Martin"
                        });
                });

            modelBuilder.Entity("Assignment.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            CategoryId = 1,
                            Image = "https://bookbuy.vn/Res/Images/Product/harry-potter-tap-8-harry-porter-and-the-cursed-child-parts-one-two-special-rehearsal-edition-script-_52322_1.jpg",
                            Price = 120.0,
                            Quantity = 30,
                            Title = "Harry Potter"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            CategoryId = 1,
                            Image = "https://images-na.ssl-images-amazon.com/images/I/71Jk3baRdnL.jpg",
                            Price = 120.0,
                            Quantity = 30,
                            Title = "Godfather"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 2,
                            CategoryId = 3,
                            Image = "http://prodimage.images-bn.com/pimages/9780345806789_p0_v2_s1200x630.jpg",
                            Price = 120.0,
                            Quantity = 30,
                            Title = "The Shining"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 3,
                            CategoryId = 4,
                            Image = "http://prodimage.images-bn.com/pimages/9780345806789_p0_v2_s1200x630.jpg",
                            Price = 120.0,
                            Quantity = 30,
                            Title = "The Stand"
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 4,
                            CategoryId = 2,
                            Image = "http://prodimage.images-bn.com/pimages/9780345806789_p0_v2_s1200x630.jpg",
                            Price = 120.0,
                            Quantity = 30,
                            Title = "The Shining"
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 1,
                            CategoryId = 3,
                            Image = "http://prodimage.images-bn.com/pimages/9780345806789_p0_v2_s1200x630.jpg",
                            Price = 120.0,
                            Quantity = 30,
                            Title = "The Shining"
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 2,
                            CategoryId = 4,
                            Image = "http://prodimage.images-bn.com/pimages/9780345806789_p0_v2_s1200x630.jpg",
                            Price = 120.0,
                            Quantity = 30,
                            Title = "The Stand"
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = 3,
                            CategoryId = 5,
                            Image = "http://prodimage.images-bn.com/pimages/9780345806789_p0_v2_s1200x630.jpg",
                            Price = 120.0,
                            Quantity = 30,
                            Title = "The Shining"
                        },
                        new
                        {
                            Id = 9,
                            AuthorId = 4,
                            CategoryId = 6,
                            Image = "http://prodimage.images-bn.com/pimages/9780345806789_p0_v2_s1200x630.jpg",
                            Price = 120.0,
                            Quantity = 30,
                            Title = "The Shining"
                        },
                        new
                        {
                            Id = 10,
                            AuthorId = 1,
                            CategoryId = 2,
                            Image = "http://prodimage.images-bn.com/pimages/9780345806789_p0_v2_s1200x630.jpg",
                            Price = 120.0,
                            Quantity = 30,
                            Title = "The Stand"
                        });
                });

            modelBuilder.Entity("Assignment.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Sci-Fi"
                        });
                });

            modelBuilder.Entity("Assignment.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("OrderPrice")
                        .HasColumnType("float");

                    b.Property<int>("OrderQuantity")
                        .HasColumnType("int");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Assignment.Models.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "3c4b30f9-3df4-4990-adfc-154ce626f4bb",
                            Name = "Admin",
                            NormalizedName = "Admin"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "9adfe82c-6c73-4035-95aa-186c5d7dc3be",
                            Name = "Customer",
                            NormalizedName = "Customer"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "153fde58-c445-4c80-9ac8-30d6a56d3368",
                            Name = "StoreOwner",
                            NormalizedName = "StoreOwner"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9258c6d5-f899-4988-bd70-9e77a53acdde",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "admin@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEDAv0OqCRRmAxYzBCmM1EQ/1QYmxZUSF57oEhhrPV10vc/hokrihkva3D+j6QeWIag==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0e8afc3b-7702-45ff-be47-c68d01708afc",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0b27771d-70c8-492d-aedd-f7aca7805f75",
                            Email = "customer@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "customer@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEIN1S2kNvhjPkdl0sYlbku7qrO6VpYhmRDOKI8KCBxQJHuOTjjRV2KGbMoq4io1jeg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e8d9fec4-71c1-4d88-8ede-101f5e5bd1c2",
                            TwoFactorEnabled = false,
                            UserName = "customer@gmail.com"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2b7e1da2-466a-40a2-983e-fa03742730d8",
                            Email = "storeowner@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "storeowner@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEKpwta6c046bljPAN37rZfrVlspdJ2Y+usP48NyEvTR6ug3z5gyfVunp2ADsCiyOwA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "937d0a60-94e5-4bc5-83b7-90c071d29e2f",
                            TwoFactorEnabled = false,
                            UserName = "storeowner@gmail.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "2",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "3",
                            RoleId = "3"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Assignment.Models.Book", b =>
                {
                    b.HasOne("Assignment.Models.Author", "Author")
                        .WithMany("Book")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Assignment.Models.Order", b =>
                {
                    b.HasOne("Assignment.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
#pragma warning restore 612, 618
        }
    }
}