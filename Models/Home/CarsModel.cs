using RentalCar.DAL.Car;

namespace RentalCar.Models.Home
{
    public class CarsModel
    {
        public string SearchText { get; set; } = "";
        public IEnumerable<MarkCar>? MarkCars { get; set; }
        public IEnumerable<Car>? Cars { get; set; }

    }
}
