using RentalCar.DAL.Account;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalCar.DAL.Rental
{
    public class ReturnRental
    {
        [Key]
        public int Id {get;set;}
        [Required]
        public DateTime Dete {get;set;}
        [Required]
        public int Price {get;set;}
        [Required]
        public int Rental_Id { get; set; }
        [ForeignKey(nameof(Rental_Id))]
        [InverseProperty(nameof(DAL.Rental.Rental.ReturnRental))]
        public Rental Rental { get; set; }

    }
}
