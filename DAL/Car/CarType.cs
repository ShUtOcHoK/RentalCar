using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalCar.DAL.Car
{
    public class CarType
    {
        [Key]
        public int Id {get; set;}
        [Required]
        public string Name {get; set;}

        [InverseProperty(nameof(Car.CarType))]
        public ICollection<Car> Cars { get; set; }

    }
}
