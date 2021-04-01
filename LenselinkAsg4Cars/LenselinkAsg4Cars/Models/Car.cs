using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LenselinkAsg4Cars.Models
{
    public class Car
    {
        private static int id;

        public enum SortOrder { MakeModel, Year, Price, Mileage, Color }

        public Car()
        {
            id++;
            ID = id;
            ID = 0;
            MakeModel = "";
            Year = 0;
            Price = 0;
            Mileage = 0;
            Color = "";
        }
        public Car(string year, string makeModel, string price, string mileage, string color)
        {
            id++;
            ID = id;
            MakeModel = makeModel;
            Year = int.Parse(year);
            Price = int.Parse(price);
            Mileage = int.Parse(mileage);
            Color = color;
        }
        public int ID { get; set; }
        public string MakeModel { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public int Mileage { get; set; }
        public string Color { get; set; }

        public string IDString
        {
            get
            {
                var display = "";

                if(ID > 0)
                {
                    display = ID.ToString();
                }
                else
                {
                    display = "N/A";
                }

                return display;
            }
        }
    }
}
