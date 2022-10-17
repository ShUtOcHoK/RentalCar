using RentalCar.DAL.Account;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalCar.DAL.Car
{
    public class Car
    {
        [Key]
        public int Id {get;set;}
        [Required]
        public string Name {get;set;}
        [Required]
        public string Number {get;set;}
        [Required]
        public int Year { get; set; }
        [Required]
        public int BasePrice { get; set; }
        [Required]
        public int CarType_Id { get; set; }
        [ForeignKey(nameof(CarType_Id))]
        [InverseProperty(nameof(DAL.Car.CarType.Cars))]
        public CarType CarType { get; set; }

        [Required]
        public int CarStatus_Id { get; set; }
        [ForeignKey(nameof(CarStatus_Id))]
        [InverseProperty(nameof(DAL.Car.CarStatus.Cars))]
        public CarStatus CarStatus { get; set; }

        [InverseProperty(nameof(DAL.Rental.Rental.Car))]
        public ICollection<Rental.Rental> Rentals { get; set; }

    }
}
