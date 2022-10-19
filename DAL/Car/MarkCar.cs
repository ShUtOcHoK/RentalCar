using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalCar.DAL.Car
{
    public class MarkCar
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [InverseProperty(nameof(Car.MarkCar))]
        public ICollection<Car> Cars { get; set; }
    }
}
