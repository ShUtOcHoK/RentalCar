using System.ComponentModel.DataAnnotations;

namespace RentalCar.DAL.Discount
{
    public class DiscountCar
    {
        [Key]
        public int Id {get; set;}
        [Required]
        public int MinYear {get; set;}
        [Required]
        public int Percent {get; set;}
    }
}
