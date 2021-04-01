using System.Collections.Generic;
using System.Linq;

namespace LenselinkAsg4Cars.Models
{
    public static class DB
    {
        private static bool isYearAsc = true;
        private static bool isPriceAsc = true;
        private static bool isMileAsc = true;
        private static bool isMakeAsc = true;
        private static bool isColorAsc = true;
        private static bool isIDAsc = true;

        private static List<Car> cars = new List<Car>();

        public static List<Car> GetCars()
        {
            if(cars.Count < 1)
            {
                LoadCars();
            }
            return cars;
        }
        public static List<Car> LoadCars()
        {
            cars.Add(new Car("2013", "Nissan Sentra", "8995", "84574", "Silver"));
            cars.Add(new Car("2014", "Chevrolet Spark LS", "8995", "35304", "Blue"));
            cars.Add(new Car("2013", "Ford Escape 4WD SE", "10900", "70873", "Blue"));
            cars.Add(new Car("2014", "Kia Soul", "10900", "54691", "White"));
            cars.Add(new Car("2013", "Hyundai Tucson AWD", "11900", "72115", "Green"));
            cars.Add(new Car("2018", "Nissan Versa", "11900", "44013", "Red"));
            cars.Add(new Car("2015", "Chevrolet Equinox AWD LS", "11900", "94401", "Silver"));
            cars.Add(new Car("2015", "Kia Sedona LX", "11900", "72751", "Red"));
            cars.Add(new Car("2016", "Hyundai Veloster", "11900", "49369", "White"));
            cars.Add(new Car("2011", "Cadillac DTS Luxury", "12900", "76443", "White"));
            cars.Add(new Car("2014", "Chevrolet Malibu LS w/ PROTECTION PACKAGE", "12900", "28232", "Blue"));
            cars.Add(new Car("2018", "Nissan Sentra", "13900", "37665", "White"));
            cars.Add(new Car("2014", "Subaru Crosstrek 2.0i Premium", "13900", "65360", "Tan"));
            cars.Add(new Car("2017", "Hyundai Elantra Sedan", "13900", "29059", "Blue"));
            cars.Add(new Car("2017", "Hyundai Elantra Sedan w/ CARGO PACKAGE", "14900", "25474", "White"));
            cars.Add(new Car("2016", "Dodge Grand Caravan SXT", "14900", "70812", "Black"));
            cars.Add(new Car("2016", "Jeep Cherokee 4WD Sport", "14900", "73122", "Silver"));
            cars.Add(new Car("2017", "Chevrolet Cruze LT Sedan", "14900", "20560", "Red"));
            cars.Add(new Car("2017", "Hyundai Elantra Sedan", "14900", "24851", "Red"));
            cars.Add(new Car("2014", "Cadillac CTS Sedan w/ SEATING PACKAGE", "14900", "69141", "Black"));
            cars.Add(new Car("2016", "Dodge Grand Caravan SXT", "15495", "70133", "White"));
            cars.Add(new Car("2017", "Nissan Altima", "15900", "14808", "Gray"));
            cars.Add(new Car("2017", "Chevrolet Trax AWD LS", "15900", "21027", "Silver"));
            cars.Add(new Car("2016", "Nissan Rogue AWD w/ SV PREMIUM PACKAGE", "15900", "53087", "Red"));
            cars.Add(new Car("2019", "Chevrolet Sonic LT Sedan w/ RS PACKAGE", "15900", "2928", "White"));
            cars.Add(new Car("2017", "Dodge Grand Caravan SXT", "15900", "68671", "Gray"));
            cars.Add(new Car("2016", "Buick Encore FWD Convenience", "15900", "17734", "Red"));
            cars.Add(new Car("2016", "Buick Encore AWD", "15900", "40059", "Gray"));
            cars.Add(new Car("2008", "Jeep Wrangler 4WD Sahara", "15900", "71164", "Silver"));
            cars.Add(new Car("2016", "Chevrolet Malibu LT", "15900", "42687", "Silver"));
            cars.Add(new Car("2017", "Hyundai Sonata SE", "15900", "30066", "Red"));
            cars.Add(new Car("2017", "Nissan Altima", "15900", "52533", "Gray"));
            cars.Add(new Car("2018", "Ford Focus SE Hatchback", "15900", "8040", "Yellow"));
            cars.Add(new Car("2015", "Honda Civic Si Coupe", "15900", "76904", "Blue"));
            cars.Add(new Car("2013", "Ford Explorer 4WD", "15900", "61089", "Black"));
            cars.Add(new Car("2017", "Nissan Altima", "16495", "30478", "White"));
            cars.Add(new Car("2013", "Cadillac XTS Luxury", "16900", "64693", "Silver"));
            cars.Add(new Car("2017", "Ford Fusion SE", "16900", "29494", "White"));
            cars.Add(new Car("2018", "Nissan Altima", "16900", "36416", "Red"));
            cars.Add(new Car("2019", "Nissan Sentra", "16900", "8749", "Blue"));
            cars.Add(new Car("2016", "Dodge Grand Caravan SE", "16900", "38075", "Red"));
            cars.Add(new Car("2017", "Chevrolet Equinox AWD LS", "16900", "35675", "Black"));
            cars.Add(new Car("2016", "GMC Terrain AWD SLE w/ SLE-1", "16900", "34019", "Red"));
            cars.Add(new Car("2016", "Hyundai Santa Fe AWD Sport w/ OPTION GROUP 03", "17495", "62375", "Blue"));
            cars.Add(new Car("2017", "Chevrolet Equinox AWD LT w/ CONVENIENCE PACKAGE", "17900", "37334", "Silver"));
            cars.Add(new Car("2016", "Buick Encore AWD Premium", "17900", "49013", "White"));
            cars.Add(new Car("2015", "Honda CR-V AWD EX-L", "17900", "73227", "Silver"));
            cars.Add(new Car("2016", "MAZDA CX-3", "17900", "45925", "Blue"));
            cars.Add(new Car("2016", "Hyundai Tucson AWD", "17900", "32063", "Orange"));
            cars.Add(new Car("2015", "Toyota RAV4 AWD Limited", "17900", "69173", "Red"));
            cars.Add(new Car("2000", "Honda Accord", "1000", "500000", "Silver"));
            cars.Add(new Car("2006", "Saturn Vue", "1800", "160000", "Silver"));
            cars.Add(new Car("2014", "Chevrolet Express", "14000", "200000", "White"));
            cars.Add(new Car("2007", "Chevrolet Suburban", "3600", "113000", "Gray"));
            return cars;
        }

