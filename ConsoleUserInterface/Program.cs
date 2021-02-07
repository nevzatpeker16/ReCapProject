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
            arabaGetir(carManager1);
            tumOzellikler(carManager1);

        }

        private static void arabaGetir(CarManager carManager1)
        {
            Car nevzat = new Car() { CarID = 1, ColorID = 1, BrandID = 1, DailyPrice = 5, Description = "Audi", ModelYear = 2021 };
            carManager1.AddCar(nevzat);
            foreach (var cars in carManager1.GetCars())
            {
                Console.WriteLine(cars.Description);
            }
        }
        private static void tumOzellikler(CarManager carManager1)
        {
            carManager1.GetCarDetail();
            foreach (var detail in carManager1.GetCarDetail())
            {
                Console.WriteLine("Araba Marka : {0}  Araba Id : {1} Araba Adı :  {2} Araba Renk :  {3}  Araba Ücreti : {4} Araba Model Yılı :  {5} ",detail.BrandName,detail.CarID,detail.Description,detail.ColorName,detail.DailyPrice,detail.ModelYear);

            }
        }       
        }
    }

