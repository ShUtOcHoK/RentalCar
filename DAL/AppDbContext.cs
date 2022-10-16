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
        public DbSet<CarStatys> CarStatys { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<DiscountCar> DiscountCars { get; set; }
        public DbSet<DiscountClient> DiscountClients { get; set; }
        public DbSet<Rental.Rental> Rentals { get; set; }
        public DbSet<ReturnRental> ReturnRentals { get; set; }


    }
}