        public static List<Car> sortByYear(string order = "")
        {
            List<Car> sortedList = new List<Car>();

            if (order == "order-asc")
            {
                isYearAsc = true;
            }
            else if (order == "order-desc")
            {
                isYearAsc = false;
            }

            if (isYearAsc)
                sortedList = cars.OrderBy(o => o.Year).ToList();
            else
                sortedList = cars.OrderByDescending(o => o.Year).ToList();


            if (order == "")
            {
                isYearAsc = !isYearAsc;
            }
            
            return sortedList;
        }

        public static List<Car> sortByMiles(string order = "")
        {
            List<Car> sortedList = new List<Car>();

            if (order == "order-asc")
            {
                isMileAsc = true;
            }
            else if (order == "order-desc")
            {
                isMileAsc = false;
            }

            if (isMileAsc)
                sortedList = cars.OrderBy(o => o.Mileage).ToList();
            else
                sortedList = cars.OrderByDescending(o => o.Mileage).ToList();
            
            if (order == "")
                isMileAsc = !isMileAsc;

            return sortedList;
        }

        public static List<Car> sortByPrice(string order = "")
        {
            List<Car> sortedList = new List<Car>();

            if (order == "order-asc")
            {
                isPriceAsc = true;
            }
            else if (order == "order-desc")
            {
                isPriceAsc = false;
            }

            if (isPriceAsc)
                sortedList = cars.OrderBy(o => o.Price).ToList();
            else
                sortedList = cars.OrderByDescending(o => o.Price).ToList();
            
            if (order == "")
                isPriceAsc = !isPriceAsc;

            return sortedList;
        }

        public static List<Car> sortByMake(string order = "")
        {
            List<Car> sortedList = new List<Car>();

            if (order == "order-asc")
            {
                isMakeAsc = true;
            }
            else if (order == "order-desc")
            {
                isMakeAsc = false;
            }

            if (isMakeAsc)
                sortedList = cars.OrderBy(o => o.MakeModel).ToList();
            else
                sortedList = cars.OrderByDescending(o => o.MakeModel).ToList();

            if (order == "")
                isMakeAsc = !isMakeAsc;

            return sortedList;
        }

        public static List<Car> sortByColor(string order = "")
        {
            List<Car> sortedList = new List<Car>();

            if (order == "order-asc")
            {
                isColorAsc = true;
            }
            else if (order == "order-desc")
            {
                isColorAsc = false;
            }

            if (isColorAsc)
                sortedList = cars.OrderBy(o => o.Color).ToList();
            else
                sortedList = cars.OrderByDescending(o => o.Color).ToList();

            if (order == "")
                isColorAsc = !isColorAsc;

            return sortedList;
        }

        public static List<Car> sortByID(string order = "")
        {
            List<Car> sortedList = new List<Car>();

            if (order == "order-asc")
            {
                isIDAsc = true;
            }
            else if (order == "order-desc")
            {
                isIDAsc = false;
            }

            if (isIDAsc)
                sortedList = cars.OrderBy(o => o.ID).ToList();
            else
                sortedList = cars.OrderByDescending(o => o.ID).ToList();


            if (order == "")
                isIDAsc = !isIDAsc;

            return sortedList;
        }

        public static List<Car> getByMake(string make = "")
        {
            List<Car> makeList = new List<Car>();

            if(make != "")
            {
                var tempList = GetCars();
                foreach(var car in tempList)
                {
                    if(car.MakeModel.ToLower().Contains(make.ToLower()))
                    {
                        makeList.Add(car);
                    }
                }
            }
            else
            {
                makeList = GetCars();
            }
            //if (isMakeAsc)
            //    sortedList = cars.OrderBy(o => o.MakeModel).ToList();
            //else
            //    sortedList = cars.OrderByDescending(o => o.MakeModel).ToList();

            return makeList;
        }

        public static Car GetCarByID(int id)
        {
            List<Car> allCars = DB.GetCars();
            foreach (Car c in allCars)
            {
                if (c.ID == id)
                {
                    return c;
                }
            }
            return null;
        }

        public static void AddUpdateCar(Car newCar)
        {
            List<Car> matches = cars.FindAll(x => x.ID == newCar.ID);

            if (matches.Count > 0)
            {
                var carIndex = 0;
                carIndex = cars.FindIndex(o => o.ID == newCar.ID);

                if(carIndex > -1)
                {
                    cars[carIndex] = newCar;
                }
            }
            else
            {
                cars.Add(newCar);
            }
        }
    }
}
