using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LenselinkAsg4Cars.Models;
using System;

namespace LenselinkAsg4Cars.Controllers
{
    public class CarsController : Controller
    {
        [Route("Cars")]
        [Route("Cars/List")]
        public IActionResult List()
        {
            List<Car> cars = DB.GetCars();

            return View(cars);
        }

        public IActionResult List(List<Car> cars)
        {
            return View(cars);
        }

        [Route("Cars/SortBy/{sortby}")]
        [Route("Cars/SortBy/{sortby}/{order}")]
        public IActionResult List(string sortby, string order = "")
        {
            List<Car> cars = new List<Car>();
            switch (sortby)
            {
                case ("MakeModel"):
                    cars = DB.sortByMake(order);
                    break;
                case ("Year"):
                    cars = DB.sortByYear(order);
                    break;
                case ("Price"):
                    cars = DB.sortByPrice(order);
                    break;
                case ("Mileage"):
                    cars = DB.sortByMiles(order);
                    break;
                case ("Color"):
                    cars = DB.sortByColor(order);
                    break;
                case ("ID"):
                    cars = DB.sortByID(order);
                    break;
                default:
                    cars = DB.GetCars();
                    break;
            }
            return List(cars);
        }

        [Route("Cars/{make}")]
        public IActionResult List(string make)
        {
            List<Car> cars = DB.getByMake(make);
            return List(cars);
        }

        [Route("Car/{id}")]
        public IActionResult Detail(int id)
        {
            Car car = DB.GetCarByID(id);
            return View(car);
        }

        [Route("Car/AddEdit/{id}")]
        public IActionResult AddEdit(int id)
        {
            Car car = DB.GetCarByID(id);
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
            if(ID > 0)
            {
                car = DB.GetCarByID(ID);
                car.MakeModel = inputMakeModel;
                car.Mileage = inputMiles;
                car.Year = inputYear;
                car.Price = inputPrice;
                car.Color = inputColor;
            }
            else
            {
                car = new Car(inputYear.ToString(), inputMakeModel, inputPrice.ToString(), inputMiles.ToString(), inputColor);
            }



            DB.AddUpdateCar(car);

            List<Car> cars = DB.GetCars();

            return RedirectToAction("List", cars);
        }
    }
}
