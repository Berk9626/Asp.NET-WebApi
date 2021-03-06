﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonelWebApi.Context;

namespace PersonelWebApi.Migrations
{
    [DbContext(typeof(SirketContext))]
    [Migration("20200122121320_iki")]
    partial class iki
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PersonelWebApi.Context.SirketContext+Categories", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.HasKey("CategoryId");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("PersonelWebApi.Context.SirketContext+Customers", b =>
                {
                    b.Property<string>("CustomerId");

                    b.Property<string>("VD");

                    b.HasKey("CustomerId");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("PersonelWebApi.Context.SirketContext+Employees", b =>
                {
                    b.Property<string>("EmployeeId");

                    b.Property<long>("TRIdentity");

                    b.HasKey("EmployeeId");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("PersonelWebApi.Context.SirketContext+Products", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("ProductName");

                    b.Property<decimal>("UnitPrice");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("PersonelWebApi.Context.SirketContext+Roles", b =>
                {
                    b.Property<string>("RoleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RoleName");

                    b.HasKey("RoleId");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("PersonelWebApi.Context.SirketContext+Suppliers", b =>
                {
                    b.Property<string>("SupplierId");

                    b.Property<string>("VD");

                    b.HasKey("SupplierId");

                    b.ToTable("suppliers");
                });

            modelBuilder.Entity("PersonelWebApi.Context.SirketContext+Users", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RoleId");

                    b.Property<string>("UserName");

                    b.Property<string>("UserPassword");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("PersonelWebApi.Context.SirketContext+Customers", b =>
                {
                    b.HasOne("PersonelWebApi.Context.SirketContext+Users", "Users")
                        .WithOne("Customers")
                        .HasForeignKey("PersonelWebApi.Context.SirketContext+Customers", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PersonelWebApi.Context.SirketContext+Employees", b =>
                {
                    b.HasOne("PersonelWebApi.Context.SirketContext+Users", "Users")
                        .WithOne("Employees")
                        .HasForeignKey("PersonelWebApi.Context.SirketContext+Employees", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PersonelWebApi.Context.SirketContext+Products", b =>
                {
                    b.HasOne("PersonelWebApi.Context.SirketContext+Categories", "Categories")
                        .WithMany("Plist")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PersonelWebApi.Context.SirketContext+Suppliers", b =>
                {
                    b.HasOne("PersonelWebApi.Context.SirketContext+Users", "Users")
                        .WithOne("Suppliers")
                        .HasForeignKey("PersonelWebApi.Context.SirketContext+Suppliers", "SupplierId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PersonelWebApi.Context.SirketContext+Users", b =>
                {
                    b.HasOne("PersonelWebApi.Context.SirketContext+Roles", "Roles")
                        .WithMany("Ulist")
                        .HasForeignKey("RoleId");
                });
#pragma warning restore 612, 618
        }
    }
}
