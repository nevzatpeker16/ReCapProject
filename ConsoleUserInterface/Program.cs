using Buisness.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Linq;

namespace ConsoleUserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager1 = new CarManager(new EfCarDal());
            Console.WriteLine("Burada Entity Framework ' u deneyeceğiz ");
//            arabaGetir(carManager1);
            tumOzellikler(carManager1);
              
            ColorManager colorManager = new ColorManager(new EfColorDal());
            //            renkEkle(colorManager);
            BrandManager brandManager = new BrandManager(new EfBrandDal());
 //           markaEkle(brandManager);



            }
        private static void renkEkle(ColorManager colorManager)
        {
            Color color1 = new Color
            {
                ColorID = 1,
                ColorName = "Kırmızı"
            };
            colorManager.AddColor(color1);
            Console.WriteLine("Renk eklendi , Eklenen renk  : {0}",color1.ColorName);
        }
        private static void markaEkle(BrandManager brandManager)
        {
            Brand brand1 = new Brand { BrandID = 1, BrandName = "Audi" };
            brandManager.AddBrand(brand1);
            Console.WriteLine("Marka eklendi {0}",brand1.BrandName);
            
        }
        private static void arabaGetir(CarManager carManager1)
        {
            Car nevzat = new Car() { CarID = 2, ColorID = 3, BrandID = 1, DailyPrice = 5, Description = "Audi", ModelYear = 2021 };
            carManager1.AddCar(nevzat);
            foreach (var cars in carManager1.GetCars())
            {
                Console.WriteLine(cars.Description);
            }
        }
        private static void tumOzellikler(CarManager carManager1)
        {
            try
            {
                var carDetail =  carManager1.GetCarDetail();
                if (!carDetail.Any())
                {
                    Console.WriteLine("Tablo Boş");
                }
                foreach (var detail in carDetail)
                {
                    Console.WriteLine("Araba Marka :{0}  Araba Id :{1} Araba Adı :{2} Araba Renk :  {3}  Araba Ücreti : {4} Araba Model Yılı :  {5} ", detail.BrandName, detail.CarID, detail.Description, detail.ColorName, detail.DailyPrice, detail.ModelYear);

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}

