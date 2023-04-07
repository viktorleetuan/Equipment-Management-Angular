﻿// <auto-generated />
using System;
using ApiEquipment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiEquipment.Migrations
{
    [DbContext(typeof(NewDBContext))]
    [Migration("20230327014521_V")]
    partial class V
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApiEquipment.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("AvatarUrl")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsBan")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RefreshTokenExpiryTime")
                        .HasColumnType("datetime2");

                    b.HasKey("EmployeeId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            Birthdate = new DateTime(2001, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@gmail.com",
                            IsBan = false,
                            Name = "Hà Chánh Nam",
                            Password = "21232F297A57A5A743894A0E4A801FC3"
                        },
                        new
                        {
                            EmployeeId = 2,
                            Birthdate = new DateTime(2001, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "hahaha@gmail.com",
                            IsBan = false,
                            Name = "Ha Ha Ha",
                            Password = "AB56B4D92B40713ACC5AF89985D4B786"
                        },
                        new
                        {
                            EmployeeId = 3,
                            Birthdate = new DateTime(2001, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "namnamnam@gmail.com",
                            IsBan = false,
                            Name = "Nam Nam Nam",
                            Password = "AB56B4D92B40713ACC5AF89985D4B786"
                        },
                        new
                        {
                            EmployeeId = 4,
                            Birthdate = new DateTime(2001, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "namchanhha1@gmail.com",
                            IsBan = false,
                            Name = "Nam Chanh Ha",
                            Password = "AB56B4D92B40713ACC5AF89985D4B786"
                        });
                });

            modelBuilder.Entity("ApiEquipment.Entities.EmployeeRole", b =>
                {
                    b.Property<int>("EmployeeRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeRoleId"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeRoleId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("RoleId");

                    b.ToTable("EmployeeRoles");

                    b.HasData(
                        new
                        {
                            EmployeeRoleId = 1,
                            EmployeeId = 1,
                            RoleId = 1
                        },
                        new
                        {
                            EmployeeRoleId = 2,
                            EmployeeId = 1,
                            RoleId = 2
                        },
                        new
                        {
                            EmployeeRoleId = 3,
                            EmployeeId = 2,
                            RoleId = 1
                        },
                        new
                        {
                            EmployeeRoleId = 4,
                            EmployeeId = 3,
                            RoleId = 1
                        },
                        new
                        {
                            EmployeeRoleId = 5,
                            EmployeeId = 4,
                            RoleId = 2
                        });
                });

            modelBuilder.Entity("ApiEquipment.Entities.Equipment", b =>
                {
                    b.Property<int>("EquipmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EquipmentId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("EquipmentTypeId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("EquipmentId");

                    b.HasIndex("EquipmentTypeId");

                    b.ToTable("Equipments");

                    b.HasData(
                        new
                        {
                            EquipmentId = 1,
                            Description = "PC mới nhất hãng Asus",
                            EquipmentTypeId = 1,
                            IsAvailable = true,
                            Name = "XAZCD"
                        },
                        new
                        {
                            EquipmentId = 2,
                            Description = "Laptop mới nhất hãng HP",
                            EquipmentTypeId = 2,
                            IsAvailable = false,
                            Name = "HPNEWXZ"
                        },
                        new
                        {
                            EquipmentId = 3,
                            Description = "Laptop mới nhất hãng MSI",
                            EquipmentTypeId = 2,
                            IsAvailable = true,
                            Name = "MSIQAX"
                        },
                        new
                        {
                            EquipmentId = 4,
                            Description = "PC mới nhất hãng MSI",
                            EquipmentTypeId = 1,
                            IsAvailable = true,
                            Name = "MSIQAX"
                        },
                        new
                        {
                            EquipmentId = 5,
                            Description = "PC mới nhất hãng MSI",
                            EquipmentTypeId = 1,
                            IsAvailable = true,
                            Name = "MSIQAX"
                        });
                });

            modelBuilder.Entity("ApiEquipment.Entities.EquipmentHistory", b =>
                {
                    b.Property<int>("EquipmentHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EquipmentHistoryId"));

                    b.Property<DateTime>("BorrowedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAproved")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ReturnedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("EquipmentHistoryId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("EquipmentId");

                    b.ToTable("EquipmentHistories");

                    b.HasData(
                        new
                        {
                            EquipmentHistoryId = 1,
                            BorrowedDate = new DateTime(2023, 3, 27, 1, 45, 21, 316, DateTimeKind.Utc).AddTicks(8927),
                            EmployeeId = 1,
                            EquipmentId = 1,
                            IsAproved = false
                        },
                        new
                        {
                            EquipmentHistoryId = 2,
                            BorrowedDate = new DateTime(2023, 3, 27, 1, 45, 21, 316, DateTimeKind.Utc).AddTicks(8928),
                            EmployeeId = 3,
                            EquipmentId = 2,
                            IsAproved = true
                        });
                });

            modelBuilder.Entity("ApiEquipment.Entities.EquipmentType", b =>
                {
                    b.Property<int>("EquipmentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EquipmentTypeId"));

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("EquipmentTypeId");

                    b.ToTable("EquipmentTypes");

                    b.HasData(
                        new
                        {
                            EquipmentTypeId = 1,
                            TypeName = "PC"
                        },
                        new
                        {
                            EquipmentTypeId = 2,
                            TypeName = "Laptop"
                        });
                });

            modelBuilder.Entity("ApiEquipment.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            RoleName = "User"
                        },
                        new
                        {
                            RoleId = 2,
                            RoleName = "Admin"
                        });
                });

            modelBuilder.Entity("ApiEquipment.Entities.EmployeeRole", b =>
                {
                    b.HasOne("ApiEquipment.Entities.Employee", "Employee")
                        .WithMany("EmployeeRoles")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiEquipment.Entities.Role", "Role")
                        .WithMany("EmployeeRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ApiEquipment.Entities.Equipment", b =>
                {
                    b.HasOne("ApiEquipment.Entities.EquipmentType", "EquipmentType")
                        .WithMany()
                        .HasForeignKey("EquipmentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EquipmentType");
                });

            modelBuilder.Entity("ApiEquipment.Entities.EquipmentHistory", b =>
                {
                    b.HasOne("ApiEquipment.Entities.Employee", "Employee")
                        .WithMany("EquipmentHistories")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiEquipment.Entities.Equipment", "Equipment")
                        .WithMany("EquipmentHistories")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("ApiEquipment.Entities.Employee", b =>
                {
                    b.Navigation("EmployeeRoles");

                    b.Navigation("EquipmentHistories");
                });

            modelBuilder.Entity("ApiEquipment.Entities.Equipment", b =>
                {
                    b.Navigation("EquipmentHistories");
                });

            modelBuilder.Entity("ApiEquipment.Entities.Role", b =>
                {
                    b.Navigation("EmployeeRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
