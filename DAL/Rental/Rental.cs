using RentalCar.DAL.Account;
using RentalCar.DAL.Car;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalCar.DAL.Rental
{
    public class Rental
    {
        [Key]
        public int Id {get;set;}
        [Required]
        public DateTime FirstDate {get;set;}
        [Required]
        public DateTime LastDate {get;set;}
        [Required]
        public int Price {get;set;}
        [Required]
        public int Discount {get;set;}

        [Required]
        public int PersonalData_Id { get; set; }

        [ForeignKey(nameof(PersonalData_Id))]
        [InverseProperty(nameof(DAL.Account.PersonalData.Rentals))]
        public PersonalData PersonalData { get; set; }

        [Required]
        public int Car_Id { get; set; }

        [ForeignKey(nameof(Car_Id))]
        [InverseProperty(nameof(DAL.Car.Car.Rentals))]
        public Car.Car Car { get; set; }

        [InverseProperty(nameof(DAL.Rental.ReturnRental.Rental))]
        public ReturnRental ReturnRental { get; set; }
    }
}
