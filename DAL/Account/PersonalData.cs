using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalCar.DAL.Account
{
    public class PersonalData
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
       
        public string Patronymic { get; set; }
        [Required]
        public string Addres { get; set; }
        [Required]
        public string Phone { get; set; }
       
        [InverseProperty(nameof(DAL.Account.Account.PersonalData))]
        public Account Account { get; set; }

        [InverseProperty(nameof(DAL.Rental.Rental.PersonalData))]
        public ICollection<Rental.Rental> Rentals { get; set; }
    }
}
