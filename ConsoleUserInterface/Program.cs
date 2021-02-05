using Buisness.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager1 = new CarManager(new EfCarDal());
            Console.WriteLine("Burada Entity Framework ' u deneyeceğiz ");
            Car nevzat = new Car() {CarID = 1 , ColorID = 1 , BrandID = 1 , DailyPrice = 0 , Description = "Audi",ModelYear = 2021  };
            carManager1.AddCar(nevzat);
            foreach (var cars in carManager1.GetCars())
            {
                Console.WriteLine(cars.Description);
            }
        }
    }
}
