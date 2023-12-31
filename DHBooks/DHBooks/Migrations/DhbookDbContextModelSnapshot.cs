﻿// <auto-generated />
using System;
using DHBooks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DHBooks.Migrations
{
    [DbContext(typeof(DhbookDbContext))]
    partial class DhbookDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DHBooks.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("BookId")
                        .HasName("PK__Books__3DE0C2078C840D4C");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("DHBooks.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryId")
                        .HasName("PK__Categori__19093A0B04186839");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DHBooks.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId")
                        .HasName("PK__Orders__C3905BCF449DD778");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DHBooks.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId")
                        .HasName("PK__OrderIte__57ED0681B4464CA2");

                    b.HasIndex("BookId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("DHBooks.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RoleId")
                        .HasName("PK__Roles__8AFACE1A94701414");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("DHBooks.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId")
                        .HasName("PK__Users__1788CC4CC3A5F8BF");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DHBooks.Models.UserRole", b =>
                {
                    b.Property<int>("UserRoleId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserRoleId")
                        .HasName("PK__UserRole__3D978A359537C04F");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("DHBooks.Models.Book", b =>
                {
                    b.HasOne("DHBooks.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .IsRequired()
                        .HasConstraintName("FK__Books__CategoryI__4316F928");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("DHBooks.Models.Order", b =>
                {
                    b.HasOne("DHBooks.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__Orders__UserId__45F365D3");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DHBooks.Models.OrderItem", b =>
                {
                    b.HasOne("DHBooks.Models.Book", "Book")
                        .WithMany("OrderItems")
                        .HasForeignKey("BookId")
                        .IsRequired()
                        .HasConstraintName("FK__OrderItem__BookI__49C3F6B7");

                    b.HasOne("DHBooks.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .IsRequired()
                        .HasConstraintName("FK__OrderItem__Order__48CFD27E");

                    b.Navigation("Book");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("DHBooks.Models.UserRole", b =>
                {
                    b.HasOne("DHBooks.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .IsRequired()
                        .HasConstraintName("FK__UserRoles__RoleI__3E52440B");

                    b.HasOne("DHBooks.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__UserRoles__UserI__3D5E1FD2");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DHBooks.Models.Book", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("DHBooks.Models.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("DHBooks.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("DHBooks.Models.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("DHBooks.Models.User", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
