using RentalCar.DAL.Account;
using RentalCar.DAL.Car;
using RentalCar.DAL.Discount;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using RentalCar.DAL.Rental;

namespace RentalCar.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Account.Account> Accounts { get; set; }
        public DbSet<PersonalData> PersonalDatas { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Car.Car> Cars { get; set; }
        public DbSet<CarStatus> CarStatys { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<DiscountCar> DiscountCars { get; set; }
        public DbSet<DiscountClient> DiscountClients { get; set; }
        public DbSet<Rental.Rental> Rentals { get; set; }
        public DbSet<ReturnRental> ReturnRentals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 0, Name = "Администратор" },
                new Role { Id = 1, Name = "Менеджер" },
                new Role { Id = 2, Name = "Клиент" }

            );
            modelBuilder.Entity<PersonalData>().HasData(
                new PersonalData { Id = 0, FirstName = "Андрей", LastName = "Пушкин", Patronymic = "Валерьевич", Addres ="60 лет Гагарина", Phone="89145659031"},
                new PersonalData { Id = 1, FirstName = "Александр", LastName = "Частоступов", Patronymic = "Сергеевич", Addres = "Улица бессмертного", Phone = "89457143083"},
                new PersonalData { Id = 2, FirstName = "Ирина", LastName = "Сучкова", Patronymic = "Сергеевна", Addres = "Ленинградский", Phone = "89610048783"},
                new PersonalData { Id = 3, FirstName = "Максим", LastName = "Беляев", Patronymic = "Павлович", Addres = "Перегорская", Phone = "89633358392" },
                new PersonalData { Id = 4, FirstName = "Анжела", LastName = "Скоропогодька", Patronymic = "Александровна", Addres = "Косой переулок", Phone = "89996669993"},
                new PersonalData { Id = 5, FirstName = "Алексе ", LastName = "Чередниченко", Patronymic = "Владимирович", Addres = "Бегущий в лабиринте", Phone = "89137095738" }
            );
            modelBuilder.Entity<Account.Account>().HasData(
               new Account.Account { Id = 0, Login = "admin", Password = "admin", Role_Id = 0 , PersonalData_Id = 0 },
               new Account.Account { Id = 1, Login = "manager1", Password = "manager1", Role_Id = 1, PersonalData_Id = 1 },
               new Account.Account { Id = 2, Login = "manager2", Password = "manager2", Role_Id = 1, PersonalData_Id = 2 },
               new Account.Account { Id = 3, Login = "client1", Password = "client1", Role_Id = 2, PersonalData_Id = 3 },
               new Account.Account { Id = 4, Login = "client2", Password = "client2", Role_Id = 2, PersonalData_Id = 4 },
               new Account.Account { Id = 5, Login = "client3", Password = "client3", Role_Id = 2, PersonalData_Id = 5 }

           );
            modelBuilder.Entity<Car.Car>().HasData(
              new Car.Car { Id = 0, Name= "Ford", Number="CB234P", Year=2001, CarStatus_Id= 0, CarType_Id= 0, BasePrice=1500 },
              new Car.Car { Id = 1, Name = "Honda", Number = "CE254P", Year = 2020, CarStatus_Id = 1, CarType_Id= 1, BasePrice =700  },
              new Car.Car { Id = 2, Name = "Jeep", Number = "BB238P", Year = 2015, CarStatus_Id = 1, CarType_Id = 0, BasePrice =1000  },
              new Car.Car { Id = 3, Name = "Nissan", Number = "CP634P", Year = 2007, CarStatus_Id =0, CarType_Id =1 , BasePrice =600  },
              new Car.Car { Id = 4, Name = "Toyota", Number = "CX294P", Year = 2009, CarStatus_Id =0, CarType_Id =1 , BasePrice =650 },
              new Car.Car { Id = 5, Name = "Lada", Number = "CA847T", Year = 2019, CarStatus_Id =0, CarType_Id = 1 , BasePrice = 800 }

          );
            modelBuilder.Entity<CarType>().HasData(
               new CarType { Id = 0, Name = "Грузовая" },
               new CarType { Id = 1, Name = "Легковая" }

           );
            modelBuilder.Entity<CarStatus>().HasData(
              new CarStatus { Id = 0, Name = "Рабочая" },
              new CarStatus { Id = 1, Name = "На обслуживании" }

          );
            modelBuilder.Entity<DiscountCar>().HasData(
              new DiscountCar { Id = 0, MinYear = 5, Percent = 0 },
              new DiscountCar { Id = 1, MinYear = 10, Percent = 5},
              new DiscountCar { Id = 2, MinYear = 15, Percent = 10}

          );
            modelBuilder.Entity<DiscountClient>().HasData(
             new DiscountClient { Id = 0, Percent = 2, Price =10000 },
             new DiscountClient { Id = 1, Percent = 3, Price = 15000 },
             new DiscountClient { Id = 2, Percent = 5, Price = 20000 },
             new DiscountClient { Id = 3, Percent = 7, Price = 30000 },
             new DiscountClient { Id = 4, Percent = 10, Price = 50000 }
             
         );
        }
    }
}
