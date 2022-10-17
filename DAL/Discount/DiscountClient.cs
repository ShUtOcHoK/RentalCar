using System.ComponentModel.DataAnnotations;

namespace RentalCar.DAL.Discount
{
    public class DiscountClient
    {
        [Key]
        public int Id {get; set;}
        [Required]
        public int Count {get; set;}
        [Required]
        public int Price {get; set;}
        [Required]
        public int Percent {get; set;}
    }
}
