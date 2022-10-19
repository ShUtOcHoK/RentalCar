using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentalCar.DAL;
using RentalCar.DAL.Car;
using RentalCar.Models.Home;
using System.Diagnostics;

namespace RentalCar.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            CarsModel model = new CarsModel { Cars = await GetCars(), MarkCars = await GetMarkCars() };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(CarsModel model)
        {
            model.Cars = await GetCars(model.SearchText);
            model.MarkCars = await GetMarkCars();
            return View(model);
        }


        public async Task<IActionResult> MarkCars(int markId)
        {
            var mark = GetMark(markId);
            CarsModel model = new CarsModel { Cars = await GetCars(markId), MarkCars = await GetMarkCars() };
            if (mark is not null)
            {
                model.SearchText = $"{mark.Name}";
                return View("Index", model);
            }

            return View("Index", model);
        }

        private async Task<IEnumerable<Car>> GetCars()
        {
            return await _context.Cars
                .Include(b => b.MarkCar)
                .Include(b => b.CarType)
                .Include(b => b.CarStatus)
                .ToListAsync();
        }
        private async Task<IEnumerable<Car>> GetCars(string searchText)
        {
            return await _context.Cars
                .Where(b => b.Name.Contains(searchText))
                .Include(b => b.MarkCar)
                .Include(b => b.CarType)
                .Include(b => b.CarStatus)
                .ToListAsync();

        }
        private async Task<IEnumerable<MarkCar>> GetMarkCars()
        {
            return await _context.MarkCars.ToListAsync();
        }
        private async Task<IEnumerable<Car>> GetCars(int markId)
        {
            return await _context.Cars
                .Where(b => b.MarkCar_Id == markId)
                .Include(b => b.MarkCar)
                .Include(b => b.CarType)
                .Include(b => b.CarStatus)
                .ToListAsync();
        }
        private Car? GetBook(int carId)
        {
            return _context.Cars
                .FirstOrDefault(b => b.Id == carId);
        }
        private MarkCar? GetMark(int markId)
        {
            return _context.MarkCars
                .FirstOrDefault(a => a.Id == markId);
        }
       
    }
}