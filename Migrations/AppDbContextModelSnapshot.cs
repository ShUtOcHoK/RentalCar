﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentalCar.DAL;

#nullable disable

namespace RentalCar.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RentalCar.DAL.Account.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonalData_Id")
                        .HasColumnType("int");

                    b.Property<int>("Role_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonalData_Id")
                        .IsUnique();

                    b.HasIndex("Role_Id");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Login = "admin",
                            Password = "admin",
                            PersonalData_Id = 1,
                            Role_Id = 1
                        },
                        new
                        {
                            Id = 2,
                            Login = "manager1",
                            Password = "manager1",
                            PersonalData_Id = 2,
                            Role_Id = 2
                        },
                        new
                        {
                            Id = 3,
                            Login = "manager2",
                            Password = "manager2",
                            PersonalData_Id = 3,
                            Role_Id = 2
                        },
                        new
                        {
                            Id = 4,
                            Login = "client1",
                            Password = "client1",
                            PersonalData_Id = 4,
                            Role_Id = 3
                        },
                        new
                        {
                            Id = 5,
                            Login = "client2",
                            Password = "client2",
                            PersonalData_Id = 5,
                            Role_Id = 3
                        },
                        new
                        {
                            Id = 6,
                            Login = "client3",
                            Password = "client3",
                            PersonalData_Id = 6,
                            Role_Id = 3
                        });
                });

            modelBuilder.Entity("RentalCar.DAL.Account.PersonalData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Addres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PersonalDatas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Addres = "60 лет Гагарина",
                            FirstName = "Андрей",
                            LastName = "Пушкин",
                            Patronymic = "Валерьевич",
                            Phone = "89145659031"
                        },
                        new
                        {
                            Id = 2,
                            Addres = "Улица бессмертного",
                            FirstName = "Александр",
                            LastName = "Частоступов",
                            Patronymic = "Сергеевич",
                            Phone = "89457143083"
                        },
                        new
                        {
                            Id = 3,
                            Addres = "Ленинградский",
                            FirstName = "Ирина",
                            LastName = "Сучкова",
                            Patronymic = "Сергеевна",
                            Phone = "89610048783"
                        },
                        new
                        {
                            Id = 4,
                            Addres = "Перегорская",
                            FirstName = "Максим",
                            LastName = "Беляев",
                            Patronymic = "Павлович",
                            Phone = "89633358392"
                        },
                        new
                        {
                            Id = 5,
                            Addres = "Косой переулок",
                            FirstName = "Анжела",
                            LastName = "Скоропогодька",
                            Patronymic = "Александровна",
                            Phone = "89996669993"
                        },
                        new
                        {
                            Id = 6,
                            Addres = "Бегущий в лабиринте",
                            FirstName = "Алексе ",
                            LastName = "Чередниченко",
                            Patronymic = "Владимирович",
                            Phone = "89137095738"
                        });
                });

            modelBuilder.Entity("RentalCar.DAL.Account.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Администратор"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Менеджер"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Клиент"
                        });
                });

            modelBuilder.Entity("RentalCar.DAL.Car.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BasePrice")
                        .HasColumnType("int");

                    b.Property<int>("CarStatus_Id")
                        .HasColumnType("int");

                    b.Property<int>("CarType_Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarStatus_Id");

                    b.HasIndex("CarType_Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BasePrice = 1500,
                            CarStatus_Id = 1,
                            CarType_Id = 1,
                            Name = "Ford",
                            Number = "CB234P",
                            Year = 2001
                        },
                        new
                        {
                            Id = 2,
                            BasePrice = 700,
                            CarStatus_Id = 2,
                            CarType_Id = 2,
                            Name = "Honda",
                            Number = "CE254P",
                            Year = 2020
                        },
                        new
                        {
                            Id = 3,
                            BasePrice = 1000,
                            CarStatus_Id = 2,
                            CarType_Id = 1,
                            Name = "Jeep",
                            Number = "BB238P",
                            Year = 2015
                        },
                        new
                        {
                            Id = 4,
                            BasePrice = 600,
                            CarStatus_Id = 1,
                            CarType_Id = 2,
                            Name = "Nissan",
                            Number = "CP634P",
                            Year = 2007
                        },
                        new
                        {
                            Id = 5,
                            BasePrice = 650,
                            CarStatus_Id = 1,
                            CarType_Id = 2,
                            Name = "Toyota",
                            Number = "CX294P",
                            Year = 2009
                        },
                        new
                        {
                            Id = 6,
                            BasePrice = 800,
                            CarStatus_Id = 1,
                            CarType_Id = 2,
                            Name = "Lada",
                            Number = "CA847T",
                            Year = 2019
                        });
                });

            modelBuilder.Entity("RentalCar.DAL.Car.CarStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CarStatys");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Рабочая"
                        },
                        new
                        {
                            Id = 2,
                            Name = "На обслуживании"
                        });
                });

            modelBuilder.Entity("RentalCar.DAL.Car.CarType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CarTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Грузовая"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Легковая"
                        });
                });

            modelBuilder.Entity("RentalCar.DAL.Discount.DiscountCar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MinYear")
                        .HasColumnType("int");

                    b.Property<int>("Percent")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DiscountCars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MinYear = 5,
                            Percent = 0
                        },
                        new
                        {
                            Id = 2,
                            MinYear = 10,
                            Percent = 5
                        },
                        new
                        {
                            Id = 3,
                            MinYear = 15,
                            Percent = 10
                        });
                });

            modelBuilder.Entity("RentalCar.DAL.Discount.DiscountClient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Percent")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DiscountClients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Percent = 2,
                            Price = 10000
                        },
                        new
                        {
                            Id = 2,
                            Percent = 3,
                            Price = 15000
                        },
                        new
                        {
                            Id = 3,
                            Percent = 5,
                            Price = 20000
                        },
                        new
                        {
                            Id = 4,
                            Percent = 7,
                            Price = 30000
                        },
                        new
                        {
                            Id = 5,
                            Percent = 10,
                            Price = 50000
                        });
                });

            modelBuilder.Entity("RentalCar.DAL.Rental.Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Car_Id")
                        .HasColumnType("int");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<DateTime>("FirstDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PersonalData_Id")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Car_Id");

                    b.HasIndex("PersonalData_Id");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("RentalCar.DAL.Rental.ReturnRental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Dete")
                        .HasColumnType("datetime2");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Rental_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Rental_Id")
                        .IsUnique();

                    b.ToTable("ReturnRentals");
                });

            modelBuilder.Entity("RentalCar.DAL.Account.Account", b =>
                {
                    b.HasOne("RentalCar.DAL.Account.PersonalData", "PersonalData")
                        .WithOne("Account")
                        .HasForeignKey("RentalCar.DAL.Account.Account", "PersonalData_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentalCar.DAL.Account.Role", "Role")
                        .WithMany("Accounts")
                        .HasForeignKey("Role_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonalData");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("RentalCar.DAL.Car.Car", b =>
                {
                    b.HasOne("RentalCar.DAL.Car.CarStatus", "CarStatus")
                        .WithMany("Cars")
                        .HasForeignKey("CarStatus_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentalCar.DAL.Car.CarType", "CarType")
                        .WithMany("Cars")
                        .HasForeignKey("CarType_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarStatus");

                    b.Navigation("CarType");
                });

            modelBuilder.Entity("RentalCar.DAL.Rental.Rental", b =>
                {
                    b.HasOne("RentalCar.DAL.Car.Car", "Car")
                        .WithMany("Rentals")
                        .HasForeignKey("Car_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentalCar.DAL.Account.PersonalData", "PersonalData")
                        .WithMany("Rentals")
                        .HasForeignKey("PersonalData_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("PersonalData");
                });

            modelBuilder.Entity("RentalCar.DAL.Rental.ReturnRental", b =>
                {
                    b.HasOne("RentalCar.DAL.Rental.Rental", "Rental")
                        .WithOne("ReturnRental")
                        .HasForeignKey("RentalCar.DAL.Rental.ReturnRental", "Rental_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rental");
                });

            modelBuilder.Entity("RentalCar.DAL.Account.PersonalData", b =>
                {
                    b.Navigation("Account")
                        .IsRequired();

                    b.Navigation("Rentals");
                });

            modelBuilder.Entity("RentalCar.DAL.Account.Role", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("RentalCar.DAL.Car.Car", b =>
                {
                    b.Navigation("Rentals");
                });

            modelBuilder.Entity("RentalCar.DAL.Car.CarStatus", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("RentalCar.DAL.Car.CarType", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("RentalCar.DAL.Rental.Rental", b =>
                {
                    b.Navigation("ReturnRental")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
