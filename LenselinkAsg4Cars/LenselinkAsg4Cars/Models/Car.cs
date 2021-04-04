using System;
using System.ComponentModel.DataAnnotations;

namespace LenselinkAsg4Cars.Models
{
    public class Car
    {
        private static int id;

        public enum SortOrder { MakeModel, Year, Price, Mileage, Color }

        public Car()
        {
            id++;
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

        [Required(ErrorMessage = "Please enter a name.")]
        public string MakeModel { get; set; }

        [Required(ErrorMessage = "Please enter a year.")]
        [Range(1889, 2050, ErrorMessage = "Year must be between 1889 and now.")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Please enter a year.")]
        [Range(0, 1000000000, ErrorMessage = "Price must be a positive number.")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Please enter a year.")]
        [Range(0, 100000000, ErrorMessage = "Mileage must be a positive number.")]
        public int Mileage { get; set; }

        [Required(ErrorMessage = "Please enter a color.")]
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
