using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LenselinkAsg4Cars.Models;
using LenselinkAsg10.Models;
using System.Linq;

namespace LenselinkAsg4Cars.Controllers
{
    public class CarsController : Controller
    {
        private static bool isYearAsc = true;
        private static bool isPriceAsc = true;
        private static bool isMileAsc = true;
        private static bool isMakeAsc = true;
        private static bool isColorAsc = true;
        private static bool isIDAsc = true;
        private CarContext context { get; set; }

        public CarsController(CarContext ctx)
        {
            context = ctx;
        }

        [Route("Cars")]
        [Route("Cars/List")]
        public IActionResult List()
        {
            IQueryable<Car> cars = context.Cars.OrderBy(m => m.ID);

            return View(cars);
        }

        public IActionResult List(List<Car> cars)
        {
            return View(cars);
        }

        public IActionResult List(IQueryable<Car> cars)
        {
            return View(cars);
        }

        [Route("Cars/SortBy/{sortby}")]
        [Route("Cars/SortBy/{sortby}/{order}")]
        public IActionResult List(string sortby, string order = "")
        {
            IQueryable<Car> cars;
            switch (sortby)
            {
                case ("MakeModel"):
                    if (isMakeAsc)
                        cars = context.Cars.OrderBy(m => m.MakeModel);
                    else
                        cars = context.Cars.OrderByDescending(m => m.MakeModel);
                    isMakeAsc = !isMakeAsc;
                    break;
                case ("Year"):
                    if (isYearAsc)
                        cars = context.Cars.OrderBy(m => m.Year);
                    else
                        cars = context.Cars.OrderByDescending(m => m.Year);
                    isYearAsc = !isYearAsc;
                    break;
                case ("Price"):
                    if (isPriceAsc)
                        cars = context.Cars.OrderBy(m => m.Price);
                    else
                        cars = context.Cars.OrderByDescending(m => m.Price);
                    isPriceAsc = !isPriceAsc;
                    break;
                case ("Mileage"):
                    if (isMileAsc)
                        cars = context.Cars.OrderBy(m => m.Mileage);
                    else
                        cars = context.Cars.OrderByDescending(m => m.Mileage);
                    isMileAsc = !isMileAsc;
                    break;
                case ("Color"):
                    if (isColorAsc)
                        cars = context.Cars.OrderBy(m => m.Color);
                    else
                        cars = context.Cars.OrderByDescending(m => m.Color);
                    isColorAsc = !isColorAsc;
                    break;
                case ("ID"):
                    if (isIDAsc)
                        cars = context.Cars.OrderBy(m => m.ID);
                    else
                        cars = context.Cars.OrderByDescending(m => m.ID);
                    isIDAsc = !isIDAsc;
                    break;
                default:
                    cars = context.Cars.OrderBy(m => m.ID);
                    break;
            }
            return List(cars);
        }

        [Route("Cars/{make}")]
        public IActionResult List(string make)
        {
            List<Car> makeList = new List<Car>();
            var tempList = context.Cars;

            if (make != "")
            {
                
                foreach (var car in tempList)
                {
                    if (car.MakeModel.ToLower().Contains(make.ToLower()))
                    {
                        makeList.Add(car);
                    }
                }
            }
            else
            {
                makeList = tempList.ToList();
            }

            return List(makeList.AsQueryable());
        }

        [Route("Car/{id}")]
        public IActionResult Detail(int id)
        {
            Car car = context.Cars.Find(id);
            return View(car);
        }

        [Route("Car/AddEdit/{id}")]
        public IActionResult AddEdit(int id)
        {
            Car car = context.Cars.Find(id);
            return View(car);
        }

        [Route("Car/Add")]
        [Route("Car/AddEdit")]
        public IActionResult AddEdit()
        {
            Car car = new Car();
            return View(car);
        }

        [Route("Cars/Save/{ID}")]
        public IActionResult Save(int ID, string inputMakeModel, int inputMiles, int inputYear, int inputPrice, string inputColor)
        {
            Car car;
            if (ID > 0)
            {
                car = context.Cars.Find(ID);
                car.MakeModel = inputMakeModel;
                car.Mileage = inputMiles;
                car.Year = inputYear;
                car.Price = inputPrice;
                car.Color = inputColor;

                context.Cars.Update(car);
            }
            else
            {
                car = new Car(inputYear.ToString(), inputMakeModel, inputPrice.ToString(), inputMiles.ToString(), inputColor);
                context.Cars.Add(car);
            }
            context.SaveChanges();
            IQueryable cars = context.Cars;
            return RedirectToAction("List", cars);
        }
    }
}
