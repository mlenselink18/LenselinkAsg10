using LenselinkAsg4Cars.Models;
using Microsoft.EntityFrameworkCore;

namespace LenselinkAsg10.Models
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options)
            : base(options)
        { }

        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car("2013", "Nissan Sentra", "8995", "84574", "Silver"),
                new Car("2014", "Chevrolet Spark LS", "8995", "35304", "Blue"),
                new Car("2013", "Ford Escape 4WD SE", "10900", "70873", "Blue"),
                new Car("2014", "Kia Soul", "10900", "54691", "White"),
                new Car("2013", "Hyundai Tucson AWD", "11900", "72115", "Green"),
                new Car("2018", "Nissan Versa", "11900", "44013", "Red"),
                new Car("2015", "Chevrolet Equinox AWD LS", "11900", "94401", "Silver"),
                new Car("2015", "Kia Sedona LX", "11900", "72751", "Red")
             );
        }
    }
}
